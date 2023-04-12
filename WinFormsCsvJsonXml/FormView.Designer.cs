namespace CsvJsonToXml
{
    partial class FormView
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
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            panel1 = new Panel();
            tbPath = new TextBox();
            btnPath = new Button();
            panel3 = new Panel();
            btnToXML = new Button();
            btnShowCSV = new Button();
            panel2 = new Panel();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(742, 300);
            tabPage1.TabIndex = 0;
            tabPage1.Text = ".csv file display";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(733, 288);
            dataGridView1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 88);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(750, 328);
            tabControl1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbPath);
            panel1.Controls.Add(btnPath);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 70);
            panel1.TabIndex = 7;
            // 
            // tbPath
            // 
            tbPath.Location = new Point(18, 23);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(248, 23);
            tbPath.TabIndex = 3;
            // 
            // btnPath
            // 
            btnPath.BackColor = Color.Silver;
            btnPath.Location = new Point(265, 22);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(68, 25);
            btnPath.TabIndex = 8;
            btnPath.Text = ". . .";
            btnPath.UseVisualStyleBackColor = false;
            btnPath.Click += btnPath_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.BurlyWood;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnToXML);
            panel3.Controls.Add(btnShowCSV);
            panel3.Location = new Point(419, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 53);
            panel3.TabIndex = 9;
            // 
            // btnToXML
            // 
            btnToXML.BackColor = Color.Silver;
            btnToXML.Location = new Point(173, 14);
            btnToXML.Name = "btnToXML";
            btnToXML.Size = new Size(114, 23);
            btnToXML.TabIndex = 8;
            btnToXML.Text = "Save selected rows";
            btnToXML.UseVisualStyleBackColor = false;
            btnToXML.Click += btnToXML_Click;
            // 
            // btnShowCSV
            // 
            btnShowCSV.BackColor = Color.Silver;
            btnShowCSV.Location = new Point(15, 14);
            btnShowCSV.Name = "btnShowCSV";
            btnShowCSV.Size = new Size(114, 23);
            btnShowCSV.TabIndex = 8;
            btnShowCSV.Text = "Show file";
            btnShowCSV.UseVisualStyleBackColor = false;
            btnShowCSV.Click += btnShowCSV_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Linen;
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 428);
            panel2.TabIndex = 8;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(774, 428);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParserJsonCsvToXml";
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private Panel panel1;
        private Button btnShowCSV;
        private Button btnToXML;
        private Button btnPath;
        private Panel panel2;
        private TextBox tbPath;
        private Panel panel3;
    }
}