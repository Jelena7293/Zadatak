namespace ExcelImport
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDCell = new System.Windows.Forms.Label();
            this.lblDefCell = new System.Windows.Forms.Label();
            this.btnChangeRowColumn = new System.Windows.Forms.Button();
            this.lblRow = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelCat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(489, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.xlsx)|*.xlsx";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = " Brovse Text Files";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(84, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(399, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File location:";
            // 
            // lblDCell
            // 
            this.lblDCell.AutoSize = true;
            this.lblDCell.Location = new System.Drawing.Point(18, 46);
            this.lblDCell.Name = "lblDCell";
            this.lblDCell.Size = new System.Drawing.Size(109, 13);
            this.lblDCell.TabIndex = 3;
            this.lblDCell.Text = "Default Row/Column:";
            // 
            // lblDefCell
            // 
            this.lblDefCell.AutoSize = true;
            this.lblDefCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefCell.Location = new System.Drawing.Point(130, 44);
            this.lblDefCell.Margin = new System.Windows.Forms.Padding(0);
            this.lblDefCell.Name = "lblDefCell";
            this.lblDefCell.Size = new System.Drawing.Size(35, 15);
            this.lblDefCell.TabIndex = 4;
            this.lblDefCell.Text = "1 / A";
            // 
            // btnChangeRowColumn
            // 
            this.btnChangeRowColumn.Location = new System.Drawing.Point(177, 41);
            this.btnChangeRowColumn.Name = "btnChangeRowColumn";
            this.btnChangeRowColumn.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRowColumn.TabIndex = 1;
            this.btnChangeRowColumn.Text = "Change";
            this.btnChangeRowColumn.UseVisualStyleBackColor = true;
            this.btnChangeRowColumn.Click += new System.EventHandler(this.BtnChangeRowColumn_Click);
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Enabled = false;
            this.lblRow.Location = new System.Drawing.Point(18, 74);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(78, 13);
            this.lblRow.TabIndex = 6;
            this.lblRow.Text = "Enter the Row:";
            // 
            // txtRow
            // 
            this.txtRow.Enabled = false;
            this.txtRow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRow.Location = new System.Drawing.Point(133, 71);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(119, 20);
            this.txtRow.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(177, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Enabled = false;
            this.lblColumn.Location = new System.Drawing.Point(18, 105);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(91, 13);
            this.lblColumn.TabIndex = 9;
            this.lblColumn.Text = "Enter the Column:";
            // 
            // txtColumn
            // 
            this.txtColumn.Enabled = false;
            this.txtColumn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtColumn.Location = new System.Drawing.Point(133, 102);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(119, 20);
            this.txtColumn.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(489, 262);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSelCat);
            this.groupBox1.Location = new System.Drawing.Point(291, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 193);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Category";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(9, 15);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(265, 147);
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selected Category:";
            // 
            // txtSelCat
            // 
            this.txtSelCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSelCat.Location = new System.Drawing.Point(109, 164);
            this.txtSelCat.Name = "txtSelCat";
            this.txtSelCat.Size = new System.Drawing.Size(165, 20);
            this.txtSelCat.TabIndex = 12;
            this.txtSelCat.TextChanged += new System.EventHandler(this.TxtSelCat_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRow);
            this.groupBox2.Controls.Add(this.txtColumn);
            this.groupBox2.Controls.Add(this.lblDCell);
            this.groupBox2.Controls.Add(this.lblDefCell);
            this.groupBox2.Controls.Add(this.btnChangeRowColumn);
            this.groupBox2.Controls.Add(this.lblRow);
            this.groupBox2.Controls.Add(this.lblColumn);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Location = new System.Drawing.Point(15, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 193);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Default Row/Column";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 297);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Excel File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDCell;
        private System.Windows.Forms.Label lblDefCell;
        private System.Windows.Forms.Button btnChangeRowColumn;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtSelCat;
    }
}

