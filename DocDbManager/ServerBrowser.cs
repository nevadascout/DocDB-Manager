namespace DocDbManager
{
    using System.Windows.Forms;

    using DocDbManager.Properties;

    public partial class ServerBrowser : Form
    {
        public ServerBrowser()
        {
            this.InitializeComponent();

            this.accessKeyTxt.Text = Settings.Default.ServerAccessKey;
            this.endpointTxt.Text = Settings.Default.ServerEndpoint;
            this.databaseNameTxt.Text = Settings.Default.DatabaseName;
        }
        
        private void connectBtn_Click(object sender, System.EventArgs e)
        {
            this.ConnectToSelectedServer();

            Settings.Default.ServerAccessKey = this.accessKeyTxt.Text;
            Settings.Default.ServerEndpoint = this.endpointTxt.Text;
            Settings.Default.DatabaseName = this.databaseNameTxt.Text;
            Settings.Default.Save();
        }


        #region Helpers
        
        private void ConnectToSelectedServer()
        {
            this.Hide();

            var server = new DocDbServer
                             {
                                 AccessKey = this.accessKeyTxt.Text,
                                 Endpoint = this.endpointTxt.Text,
                                 DatabaseName = this.databaseNameTxt.Text
                             };

            var serverExplorer = new Explorer(this, server);
            serverExplorer.Show();
        }

        #endregion
    }
}
