namespace DocDbManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using Microsoft.Azure.Documents;
    using Microsoft.Azure.Documents.Client;
    using Microsoft.Azure.Documents.Linq;

    using Newtonsoft.Json;

    public partial class Explorer : Form
    {
        private readonly ServerBrowser serverBrowser;

        private readonly DocDbServer documentDbServer;

        private Database documentDbDatabase;

        private DocumentClient documentClient;

        private List<string> collections;

        private List<Document> documentsFromQuery = new List<Document>();
        
        private bool serverConnected;


        public Explorer(ServerBrowser serverBrowser, DocDbServer docDbServer)
        {
            this.InitializeComponent();

            this.serverBrowser = serverBrowser;
            this.documentDbServer = docDbServer;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Disable form fields during inital loading as we connect to DocumentDB
            this.SetPerformingTask("Connecting to DocumentDB...");
            this.docDbInitialConnectBw.RunWorkerAsync();
        }

        private void Explorer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.serverConnected)
            {
                this.serverBrowser.Close();
            }
            else
            {
                this.serverBrowser.Show();
            }
        }

        private void UpdateCollections()
        {
            if (this.collections.Any())
            {
                foreach (var collectionId in this.collections)
                {
                    this.collectionsComboBox.Items.Add(collectionId);
                }

                this.collectionsComboBox.SelectedIndex = 0;
            }
        }
        
        private void runQueryBtn_Click(object sender, EventArgs e)
        {
            this.SetPerformingTask("Running query...");

            var args = new QueryArgs
                           {
                               Query = this.queryBox.Text,
                               CollectionId = this.collectionsComboBox.SelectedItem.ToString()
                           };
            this.docDbRunQueryBw.RunWorkerAsync(args);
        }
        

        #region Background Workers

        private void docDbInitialConnectBw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                this.documentClient = new DocumentClient(new Uri(this.documentDbServer.Endpoint), this.documentDbServer.AccessKey);

                this.documentDbDatabase = this.documentClient.CreateDatabaseQuery().Where(db => db.Id == this.documentDbServer.DatabaseName).AsEnumerable().FirstOrDefault();

                if (this.documentDbDatabase == null)
                {
                    MessageBox.Show("The database specified was not found");
                }
                else
                {
                    this.collections = this.documentClient.CreateDocumentCollectionQuery(this.documentDbDatabase.SelfLink).Select(p => p.Id).ToList();
                    this.serverConnected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                this.Close();
            }
        }

        private void docDbInitialConnectBw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (this.serverConnected)
            {
                this.SetTaskFinished();
                this.UpdateCollections();

                var activeCollection = this.collectionsComboBox.SelectedItem;
                this.queryBox.Text = "SELECT * FROM " + activeCollection + " c WHERE c.";
                this.queryBox.Focus();
                this.queryBox.GoEnd();
            }
            else
            {
                this.Close();
            }
        }


        private void docDbRunQueryBw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var args = e.Argument as QueryArgs;

            try
            {
                var collection = this.documentClient.CreateDocumentCollectionQuery(this.documentDbDatabase.SelfLink)
                    .ToArray().FirstOrDefault(c => c.Id == args.CollectionId);

                var selfLink = collection.SelfLink;

                // Clear out any old results
                this.documentsFromQuery.Clear();
                this.documentsFromQuery.AddRange(this.documentClient.CreateDocumentQuery<Document>(selfLink, args.Query));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void docDbRunQueryBw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.SetTaskFinished(this.documentsFromQuery.Count() + " documents found.");
            this.documentsFromQuery.ToArray();

            var json = JsonConvert.SerializeObject(this.documentsFromQuery);

            this.documentsResultBox.Text = JsonHelper.PrettifyJson(json);

            this.queryBox.Focus();
            this.queryBox.GoEnd();
        }

        #endregion


        #region Helpers

        private void SetPerformingTask(string taskDescription)
        {
            this.statusLabel.Text = taskDescription;

            this.queryBox.Enabled = false;
            this.documentsResultBox.Enabled = false;

            this.runQueryBtn.Enabled = false;
            this.addDocumentBtn.Enabled = false;
            this.exportResultBtn.Enabled = false;
            this.importDocumentsBtn.Enabled = false;
        }

        private void SetTaskFinished(string resultText = "Ready")
        {
            this.statusLabel.Text = resultText;

            this.queryBox.Enabled = true;
            this.documentsResultBox.Enabled = true;

            this.runQueryBtn.Enabled = true;
            this.addDocumentBtn.Enabled = true;
            this.exportResultBtn.Enabled = true;
            this.importDocumentsBtn.Enabled = true;
        }

        private DocumentCollection GetCurrentCollection()
        {
            return this.documentClient.CreateDocumentCollectionQuery(this.documentDbDatabase.SelfLink)
                    .ToArray().FirstOrDefault(c => c.Id == this.collectionsComboBox.SelectedItem.ToString());
        }

        private void ShowCreateDocsForm(bool importDocs)
        {
            var collection = this.GetCurrentCollection();

            var createDocsForm = new CreateDocuments(this.documentClient, collection.SelfLink, importDocs);
            createDocsForm.Show();
        }

        #endregion

        private void queryBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (ModifierKeys.Equals(Keys.Control) && e.KeyCode.Equals(Keys.Return))
            {
                this.runQueryBtn.PerformClick();
            }

            if (ModifierKeys.Equals(Keys.Control) && e.KeyCode.Equals(Keys.N))
            {
                this.addDocumentBtn.PerformClick();
            }

            if (ModifierKeys.Equals(Keys.Control) && e.KeyCode.Equals(Keys.I))
            {
                this.importDocumentsBtn.PerformClick();
            }

            if (ModifierKeys.Equals(Keys.Control) && e.KeyCode.Equals(Keys.E))
            {
                this.exportResultBtn.PerformClick();
            }
        }

        private void exportResultBtn_Click(object sender, EventArgs e)
        {
            this.exportQueryResultDialog.ShowDialog();
        }

        private void exportQueryResultDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string name = this.exportQueryResultDialog.FileName;
            File.WriteAllText(name, this.documentsResultBox.Text);

            this.statusLabel.Text = "Saved query results to file";
        }

        private void addDocumentBtn_Click(object sender, EventArgs e)
        {
            this.ShowCreateDocsForm(false);
        }

        private void importDocumentsBtn_Click(object sender, EventArgs e)
        {
            this.ShowCreateDocsForm(true);
        }
    }

    internal class QueryArgs
    {
        public string Query { get; set; }

        public string CollectionId { get; set; }
    }
}