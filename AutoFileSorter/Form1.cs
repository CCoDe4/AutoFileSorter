using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFileSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            string path = selectPath.Text;

            using (var fbd = new FolderBrowserDialog())
            {
                //DialogResult result = fbd.ShowDialog();

                fbd.SelectedPath = path;

                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    ProcessFiles(files);


                    if (rbtnCopy.Checked)
                        MessageBox.Show("Files copied: " + files.Length.ToString(), "Message");
                    else
                        MessageBox.Show("Files moved: " + files.Length.ToString(), "Message");
                }
                else
                {
                    MessageBox.Show("Operation canceled");
                }
            }
        }

        private void ProcessFiles(string[] filePaths)
        {
            foreach (var filePath in filePaths)
            {
                //DateTime creationDate = File.GetCreationTime(filePath);
                DateTime creationDate = File.GetLastWriteTime(filePath);
                string targetDirectory = selectPath.Text + "\\" + creationDate.Month + "\\";

                if (!Directory.Exists(targetDirectory))
                {
                    DirectoryInfo di = Directory.CreateDirectory(targetDirectory);
                }

                targetDirectory += Path.GetFileName(filePath);

                if (rbtnCopy.Checked)
                    CopyFile(filePath, targetDirectory);
                else
                    MoveFile(filePath, targetDirectory);

            }
        }

        private void MoveFile(string filePath, string targetDirectory)
        {
            try
            {
                File.Move(filePath, targetDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CopyFile(string filePath, string targetDirectory)
        {
            try
            {
                File.Copy(filePath, targetDirectory);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

