using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace format_filename
{
    public partial class Form1 : Form
    {
        string[]? files;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBox_files.Items.Clear();
            progressBar1.Visible = true;

            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Stelle sicher, dass der Dialog nach dem ÷ffnen eines Ordners schlieﬂt.
                folderBrowserDialog.ShowNewFolderButton = false;

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Ausgew‰hlten Ordnerpfad anzeigen
                    txt_folderPath.Text = folderBrowserDialog.SelectedPath;

                    // Dateien im Ordner auflisten
                    files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    progressBar1.Maximum = files.Length;
                    for (int i = 0; i <= files.Length - 1; i++)
                    {
                        progressBar1.Value = i;
                        string[] fileSplit = files[i].Split('\\');
                        lstBox_files.Items.Add(fileSplit[fileSplit.Length - 1]);
                    }


                }
            }
            progressBar1.Visible = false;
        }

        private void changeFileNames(string[] files, string text, bool entfernen, string newDivider, string oldDivider, bool changeDivider)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = files.Length;

            for (int j = 0; j <= files.Length - 1; j++)
            {
                progressBar1.Value = j;

                string filePath = files[j];

                //string directory = Path.GetDirectoryName(filePath);

                string fileName = Path.GetFileName(filePath);

                string[] fileNameSplit = fileName.Split(oldDivider);

                string newFileName = "";

                if (entfernen)
                {
                    if (fileNameSplit.Length > 1)
                    {
                        List<string> list = new List<string>(fileNameSplit);


                        for (int i = 0; i < fileNameSplit.Length - 1; i++)
                        {
                            if (fileNameSplit[i].Equals(text))
                            {
                                list.Remove(fileNameSplit[i]);
                            }
                        }

                        fileNameSplit = list.ToArray();


                        for (int i = 0; i <= fileNameSplit.Length - 1; i++)
                        {
                            if (i == fileNameSplit.Length - 1)
                            {
                                newFileName += fileNameSplit[i];
                            }
                            else
                            {
                                if (changeDivider)
                                {
                                    newFileName += fileNameSplit[i] + newDivider;
                                }
                                else
                                {
                                    newFileName += fileNameSplit[i] + oldDivider;
                                }

                            }

                        }
                    }
                    else
                    {
                        newFileName = fileName;
                    }

                    newFileName = Path.GetDirectoryName(filePath) + "/" + newFileName;
                }
                else
                {

                }

                // Dateinamen ‰ndern
                //string newFileName = Path.Combine(Path.GetDirectoryName(filePath), "NeuerName_" + Path.GetFileName(filePath));
                File.Move(filePath, newFileName);
            }

            progressBar1.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (files != null && txt_txt.Text != "" && txt_old_div.Text != "")
            {
                if (checkBox1.Checked && txt_newDivider.Text != "")
                {
                    changeFileNames(files, txt_txt.Text, radioButton2.Checked, txt_newDivider.Text, txt_old_div.Text, checkBox1.Checked);
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstBox_files.SelectedIndex >= 0)
            {
                try
                {
                    Process.Start(files[lstBox_files.SelectedIndex]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fehler beim ÷ffnen der Datei" + files[lstBox_files.SelectedIndex], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstBox_files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            txt_newDivider.Enabled = checkBox1.Checked;
        }
    }
}