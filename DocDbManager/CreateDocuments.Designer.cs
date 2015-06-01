namespace DocDbManager
{
    partial class CreateDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDocuments));
            this.queryBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.createBtn = new System.Windows.Forms.Button();
            this.createDocumentsBw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.queryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.queryBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.queryBox.AutoScrollMinSize = new System.Drawing.Size(144, 75);
            this.queryBox.BackBrush = null;
            this.queryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.queryBox.CharHeight = 15;
            this.queryBox.CharWidth = 7;
            this.queryBox.CurrentLineColor = System.Drawing.Color.PaleTurquoise;
            this.queryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.queryBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.queryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.queryBox.IsReplaceMode = false;
            this.queryBox.Language = FastColoredTextBoxNS.Language.JS;
            this.queryBox.LeftBracket = '(';
            this.queryBox.LeftBracket2 = '{';
            this.queryBox.Location = new System.Drawing.Point(0, 0);
            this.queryBox.Name = "queryBox";
            this.queryBox.Paddings = new System.Windows.Forms.Padding(0);
            this.queryBox.RightBracket = ')';
            this.queryBox.RightBracket2 = '}';
            this.queryBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.queryBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("queryBox.ServiceColors")));
            this.queryBox.ShowFoldingLines = true;
            this.queryBox.Size = new System.Drawing.Size(587, 344);
            this.queryBox.TabIndex = 2;
            this.queryBox.Text = "[\r\n    {\r\n        \"id\" : \"\"\r\n    }\r\n]";
            this.queryBox.Zoom = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.createBtn);
            this.splitContainer1.Size = new System.Drawing.Size(587, 402);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.Location = new System.Drawing.Point(389, 8);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(184, 31);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create Documents";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // createDocumentsBw
            // 
            this.createDocumentsBw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.createDocumentsBw_DoWork);
            this.createDocumentsBw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.createDocumentsBw_RunWorkerCompleted);
            // 
            // CreateDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 402);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "CreateDocuments";
            this.Text = "DocumentDB Manager - Create Documents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDocuments_FormClosing);
            this.Load += new System.EventHandler(this.CreateDocuments_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CreateDocuments_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.queryBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox queryBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button createBtn;
        private System.ComponentModel.BackgroundWorker createDocumentsBw;
    }
}