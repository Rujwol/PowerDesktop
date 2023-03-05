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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";

            // show dialog and check if user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name and path
                string fileName = openFileDialog.FileName;

                string[] fileNames = fileName.Split('\\');
                ChooseFile.Text = fileNames[fileNames.Length - 1];
                // check file extension and do conditional block
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

        private void Evaluate_Click(object sender, EventArgs e)
        {
            int maxSalary = 0;
            DataGridViewRow maxValRow = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int salary = int.Parse(row.Cells["Salary"].Value.ToString());
                if (salary > maxSalary)
                {
                    maxSalary = salary;
                    maxValRow = row;
                }


            }
            //MessageBox.Show("Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            MessageBox.Show("Maximum salary value:"+" "+maxValRow.Cells["Name"].Value.ToString() + " " + maxValRow.Cells["Address"].Value.ToString() + " " + maxValRow.Cells["Salary"].Value.ToString());
        }

        private void saveLoadedDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(this.menuStrip1);
            //this.Controls.Add(this.menuStrip2);
            panel1.Visible = false;
        }

        private void detailDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            //below different thing
            //this.Controls.Clear();
            //InitializeComponent();
            panel1.Visible = true;
        }
    }
}
