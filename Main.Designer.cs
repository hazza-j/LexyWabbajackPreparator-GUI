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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Begin = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Credit2 = new System.Windows.Forms.Label();
            this.Credit1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.CheckedListBox();
            this.Warning = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WarningDesc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Title2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Subtitle2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Steam Installation Folder";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(315, 291);
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
            this.Title.Location = new System.Drawing.Point(19, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(748, 45);
            this.Title.TabIndex = 1;
            this.Title.Text = "Welcome to The Lexy Wabbajack Preparator";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Credit2
            // 
            this.Credit2.AutoSize = true;
            this.Credit2.Location = new System.Drawing.Point(354, 85);
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
            this.Credit1.Location = new System.Drawing.Point(312, 61);
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
            this.list.Location = new System.Drawing.Point(252, 101);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(270, 94);
            this.list.TabIndex = 4;
            this.list.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.Location = new System.Drawing.Point(348, 203);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(67, 13);
            this.Warning.TabIndex = 7;
            this.Warning.Text = "WARNING";
            this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // WarningDesc
            // 
            this.WarningDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarningDesc.AutoSize = true;
            this.WarningDesc.Location = new System.Drawing.Point(249, 223);
            this.WarningDesc.Name = "WarningDesc";
            this.WarningDesc.Size = new System.Drawing.Size(277, 65);
            this.WarningDesc.TabIndex = 9;
            this.WarningDesc.Text = resources.GetString("WarningDesc.Text");
            this.WarningDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WarningDesc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Warning);
            this.panel1.Controls.Add(this.list);
            this.panel1.Controls.Add(this.Credit1);
            this.panel1.Controls.Add(this.Credit2);
            this.panel1.Controls.Add(this.Begin);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 363);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Subtitle2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Title2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(6, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 363);
            this.panel2.TabIndex = 12;
            this.panel2.Visible = false;
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.HelpRequest += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Your \"Lexy LOTD\" Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Title2
            // 
            this.Title2.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.Location = new System.Drawing.Point(31, 16);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(748, 45);
            this.Title2.TabIndex = 2;
            this.Title2.Text = "Preparator Stage II";
            this.Title2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(281, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 120);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "Copy Game Folder Files";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Set Resolution";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SkyrimPrefs.ini";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 628);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(740, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Welcome to The Lexy Wabbajack Preparator!",
            "Click Begin to get started, or press skip if you\'ve already used Wabbajack and ar" +
                "e ready to",
            "complete next steps."});
            this.listBox1.Location = new System.Drawing.Point(144, 374);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(512, 238);
            this.listBox1.TabIndex = 14;
            this.listBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(226, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 19);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "No Directory Selected!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.numericUpDown3);
            this.panel5.Controls.Add(this.numericUpDown2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(121, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 105);
            this.panel5.TabIndex = 4;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(29, 29);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 17;
            this.Next.Text = "Skip";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.Next);
            this.panel6.Location = new System.Drawing.Point(334, 628);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(132, 59);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(132, 59);
            this.panel7.TabIndex = 20;
            this.panel7.Visible = false;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // Subtitle2
            // 
            this.Subtitle2.AutoSize = true;
            this.Subtitle2.Location = new System.Drawing.Point(199, 85);
            this.Subtitle2.Name = "Subtitle2";
            this.Subtitle2.Size = new System.Drawing.Size(391, 13);
            this.Subtitle2.TabIndex = 6;
            this.Subtitle2.Text = "Here you quickly do some of the post Wabbajack steps! Exit once you\'ve finished";
            this.Subtitle2.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(39, 21);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(39, 47);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "W:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "H:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Credit2;
        private System.Windows.Forms.Label Credit1;
        private System.Windows.Forms.CheckedListBox list;
        private System.Windows.Forms.Label Warning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WarningDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Subtitle2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

