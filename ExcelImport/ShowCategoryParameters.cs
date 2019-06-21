using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImport
{
    class ShowCategoryParameters 
    {

        //public static BuiltInCategory[] cats =
        //{
        //    BuiltInCategory.OST_Doors,
        //    BuiltInCategory.OST_Walls,
        //    BuiltInCategory.OST_Windows,
        //    BuiltInCategory.OST_Furniture,
        //    BuiltInCategory.OST_Levels,
        //    BuiltInCategory.OST_Rooms,
        //    BuiltInCategory.OST_MEPSpaces
        //};
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
            }
            //izbjeci ovaj forech
            //foreach (BuiltInCategory bic in cats)
            //{
            //    try
            //    {
            //        cat = categories.get_Item(bic);
            //        if (cat.Name == Form1.selectedCategory)
            //        {
            //            ElementCategoryFilter filter = new ElementCategoryFilter(bic);
            //            FilteredElementCollector collector = new FilteredElementCollector(document);
            //            List<Element> elem = collector.WherePasses(filter).WhereElementIsNotElementType().ToList();
            //            Element el = elem.FirstOrDefault();
            //            foreach (Parameter parameter in el.Parameters)
            //            {
            //                listBox1.Items.Add(parameter.Definition.Name);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        TaskDialog.Show("wwwwww", ex.Message);
            //    }
            //}
            //-----------------------------------------------------------------------------------------------------------------



        }
    }
}
