using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PowerDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Choose_Click_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";

            // show dialog and check if user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name and path
                string fileName = openFileDialog.FileName;

                // check file extension and do conditional coding
                if (Path.GetExtension(fileName) == ".csv")
                {
                    // handle CSV file
                    string[] fileContents = File.ReadAllLines(fileName);

                    bool isFirstIteration = true;
                    foreach (string line in fileContents)
                    {
                        if (isFirstIteration)
                        {
                            isFirstIteration = false;
                            continue;
                        }
                        else
                        {
                            string[] values = line.Split(',');
                            dataGridView1.Rows.Add(values);
                        }

                    }

                }
                else if (Path.GetExtension(fileName) == ".xml")
                {
                    // handle XML file
                }
                else
                {
                    // handle other file types
                }
            }
        }
    }
}
