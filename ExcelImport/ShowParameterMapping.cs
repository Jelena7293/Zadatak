using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImport
{
    class ShowParameterMapping
    {
        public void ShowCategoryName(Document document, ListBox listBox1)
        {

            Categories categories = document.Settings.Categories;
            Category cat;

            cat = categories.get_Item(Form1.selectedCategory);
            BuiltInCategory builtInCategory = (BuiltInCategory)cat.Id.IntegerValue;
            FilteredElementCollector collector = new FilteredElementCollector(document);
            IList<Element> elementsOfCategory = collector.WhereElementIsNotElementType().OfCategory(builtInCategory).ToElements();
            Element el = elementsOfCategory.FirstOrDefault();
            foreach (Parameter parameter in el.Parameters)
            {
                listBox1.Items.Add(parameter.Definition.Name);
                if (parameter.Definition.Name == ShowColumnCategory.uniqueParameter)
                {
                    //TaskDialog.Show("cell value", parameter.Definition.Name + "/" + ShowColumnCategory.uniqueParameter);
                    listBox1.Items.Remove(parameter.Definition.Name);
                }
            }

        }
    }
}
