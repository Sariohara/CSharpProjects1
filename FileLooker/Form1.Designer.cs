namespace FileLooker
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.lblChooseDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.DS = new System.DirectoryServices.DirectorySearcher();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstdata = new System.Windows.Forms.ListView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 83);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenFile.Location = new System.Drawing.Point(0, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(91, 83);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // mnuStrip
            // 
            this.mnuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.Size = new System.Drawing.Size(959, 28);
            this.mnuStrip.TabIndex = 1;
            this.mnuStrip.Text = "menuStrip1";
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // lblChooseDirectory
            // 
            this.lblChooseDirectory.AutoSize = true;
            this.lblChooseDirectory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChooseDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDirectory.Location = new System.Drawing.Point(383, 111);
            this.lblChooseDirectory.Name = "lblChooseDirectory";
            this.lblChooseDirectory.Size = new System.Drawing.Size(68, 20);
            this.lblChooseDirectory.TabIndex = 4;
            this.lblChooseDirectory.Text = "Search";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDirectory.Location = new System.Drawing.Point(0, 111);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(383, 22);
            this.txtDirectory.TabIndex = 2;
            // 
            // DS
            // 
            this.DS.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.DS.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.DS.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ImgList
            // 
            this.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(91, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 83);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lstdata
            // 
            this.lstdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstdata.HideSelection = false;
            this.lstdata.Location = new System.Drawing.Point(383, 131);
            this.lstdata.Name = "lstdata";
            this.lstdata.Size = new System.Drawing.Size(576, 415);
            this.lstdata.TabIndex = 5;
            this.lstdata.UseCompatibleStateImageBehavior = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(166, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 83);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 546);
            this.Controls.Add(this.lstdata);
            this.Controls.Add(this.lblChooseDirectory);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuStrip);
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label lblChooseDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.DirectoryServices.DirectorySearcher DS;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView lstdata;
    }
}

