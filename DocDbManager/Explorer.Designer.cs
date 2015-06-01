namespace DocDbManager
{
    partial class Explorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.queryBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.documentsResultBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.collectionsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.runQueryBtn = new System.Windows.Forms.ToolStripButton();
            this.addDocumentBtn = new System.Windows.Forms.ToolStripButton();
            this.importDocumentsBtn = new System.Windows.Forms.ToolStripButton();
            this.exportResultBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.docDbInitialConnectBw = new System.ComponentModel.BackgroundWorker();
            this.docDbRunQueryBw = new System.ComponentModel.BackgroundWorker();
            this.exportQueryResultDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsResultBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // queryBox
            // 
            this.queryBox.AutoCompleteBrackets = true;
            this.queryBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.queryBox.AutoIndentCharsPatterns = "";
            this.queryBox.AutoScrollMinSize = new System.Drawing.Size(137, 15);
            this.queryBox.BackBrush = null;
            this.queryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBox.CharHeight = 15;
            this.queryBox.CharWidth = 7;
            this.queryBox.CommentPrefix = "--";
            this.queryBox.CurrentLineColor = System.Drawing.Color.PaleTurquoise;
            this.queryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.queryBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.queryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.queryBox.IsReplaceMode = false;
            this.queryBox.Language = FastColoredTextBoxNS.Language.SQL;
            this.queryBox.LeftBracket = '(';
            this.queryBox.Location = new System.Drawing.Point(0, 0);
            this.queryBox.Name = "queryBox";
            this.queryBox.Paddings = new System.Windows.Forms.Padding(0);
            this.queryBox.RightBracket = ')';
            this.queryBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.queryBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("queryBox.ServiceColors")));
            this.queryBox.ShowFoldingLines = true;
            this.queryBox.Size = new System.Drawing.Size(927, 109);
            this.queryBox.TabIndex = 1;
            this.queryBox.Text = "SELECT * FROM c ";
            this.queryBox.Zoom = 100;
            this.queryBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.queryBox_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.documentsResultBox);
            this.splitContainer1.Size = new System.Drawing.Size(927, 508);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // documentsResultBox
            // 
            this.documentsResultBox.AutoCompleteBrackets = true;
            this.documentsResultBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.documentsResultBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.documentsResultBox.AutoScrollMinSize = new System.Drawing.Size(284, 15);
            this.documentsResultBox.BackBrush = null;
            this.documentsResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentsResultBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.documentsResultBox.CharHeight = 15;
            this.documentsResultBox.CharWidth = 7;
            this.documentsResultBox.CurrentLineColor = System.Drawing.Color.PaleTurquoise;
            this.documentsResultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.documentsResultBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.documentsResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentsResultBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.documentsResultBox.IsReplaceMode = false;
            this.documentsResultBox.Language = FastColoredTextBoxNS.Language.JS;
            this.documentsResultBox.LeftBracket = '(';
            this.documentsResultBox.LeftBracket2 = '{';
            this.documentsResultBox.Location = new System.Drawing.Point(0, 0);
            this.documentsResultBox.Name = "documentsResultBox";
            this.documentsResultBox.Paddings = new System.Windows.Forms.Padding(0);
            this.documentsResultBox.ReadOnly = true;
            this.documentsResultBox.RightBracket = ')';
            this.documentsResultBox.RightBracket2 = '}';
            this.documentsResultBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.documentsResultBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("documentsResultBox.ServiceColors")));
            this.documentsResultBox.Size = new System.Drawing.Size(927, 394);
            this.documentsResultBox.TabIndex = 2;
            this.documentsResultBox.Text = "[ document results will appear here ]";
            this.documentsResultBox.Zoom = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionsComboBox,
            this.runQueryBtn,
            this.addDocumentBtn,
            this.importDocumentsBtn,
            this.exportResultBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // collectionsComboBox
            // 
            this.collectionsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.collectionsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.collectionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.collectionsComboBox.DropDownWidth = 250;
            this.collectionsComboBox.MaxDropDownItems = 12;
            this.collectionsComboBox.Name = "collectionsComboBox";
            this.collectionsComboBox.Size = new System.Drawing.Size(121, 25);
            this.collectionsComboBox.Sorted = true;
            // 
            // runQueryBtn
            // 
            this.runQueryBtn.Image = ((System.Drawing.Image)(resources.GetObject("runQueryBtn.Image")));
            this.runQueryBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.runQueryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runQueryBtn.Name = "runQueryBtn";
            this.runQueryBtn.Size = new System.Drawing.Size(83, 22);
            this.runQueryBtn.Text = "Run Query";
            this.runQueryBtn.ToolTipText = "Run Query (Ctrl + Enter)";
            this.runQueryBtn.Click += new System.EventHandler(this.runQueryBtn_Click);
            // 
            // addDocumentBtn
            // 
            this.addDocumentBtn.Image = ((System.Drawing.Image)(resources.GetObject("addDocumentBtn.Image")));
            this.addDocumentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addDocumentBtn.Name = "addDocumentBtn";
            this.addDocumentBtn.Size = new System.Drawing.Size(125, 22);
            this.addDocumentBtn.Text = "Create Documents";
            this.addDocumentBtn.ToolTipText = "Create Document (Ctrl + N)";
            this.addDocumentBtn.Click += new System.EventHandler(this.addDocumentBtn_Click);
            // 
            // importDocumentsBtn
            // 
            this.importDocumentsBtn.Image = ((System.Drawing.Image)(resources.GetObject("importDocumentsBtn.Image")));
            this.importDocumentsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importDocumentsBtn.Name = "importDocumentsBtn";
            this.importDocumentsBtn.Size = new System.Drawing.Size(127, 22);
            this.importDocumentsBtn.Text = "Import Documents";
            this.importDocumentsBtn.ToolTipText = "Import a JSON file containing multiple documents (Ctrl + I)";
            this.importDocumentsBtn.Click += new System.EventHandler(this.importDocumentsBtn_Click);
            // 
            // exportResultBtn
            // 
            this.exportResultBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportResultBtn.Image")));
            this.exportResultBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportResultBtn.Name = "exportResultBtn";
            this.exportResultBtn.Size = new System.Drawing.Size(130, 22);
            this.exportResultBtn.Text = "Export Query Result";
            this.exportResultBtn.ToolTipText = "Export the current query result as a JSON file (Ctrl + E)";
            this.exportResultBtn.Click += new System.EventHandler(this.exportResultBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(166, 17);
            this.statusLabel.Text = "Connecting to DocumentDB...";
            // 
            // docDbInitialConnectBw
            // 
            this.docDbInitialConnectBw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.docDbInitialConnectBw_DoWork);
            this.docDbInitialConnectBw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.docDbInitialConnectBw_RunWorkerCompleted);
            // 
            // docDbRunQueryBw
            // 
            this.docDbRunQueryBw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.docDbRunQueryBw_DoWork);
            this.docDbRunQueryBw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.docDbRunQueryBw_RunWorkerCompleted);
            // 
            // exportQueryResultDialog
            // 
            this.exportQueryResultDialog.DefaultExt = "json";
            this.exportQueryResultDialog.FileName = "QueryResult.json";
            this.exportQueryResultDialog.Filter = "Json files|*.json|All files|*.*";
            this.exportQueryResultDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportQueryResultDialog_FileOk);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Explorer";
            this.Text = "DocumentDB Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Explorer_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsResultBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FastColoredTextBoxNS.FastColoredTextBox queryBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton runQueryBtn;
        private FastColoredTextBoxNS.FastColoredTextBox documentsResultBox;
        private System.Windows.Forms.ToolStripButton addDocumentBtn;
        private System.Windows.Forms.ToolStripButton importDocumentsBtn;
        private System.Windows.Forms.ToolStripButton exportResultBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripComboBox collectionsComboBox;
        private System.ComponentModel.BackgroundWorker docDbInitialConnectBw;
        private System.ComponentModel.BackgroundWorker docDbRunQueryBw;
        private System.Windows.Forms.SaveFileDialog exportQueryResultDialog;

    }
}