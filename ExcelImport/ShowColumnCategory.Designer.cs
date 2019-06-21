namespace ExcelImport
{
    partial class ShowColumnCategory
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
            this.groupParameter = new System.Windows.Forms.GroupBox();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.groupColumns = new System.Windows.Forms.GroupBox();
            this.listBoxColumn = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUniqueKey1 = new System.Windows.Forms.Label();
            this.lblUniqueKey2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUniqueKey = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupParameter.SuspendLayout();
            this.groupColumns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupParameter
            // 
            this.groupParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupParameter.Controls.Add(this.listBoxCategory);
            this.groupParameter.Location = new System.Drawing.Point(191, 12);
            this.groupParameter.Name = "groupParameter";
            this.groupParameter.Size = new System.Drawing.Size(173, 241);
            this.groupParameter.TabIndex = 1;
            this.groupParameter.TabStop = false;
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.Location = new System.Drawing.Point(6, 19);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(161, 212);
            this.listBoxCategory.Sorted = true;
            this.listBoxCategory.TabIndex = 0;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategory_SelectedIndexChanged);
            // 
            // groupColumns
            // 
            this.groupColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupColumns.Controls.Add(this.listBoxColumn);
            this.groupColumns.Location = new System.Drawing.Point(12, 12);
            this.groupColumns.Name = "groupColumns";
            this.groupColumns.Size = new System.Drawing.Size(173, 241);
            this.groupColumns.TabIndex = 0;
            this.groupColumns.TabStop = false;
            this.groupColumns.Text = "Columns";
            // 
            // listBoxColumn
            // 
            this.listBoxColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxColumn.FormattingEnabled = true;
            this.listBoxColumn.Location = new System.Drawing.Point(6, 19);
            this.listBoxColumn.Name = "listBoxColumn";
            this.listBoxColumn.Size = new System.Drawing.Size(161, 212);
            this.listBoxColumn.TabIndex = 0;
            this.listBoxColumn.SelectedIndexChanged += new System.EventHandler(this.ListBoxColumn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unique Key:";
            // 
            // lblUniqueKey1
            // 
            this.lblUniqueKey1.AutoSize = true;
            this.lblUniqueKey1.Location = new System.Drawing.Point(115, 50);
            this.lblUniqueKey1.Name = "lblUniqueKey1";
            this.lblUniqueKey1.Size = new System.Drawing.Size(67, 13);
            this.lblUniqueKey1.TabIndex = 3;
            this.lblUniqueKey1.Text = "Not selected";
            // 
            // lblUniqueKey2
            // 
            this.lblUniqueKey2.AutoSize = true;
            this.lblUniqueKey2.Location = new System.Drawing.Point(115, 72);
            this.lblUniqueKey2.Name = "lblUniqueKey2";
            this.lblUniqueKey2.Size = new System.Drawing.Size(69, 13);
            this.lblUniqueKey2.TabIndex = 4;
            this.lblUniqueKey2.Text = "Not Selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected Column:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selected Parameter:";
            // 
            // txtUniqueKey
            // 
            this.txtUniqueKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUniqueKey.Enabled = false;
            this.txtUniqueKey.Location = new System.Drawing.Point(6, 117);
            this.txtUniqueKey.Name = "txtUniqueKey";
            this.txtUniqueKey.Size = new System.Drawing.Size(245, 20);
            this.txtUniqueKey.TabIndex = 7;
            this.txtUniqueKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(562, 270);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUniqueKey1);
            this.groupBox1.Controls.Add(this.txtUniqueKey);
            this.groupBox1.Controls.Add(this.lblUniqueKey2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(380, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 239);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // ShowColumnCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupParameter);
            this.Controls.Add(this.groupColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ShowColumnCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Unique Key";
            this.Load += new System.EventHandler(this.ShowColumnCategory_Load);
            this.groupParameter.ResumeLayout(false);
            this.groupColumns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParameter;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.GroupBox groupColumns;
        private System.Windows.Forms.ListBox listBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUniqueKey1;
        private System.Windows.Forms.Label lblUniqueKey2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUniqueKey;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}