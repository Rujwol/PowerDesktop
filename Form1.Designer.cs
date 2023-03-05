
namespace PowerDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Choose_Click = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChooseFile = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Evaluate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.detailDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Choose_Click
            // 
            this.Choose_Click.Location = new System.Drawing.Point(227, 49);
            this.Choose_Click.Name = "Choose_Click";
            this.Choose_Click.Size = new System.Drawing.Size(57, 27);
            this.Choose_Click.TabIndex = 0;
            this.Choose_Click.Text = "Click";
            this.Choose_Click.UseVisualStyleBackColor = true;
            this.Choose_Click.Click += new System.EventHandler(this.Choose_Click_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.Salary});
            this.dataGridView1.Location = new System.Drawing.Point(96, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(426, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.Width = 125;
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(96, 49);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.ReadOnly = true;
            this.ChooseFile.Size = new System.Drawing.Size(125, 27);
            this.ChooseFile.TabIndex = 2;
            this.ChooseFile.Text = "Choose File";
            // 
            // Evaluate
            // 
            this.Evaluate.Location = new System.Drawing.Point(227, 288);
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(146, 29);
            this.Evaluate.TabIndex = 3;
            this.Evaluate.Text = "Evaluate";
            this.Evaluate.UseVisualStyleBackColor = true;
            this.Evaluate.Click += new System.EventHandler(this.Evaluate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailDataToolStripMenuItem,
            this.saveLoadedDataToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // detailDataToolStripMenuItem
            // 
            this.detailDataToolStripMenuItem.Name = "detailDataToolStripMenuItem";
            this.detailDataToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.detailDataToolStripMenuItem.Text = "Detail data";
            this.detailDataToolStripMenuItem.Click += new System.EventHandler(this.detailDataToolStripMenuItem_Click);
            // 
            // saveLoadedDataToolStripMenuItem
            // 
            this.saveLoadedDataToolStripMenuItem.Name = "saveLoadedDataToolStripMenuItem";
            this.saveLoadedDataToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.saveLoadedDataToolStripMenuItem.Text = "Save loaded data";
            this.saveLoadedDataToolStripMenuItem.Click += new System.EventHandler(this.saveLoadedDataToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Evaluate);
            this.panel1.Controls.Add(this.ChooseFile);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Choose_Click);
            this.panel1.Location = new System.Drawing.Point(75, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 327);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choose_Click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TextBox ChooseFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Evaluate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem detailDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoadedDataToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

