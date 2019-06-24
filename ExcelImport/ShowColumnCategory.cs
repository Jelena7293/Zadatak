using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImport
{
    public partial class ShowColumnCategory : System.Windows.Forms.Form
    {
        private Document document;

        public static string uniqueColumn = "";
        public static string uniqueParameter = "";
        public ShowColumnCategory(Document document)
        {
            InitializeComponent();
            this.document = document;
        }


        private void ShowColumnCategory_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                groupParameter.Text = "Parameter of category " + Form1.selectedCategory;

                ShowColumn showColumn = new ShowColumn();
                showColumn.ShowColumnName(Form1.fileName, listBoxColumn);


                ShowCategoryParameters showCategory = new ShowCategoryParameters();
                showCategory.ShowCategoryName(document, listBoxCategory);
            }
            catch
            {
                TaskDialog.Show("Warning!", "Selected category doesn't exist in this document!");
                this.Close();
            }
            
        }

        private void ListBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxColumn.SelectedItems.Count == 1 && listBoxCategory.SelectedItems.Count == 1)
            {
                txtUniqueKey.Text = listBoxColumn.SelectedItem.ToString() + " <--> " + listBoxCategory.SelectedItem.ToString();
            }
            lblUniqueKey2.Text = listBoxCategory.SelectedItem.ToString();
        }

        private void ListBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxColumn.SelectedItems.Count == 1 && listBoxCategory.SelectedItems.Count == 1)
            {
                txtUniqueKey.Text = listBoxColumn.SelectedItem.ToString() + " <--> " + listBoxCategory.SelectedItem.ToString();
            }
            lblUniqueKey1.Text = listBoxColumn.SelectedItem.ToString();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            uniqueColumn = lblUniqueKey1.Text;
            uniqueParameter = lblUniqueKey2.Text;
            CorrectUniqueKey cuk = new CorrectUniqueKey();
            cuk.Correct(Form1.fileName);
            //MappingColumnParameter mapingColumnParameter = new MappingColumnParameter(document);
            //mapingColumnParameter.ShowDialog();
            this.Close();
        }


    }
}
