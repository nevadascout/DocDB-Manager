namespace DocDbManager
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Microsoft.Azure.Documents.Client;
    using Microsoft.Azure.Documents.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public partial class CreateDocuments : Form
    {
        private readonly DocumentClient documentClient;

        private readonly string collectionSelfLink;

        private bool saveClicked;

        private string initialText;

        private bool importDocs;


        public CreateDocuments(DocumentClient documentClient, string collectionSelfLink, bool importDocs)
        {
            this.documentClient = documentClient;
            this.collectionSelfLink = collectionSelfLink;
            this.importDocs = importDocs;

            this.InitializeComponent();
        }

        private void CreateDocuments_Load(object sender, EventArgs e)
        {
            this.queryBox.Focus();

            if (this.importDocs)
            {
                this.queryBox.Text = "[ Paste your document in json here. Arrays of documents are accepted ]";
                this.queryBox.SelectAll();
            }
            else
            {
                this.queryBox.SelectionStart = 26;
            }

            this.initialText = this.queryBox.Text;
        }

        private void CreateDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.TextHasChanged())
            {
                if (this.saveClicked) return;
                
                e.Cancel = true;
                var closeDialog = MessageBox.Show(
                    "You have not created these document(s) in DocumentDB. Did you mean to close this window?",
                    "Create Document in DocumentDB?",
                    MessageBoxButtons.YesNo);

                if (closeDialog == DialogResult.Yes)
                {
                    this.saveClicked = true;
                    this.Close();
                }
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            this.SaveDocument();
        }

        private bool TextHasChanged()
        {
            if (this.queryBox.Text != this.initialText)
            {
                return true;
            }

            return false;
        }
        
        private void SaveDocument()
        {
            try
            {
                // Check JSON is valid
                JsonConvert.DeserializeObject(this.queryBox.Text);
                
                // Use background worker to create documents
                this.createDocumentsBw.RunWorkerAsync(this.queryBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid JSON: " + ex.Message);
            }
        }

        private void CreateDocument(object document)
        {
            this.documentClient.CreateDocumentAsync(this.collectionSelfLink, document);
        }

        private void createDocumentsBw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var query = e.Argument.ToString();

            try
            {
                // Split query into 
                var newQuery = JsonConvert.DeserializeObject(query) as JArray;

                var documents = new List<dynamic>();
                
                foreach (var doc in newQuery)
                {
                    // Convert each json object to a document
                    documents.Add(JObject.Parse(doc.ToString()));
                }

                // Create each document in DocumentDB
                foreach (var document in documents)
                {
                    // Do create
                    this.CreateDocument(document);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void createDocumentsBw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.saveClicked = true;
            this.Close();
        }
        
        private void CreateDocuments_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
