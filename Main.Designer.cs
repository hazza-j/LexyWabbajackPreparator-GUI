namespace Preparator_GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Begin = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Credit2 = new System.Windows.Forms.Label();
            this.Credit1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Warning = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarningDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(322, 302);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(146, 66);
            this.Begin.TabIndex = 0;
            this.Begin.Text = "Begin";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(26, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(748, 45);
            this.Title.TabIndex = 1;
            this.Title.Text = "Welcome to The Lexy Wabbajack Preparator";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Credit2
            // 
            this.Credit2.AutoSize = true;
            this.Credit2.Location = new System.Drawing.Point(361, 90);
            this.Credit2.Name = "Credit2";
            this.Credit2.Size = new System.Drawing.Size(78, 13);
            this.Credit2.TabIndex = 2;
            this.Credit2.Text = "GUI by Hazza-j";
            this.Credit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Credit2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Credit1
            // 
            this.Credit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Credit1.AutoSize = true;
            this.Credit1.Location = new System.Drawing.Point(319, 66);
            this.Credit1.Name = "Credit1";
            this.Credit1.Size = new System.Drawing.Size(163, 13);
            this.Credit1.TabIndex = 3;
            this.Credit1.Text = "Preparator Created By trawzifieds";
            this.Credit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Credit1.Click += new System.EventHandler(this.label3_Click);
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Reinstall Skyrim Special Edition?",
            "Remove Skyrim Special Edition Mods Folder?",
            "Remove Skyrim Config Folder?",
            "Remove LOOT AppData Folder?",
            "Remove Skyrim Special Edition AppData Folder?",
            "Remove zEdit Appdata Folder?"});
            this.list.Location = new System.Drawing.Point(259, 118);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(270, 94);
            this.list.TabIndex = 4;
            this.list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Steam Installation Folder";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 657);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(740, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Welcome to The Lexy Wabbajack Preparator!"});
            this.listBox1.Location = new System.Drawing.Point(131, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(512, 277);
            this.listBox1.TabIndex = 6;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.Location = new System.Drawing.Point(355, 215);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(67, 13);
            this.Warning.TabIndex = 7;
            this.Warning.Text = "WARNING";
            this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // WarningDesc
            // 
            this.WarningDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarningDesc.AutoSize = true;
            this.WarningDesc.Location = new System.Drawing.Point(256, 231);
            this.WarningDesc.Name = "WarningDesc";
            this.WarningDesc.Size = new System.Drawing.Size(277, 65);
            this.WarningDesc.TabIndex = 9;
            this.WarningDesc.Text = resources.GetString("WarningDesc.Text");
            this.WarningDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.WarningDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.Credit1);
            this.Controls.Add(this.Credit2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Begin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Credit2;
        private System.Windows.Forms.Label Credit1;
        private System.Windows.Forms.CheckedListBox list;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WarningDesc;

    }
}

