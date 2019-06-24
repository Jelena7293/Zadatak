using Autodesk.Revit.UI;
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
using ClosedXML.Excel;
using Autodesk.Revit.DB;

namespace ExcelImport
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public static string fileName = "C:\\Users\\Walter HP ProBook\\Downloads\\800102 Property values.xlsx";
        public static string selectedCategory = "";
        public Document document;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Document doc)
        {
            InitializeComponent();
            document = doc;
        }

        public void BtnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFileName.Text = openFileDialog1.FileName;
            fileName = txtFileName.Text;
        }

        private void BtnChangeRowColumn_Click(object sender, EventArgs e)
        {
            lblRow.Enabled = true;
            txtRow.Enabled = true;
            lblColumn.Enabled = true;
            txtColumn.Enabled = true;
            //btnColumn.Enabled = true;
            
            if (txtRow.Text != " ")
            {
                btnOk.Enabled = true;
            }

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtRow.Text == "")
            {
                TaskDialog.Show("Warning!", "Enter the row and column!");
            }
            else
            {
                lblDefCell.Text = txtRow.Text + " / " + txtColumn.Text[0];
                lblRow.Enabled = false;
                //txtRow.Text = "";
                txtRow.Enabled = false;
                lblColumn.Enabled = false;
                //txtColumn.Text = "";
                txtColumn.Enabled = false;
                btnOk.Enabled = false;
                //btnColumn.Enabled = false;
                int row = int.Parse(txtRow.Text);
                string columnRow = txtColumn.Text + row; 
            }
          

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (listBoxCategory.SelectedItem == null)
            {
                TaskDialog.Show("Warning!", "Select Category!");
            }
            else
            {
                ShowColumnCategory showColumnCategory = new ShowColumnCategory(document);
                showColumnCategory.ShowDialog();
            }

        }

        static BuiltInCategory[] bics =
        {
            BuiltInCategory.OST_Doors,
            BuiltInCategory.OST_Walls,
            BuiltInCategory.OST_Windows,
            BuiltInCategory.OST_Furniture,
            BuiltInCategory.OST_Levels,
            BuiltInCategory.OST_Rooms,
            BuiltInCategory.OST_MEPSpaces
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            Categories categories = document.Settings.Categories;
            Category cat;

            foreach (BuiltInCategory bic in bics)
            {
                try
                {
                    cat = categories.get_Item(bic);
                    listBoxCategory.Items.Add(cat.Name);
                }
                catch (Exception ex)
                {
                    TaskDialog.Show("ss", ex.Message);
                }
            }
        } 

        private void ListBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSelCat.Text = listBoxCategory.SelectedItem.ToString();
            selectedCategory = txtSelCat.Text;
            //TaskDialog.Show("ssss", selectedCategory);
        }

        private void TxtSelCat_TextChanged(object sender, EventArgs e)
        {            
        }

        //private void BtnColumn_Click(object sender, EventArgs e)
        //{
        //    FileColumns fc = new FileColumns();
        //    fc.ShowDialog();
        //    txtColumn.Text = fc.SelColumn;
        //}
    }
}
