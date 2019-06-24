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
    public partial class MappingColumnParameter : System.Windows.Forms.Form
    {
        private Document document;
        public static List<String> mappingParameter = new List<string>();
        public static List<String> mappingColumn = new List<string>();
        string column = "";
        string category = "";
        public MappingColumnParameter(Document document)
        {
            InitializeComponent();
            this.document = document;
        }

        private void MapingColumnParameter_Load(object sender, EventArgs e)
        {
            groupParameter.Text = "Parameter of category " + Form1.selectedCategory;

            ShowColumnMapping showColumnMapping = new ShowColumnMapping();
            showColumnMapping.ShowColumnName(Form1.fileName, listBoxCol);


            ShowParameterMapping showParameterMapping = new ShowParameterMapping();
            showParameterMapping.ShowCategoryName(document, listBoxCat);

            txtUniqueKey.Text = ShowColumnCategory.uniqueColumn + " <--> " + ShowColumnCategory.uniqueParameter;
            listBoxMapping.Items.Clear();
        }
        //int index;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBoxMapping.Items.Add(listBoxCol.SelectedItem.ToString() + " --> " + listBoxCat.SelectedItem.ToString());
            
            mappingParameter.Add(listBoxCat.SelectedItem.ToString());
            mappingColumn.Add(listBoxCol.SelectedItem.ToString());


            //index = listBoxCol.SelectedIndex;
            listBoxCol.Items.Remove(listBoxCol.SelectedItem.ToString());
            listBoxCat.Items.Remove(listBoxCat.SelectedItem.ToString());
            btnFinish.Enabled = true;
        }

        
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string text = listBoxMapping.SelectedItem.ToString();
            //string column = text.Substring(0, text.IndexOf(" --> "));
            //string category = text.Substring(text.IndexOf(" --> ") + 5);

            string[] selectedMapping = text.Split(new[] { " --> " }, StringSplitOptions.None);
            column = selectedMapping[0];
            category = selectedMapping[1];

            listBoxCol.Items.Add(column);
            listBoxCat.Items.Add(category);

            mappingColumn.Remove(column);
            mappingParameter.Remove(category);

            listBoxMapping.Items.Remove(listBoxMapping.SelectedItem.ToString());

            if (listBoxMapping.Items.Count == 0)
            {
                btnFinish.Enabled = false;
            }
        }

        private void ListBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCol.SelectedItems.Count == 1 && listBoxCat.SelectedItems.Count == 1)
            {
                btnAdd.Enabled = true;
            }
        }

        private void ListBoxCol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCol.SelectedItems.Count == 1 && listBoxCat.SelectedItems.Count == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void ListBoxMapping_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMapping.SelectedItems.Count == 1)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            string text = listBoxMapping.Items.ToString();
            //string column = text.Substring(0, text.IndexOf(" --> "));
            //string category = text.Substring(text.IndexOf(" --> ") + 5);

            string[] selectedMapping = text.Split(new[] { " --> " }, StringSplitOptions.None);
            string column = selectedMapping[0];
            //string category = selectedMapping[1];
            try
            {
                ImportValues importValues = new ImportValues();
                importValues.ImportValueToParameter(Form1.fileName);

                this.Close();
            }
            catch(Exception ex)
            {
                //TaskDialog.Show("Warning!", ex.Message + "******ovo treba izmjeniti");
                TaskDialog.Show("Warning!", column +"****" + category);
            }
        }


    }
}
