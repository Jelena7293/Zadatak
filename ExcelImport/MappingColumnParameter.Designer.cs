namespace ExcelImport
{
    partial class MappingColumnParameter
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
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.groupColumns = new System.Windows.Forms.GroupBox();
            this.listBoxCol = new System.Windows.Forms.ListBox();
            this.txtUniqueKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMapping = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.groupParameter.SuspendLayout();
            this.groupColumns.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupParameter
            // 
            this.groupParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupParameter.Controls.Add(this.listBoxCat);
            this.groupParameter.Location = new System.Drawing.Point(191, 47);
            this.groupParameter.Name = "groupParameter";
            this.groupParameter.Size = new System.Drawing.Size(173, 241);
            this.groupParameter.TabIndex = 3;
            this.groupParameter.TabStop = false;
            // 
            // listBoxCat
            // 
            this.listBoxCat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(6, 19);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(161, 212);
            this.listBoxCat.Sorted = true;
            this.listBoxCat.TabIndex = 0;
            this.listBoxCat.SelectedIndexChanged += new System.EventHandler(this.ListBoxCat_SelectedIndexChanged);
            // 
            // groupColumns
            // 
            this.groupColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupColumns.Controls.Add(this.listBoxCol);
            this.groupColumns.Location = new System.Drawing.Point(12, 47);
            this.groupColumns.Name = "groupColumns";
            this.groupColumns.Size = new System.Drawing.Size(173, 241);
            this.groupColumns.TabIndex = 2;
            this.groupColumns.TabStop = false;
            this.groupColumns.Text = "Columns";
            // 
            // listBoxCol
            // 
            this.listBoxCol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCol.FormattingEnabled = true;
            this.listBoxCol.Location = new System.Drawing.Point(6, 19);
            this.listBoxCol.Name = "listBoxCol";
            this.listBoxCol.Size = new System.Drawing.Size(161, 212);
            this.listBoxCol.Sorted = true;
            this.listBoxCol.TabIndex = 0;
            this.listBoxCol.SelectedIndexChanged += new System.EventHandler(this.ListBoxCol_SelectedIndexChanged);
            // 
            // txtUniqueKey
            // 
            this.txtUniqueKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUniqueKey.Enabled = false;
            this.txtUniqueKey.Location = new System.Drawing.Point(422, 12);
            this.txtUniqueKey.Name = "txtUniqueKey";
            this.txtUniqueKey.Size = new System.Drawing.Size(215, 20);
            this.txtUniqueKey.TabIndex = 9;
            this.txtUniqueKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Unique Key:";
            // 
            // listBoxMapping
            // 
            this.listBoxMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMapping.FormattingEnabled = true;
            this.listBoxMapping.HorizontalScrollbar = true;
            this.listBoxMapping.Location = new System.Drawing.Point(6, 19);
            this.listBoxMapping.Name = "listBoxMapping";
            this.listBoxMapping.Size = new System.Drawing.Size(203, 212);
            this.listBoxMapping.TabIndex = 10;
            this.listBoxMapping.SelectedIndexChanged += new System.EventHandler(this.ListBoxMapping_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(370, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(370, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(46, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listBoxMapping);
            this.groupBox1.Location = new System.Drawing.Point(422, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 241);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapping Column Parameter";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(562, 300);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // MappingColumnParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 335);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtUniqueKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupParameter);
            this.Controls.Add(this.groupColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MappingColumnParameter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapping Column Parameter";
            this.Load += new System.EventHandler(this.MapingColumnParameter_Load);
            this.groupParameter.ResumeLayout(false);
            this.groupColumns.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupParameter;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.GroupBox groupColumns;
        private System.Windows.Forms.ListBox listBoxCol;
        private System.Windows.Forms.TextBox txtUniqueKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMapping;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinish;
    }
}