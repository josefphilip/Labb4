namespace WinformsVersion
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
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wordListCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addWord = new System.Windows.Forms.Button();
            this.removeWord = new System.Windows.Forms.Button();
            this.practice = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.endPracticeBTN = new System.Windows.Forms.Button();
            this.restartBTN = new System.Windows.Forms.Button();
            this.countCorrectLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RichTextBoxInputLanguages = new System.Windows.Forms.RichTextBox();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.okBTN = new System.Windows.Forms.Button();
            this.LanguagesLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addNewWords = new System.Windows.Forms.Button();
            this.cancelNewWord = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setActiveWordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(72, 64);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(146, 160);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFilesItemSelected);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.Location = new System.Drawing.Point(247, 64);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(146, 160);
            this.listBoxLanguages.TabIndex = 1;
            this.listBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguages_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.wordListCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Word);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBoxFiles);
            this.panel1.Controls.Add(this.listBoxLanguages);
            this.panel1.Location = new System.Drawing.Point(530, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 300);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // wordListCount
            // 
            this.wordListCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordListCount.AutoSize = true;
            this.wordListCount.Location = new System.Drawing.Point(162, 29);
            this.wordListCount.Name = "wordListCount";
            this.wordListCount.Size = new System.Drawing.Size(67, 13);
            this.wordListCount.TabIndex = 7;
            this.wordListCount.Text = "Word Count:";
            this.wordListCount.Click += new System.EventHandler(this.wordListCount_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Languages:";
            // 
            // Word
            // 
            this.Word.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Word.AutoSize = true;
            this.Word.Location = new System.Drawing.Point(69, 29);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(56, 13);
            this.Word.TabIndex = 5;
            this.Word.Text = "Word lists:";
            this.Word.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(381, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(300, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "New list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.addWord);
            this.panel2.Controls.Add(this.removeWord);
            this.panel2.Controls.Add(this.practice);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 435);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(224, 399);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(67, 23);
            this.addWord.TabIndex = 3;
            this.addWord.Text = "Add word";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // removeWord
            // 
            this.removeWord.Location = new System.Drawing.Point(297, 399);
            this.removeWord.Name = "removeWord";
            this.removeWord.Size = new System.Drawing.Size(101, 23);
            this.removeWord.TabIndex = 2;
            this.removeWord.Text = "Remove word";
            this.removeWord.UseVisualStyleBackColor = true;
            this.removeWord.Click += new System.EventHandler(this.removeWord_Click);
            // 
            // practice
            // 
            this.practice.Location = new System.Drawing.Point(404, 399);
            this.practice.Name = "practice";
            this.practice.Size = new System.Drawing.Size(75, 23);
            this.practice.TabIndex = 1;
            this.practice.Text = "Practice";
            this.practice.UseVisualStyleBackColor = true;
            this.practice.Click += new System.EventHandler(this.practice_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(445, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.endPracticeBTN);
            this.panel5.Controls.Add(this.restartBTN);
            this.panel5.Controls.Add(this.countCorrectLabel);
            this.panel5.Controls.Add(this.translationLabel);
            this.panel5.Location = new System.Drawing.Point(533, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(419, 183);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // endPracticeBTN
            // 
            this.endPracticeBTN.Location = new System.Drawing.Point(195, 131);
            this.endPracticeBTN.Name = "endPracticeBTN";
            this.endPracticeBTN.Size = new System.Drawing.Size(96, 23);
            this.endPracticeBTN.TabIndex = 4;
            this.endPracticeBTN.Text = "END PRACTICE";
            this.endPracticeBTN.UseVisualStyleBackColor = true;
            this.endPracticeBTN.Click += new System.EventHandler(this.endPracticeBTN_Click);
            // 
            // restartBTN
            // 
            this.restartBTN.Location = new System.Drawing.Point(96, 131);
            this.restartBTN.Name = "restartBTN";
            this.restartBTN.Size = new System.Drawing.Size(93, 23);
            this.restartBTN.TabIndex = 3;
            this.restartBTN.Text = "RESTART";
            this.restartBTN.UseVisualStyleBackColor = true;
            this.restartBTN.Click += new System.EventHandler(this.restartBTN_Click);
            // 
            // countCorrectLabel
            // 
            this.countCorrectLabel.AutoSize = true;
            this.countCorrectLabel.Location = new System.Drawing.Point(145, 103);
            this.countCorrectLabel.Name = "countCorrectLabel";
            this.countCorrectLabel.Size = new System.Drawing.Size(103, 13);
            this.countCorrectLabel.TabIndex = 2;
            this.countCorrectLabel.Text = "AmountCorrectLabel";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Location = new System.Drawing.Point(107, 23);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(85, 13);
            this.translationLabel.TabIndex = 0;
            this.translationLabel.Text = "TranslationLabel";
            this.translationLabel.Click += new System.EventHandler(this.translationLabel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.RichTextBoxInputLanguages);
            this.panel3.Controls.Add(this.cancelBTN);
            this.panel3.Controls.Add(this.okBTN);
            this.panel3.Controls.Add(this.LanguagesLabel);
            this.panel3.Controls.Add(this.titleLabel);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(284, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 248);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // RichTextBoxInputLanguages
            // 
            this.RichTextBoxInputLanguages.Location = new System.Drawing.Point(22, 98);
            this.RichTextBoxInputLanguages.Name = "RichTextBoxInputLanguages";
            this.RichTextBoxInputLanguages.Size = new System.Drawing.Size(152, 108);
            this.RichTextBoxInputLanguages.TabIndex = 6;
            this.RichTextBoxInputLanguages.Text = "English Swedish";
            this.RichTextBoxInputLanguages.TextChanged += new System.EventHandler(this.RichTextBoxInputLanguages_TextChanged);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(22, 212);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 5;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(99, 212);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 4;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // LanguagesLabel
            // 
            this.LanguagesLabel.AutoSize = true;
            this.LanguagesLabel.Location = new System.Drawing.Point(22, 82);
            this.LanguagesLabel.Name = "LanguagesLabel";
            this.LanguagesLabel.Size = new System.Drawing.Size(63, 13);
            this.LanguagesLabel.TabIndex = 3;
            this.LanguagesLabel.Text = "Languages:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(22, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.addNewWords);
            this.panel4.Controls.Add(this.cancelNewWord);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(69, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 224);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // addNewWords
            // 
            this.addNewWords.Location = new System.Drawing.Point(113, 186);
            this.addNewWords.Name = "addNewWords";
            this.addNewWords.Size = new System.Drawing.Size(75, 23);
            this.addNewWords.TabIndex = 2;
            this.addNewWords.Text = "Add";
            this.addNewWords.UseVisualStyleBackColor = true;
            this.addNewWords.Click += new System.EventHandler(this.addNewWords_Click);
            // 
            // cancelNewWord
            // 
            this.cancelNewWord.Location = new System.Drawing.Point(32, 186);
            this.cancelNewWord.Name = "cancelNewWord";
            this.cancelNewWord.Size = new System.Drawing.Size(75, 23);
            this.cancelNewWord.TabIndex = 1;
            this.cancelNewWord.Text = "Cancel";
            this.cancelNewWord.UseVisualStyleBackColor = true;
            this.cancelNewWord.Click += new System.EventHandler(this.cancelNewWord_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(203, 176);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setAsActiveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setActiveWordListToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setActiveWordListToolStripMenuItem
            // 
            this.setActiveWordListToolStripMenuItem.Name = "setActiveWordListToolStripMenuItem";
            this.setActiveWordListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setActiveWordListToolStripMenuItem.Text = "Set active word list";
            this.setActiveWordListToolStripMenuItem.Click += new System.EventHandler(this.setActiveWordListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // setAsActiveToolStripMenuItem
            // 
            this.setAsActiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.practiceModeToolStripMenuItem});
            this.setAsActiveToolStripMenuItem.Name = "setAsActiveToolStripMenuItem";
            this.setAsActiveToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.setAsActiveToolStripMenuItem.Text = "View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "Edit mode";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // practiceModeToolStripMenuItem
            // 
            this.practiceModeToolStripMenuItem.Name = "practiceModeToolStripMenuItem";
            this.practiceModeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.practiceModeToolStripMenuItem.Text = "Practice mode";
            this.practiceModeToolStripMenuItem.Click += new System.EventHandler(this.practiceModeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 492);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Winforms Version";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label wordListCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setActiveWordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setAsActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceModeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.Button removeWord;
        private System.Windows.Forms.Button practice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Label LanguagesLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox RichTextBoxInputLanguages;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addNewWords;
        private System.Windows.Forms.Button cancelNewWord;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button endPracticeBTN;
        private System.Windows.Forms.Button restartBTN;
        private System.Windows.Forms.Label countCorrectLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.TextBox textBox2;
    }
}

