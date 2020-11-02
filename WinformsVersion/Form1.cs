using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WordLibrary;

namespace WinformsVersion
{
    public partial class Form1 : Form
    {
        private double accurateTranslations;


        private double attemptedTranslations;
        private DataTable dt;
        private DataTable dtAdd;
        private Word word;
        private WordList wordListObject;

        public Form1()
        {
            InitializeComponent();
            var wordLists = WordList.GetLists();
            listBoxFiles.Items.AddRange(wordLists);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WordList.CreateFolder();
            panel1.Visible = Visible;
            panel2.Visible = !Visible;
            panel3.Visible = !Visible;
            panel4.Visible = !Visible;
            panel5.Visible = !Visible;

            if (wordListObject == null)
            {
                exitToolStripMenuItem.Enabled = false;
                practiceModeToolStripMenuItem.Enabled = false;
                button3.Enabled = false;
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = !Visible;
            panel2.Visible = Visible;
        }

        private void listBoxFilesItemSelected(object sender, EventArgs e)
        {
            var listBox = (ListBox) sender;
            var listBoxSelected = listBox.SelectedItem;
            exitToolStripMenuItem.Enabled = true;
            practiceModeToolStripMenuItem.Enabled = true;
            button3.Enabled = true;

            if (listBoxSelected == null) return;

            wordListObject = WordList.LoadList(listBoxSelected.ToString());
            updateDataList();
        }


        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void tableWordList_Paint(object sender, PaintEventArgs e)
        {
            Location = panel2.Location;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void wordListCount_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void addWord_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = !Visible;
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            var newObjectName = textBox1.Text;
            if (newObjectName == "")
            {
                MessageBox.Show("A new list must have a name.");
                return;
            }

            var newObjectLang = RichTextBoxInputLanguages.Text.Split(' ');
            if (newObjectLang.Length <= 1)
            {
                MessageBox.Show("A new list must have more than one language.");
                return;
            }

            var newListObject = new WordList(newObjectName, newObjectLang);
            newListObject.Save();
            listBoxFiles.Items.Add(newListObject.Name);
            panel1.Visible = true;
            panel3.Visible = false;
        }

        private void RichTextBoxInputLanguages_TextChanged(object sender, EventArgs e)
        {
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Location = panel2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = !Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void setActiveWordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordListObject != null) updateDataList();

            panel1.Visible = true;
            panel2.Visible = !Visible;
            panel3.Visible = !Visible;
            panel4.Visible = !Visible;
            panel5.Visible = !Visible;
        }

        private void cancelNewWord_Click(object sender, EventArgs e)
        {
            panel4.Visible = !panel4.Visible;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void removeWord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("A row must be selected.");
                return;
            }

            var text = dataGridView1.SelectedCells[0].Value.ToString();
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRowIndex);
            wordListObject.Remove(0, text);
            wordListObject.Save();
        }

        private void addNewWords_Click(object sender, EventArgs e)
        {
            var list = new List<string>();

            foreach (DataRow row in dtAdd.Rows)
                if (row.IsNull(1))
                {
                    MessageBox.Show("You must add a word to the languages listed.");
                    return;
                }
                else
                {
                    list.Add(row[1].ToString());
                }

            wordListObject.Add(list.ToArray());
            wordListObject.Save();
            updateDataList();
            panel4.Visible = !panel4.Visible;
            panel1.Visible = Visible;
        }

        private void practice_Click(object sender, EventArgs e)
        {
            panel2.Visible = !Visible;
            panel5.Visible = Visible;
            practiceReset();
            practiceUpdate();
        }

        private void translationLabel_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            var wordTranslation = textBox2.Text;

            if (e.KeyCode == Keys.Enter)
            {
                if (wordTranslation == word.Translations[word.ToLanguage])
                {
                    accurateTranslations++;
                    textBox2.Clear();
                }

                else
                {
                    MessageBox.Show("Incorrect translation!");
                }

                attemptedTranslations++;
                practiceUpdate();
            }

            countCorrectLabel.Text = $"{accurateTranslations} of {attemptedTranslations} are correct.";
        }

        private void restartBTN_Click(object sender, EventArgs e)
        {
            practiceUpdate();
            practiceReset();
        }

        private void endPracticeBTN_Click(object sender, EventArgs e)
        {
            practiceReset();
            panel5.Visible = !Visible;
            panel2.Visible = Visible;
            panel1.Visible = !Visible;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = Visible;
            panel5.Visible = !Visible;
            panel1.Visible = !Visible;
            panel4.Visible = !Visible;
            panel3.Visible = !Visible;
        }

        private void practiceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            practiceUpdate();
            practiceReset();
            panel2.Visible = !Visible;
            panel3.Visible = !Visible;
            panel5.Visible = Visible;
            panel1.Visible = !Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = panel2.Location;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.Location = panel2.Location;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Location = panel2.Location;
        }

        private void updateDataList()
        {
            var languages = wordListObject.Languages;
            listBoxLanguages.Items.Clear();
            listBoxLanguages.Items.AddRange(languages);
            var counter = wordListObject.Count();
            wordListCount.Text = $"Word count: {counter}";

            dt = new DataTable();
            dtAdd = new DataTable();

            dt.Rows.Clear();
            dtAdd.Rows.Clear();
            dtAdd.Columns.Add();
            dtAdd.Columns.Add();
            var numberOfLanguages = 0;

            for (var i = 0; i < languages.Length; i++)
            {
                dt.Columns.Add(languages[i]);
                dtAdd.Rows.Add(languages[i]);
                numberOfLanguages = i;
            }

            Action<string[]> listWords = word => { dt.Rows.Add(word); };
            wordListObject.List(numberOfLanguages, listWords);
            dataGridView2.DataSource = dtAdd;
            dataGridView1.DataSource = dt;
        }

        private void practiceUpdate()
        {
            word = wordListObject.GetWordToPractice();
            translationLabel.Text = $"Translate the {wordListObject.Languages[word.FromLanguage]}" +
                                    $" word '{word.Translations[word.FromLanguage]}' to {wordListObject.Languages[word.ToLanguage]}";
        }

        private void practiceReset()
        {
            attemptedTranslations = 0.0;
            accurateTranslations = 0.0;
            countCorrectLabel.Text = $"{accurateTranslations} of {attemptedTranslations} are correct.";
        }
    }
}