using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImport
{
    class CorrectUniqueKey
    {
        public void Correct(String txtFileName)
        {
            //try
            //{
                var wb = new XLWorkbook(txtFileName);
                var ws = wb.Worksheet(1);
                var firstRowUsed = ws.FirstRowUsed();
                var categoryRow = firstRowUsed.RowUsed();
                categoryRow = categoryRow.RowBelow();
                var firstPossibleAddress = ws.Row(categoryRow.RowNumber()).FirstCell().Address;
                var lastPossibleAddress = ws.LastCellUsed().Address;
                var Range = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
                var Table = Range.AsTable();
                //var cellRowAddress = "";
                //var cellColumnAddress = "";
                //string param = "";
                List<string> valuesParameter = Table.DataRange.Rows().Select(companyRow => companyRow.Field(ShowColumnCategory.uniqueParameter).GetString()).ToList();

                foreach (string item in valuesParameter)
                {
                    Categories categories = LoadExcelFile.document.Settings.Categories;
                    Category cat;
                    cat = categories.get_Item(Form1.selectedCategory);
                    BuiltInCategory builtInCategory = (BuiltInCategory)cat.Id.IntegerValue;
                    FilteredElementCollector collector = new FilteredElementCollector(LoadExcelFile.document);
                    IList<Element> elementsOfCategory = collector.WhereElementIsNotElementType().OfCategory(builtInCategory).ToElements();

                    foreach (Element el in elementsOfCategory)
                    {
                        Parameter uniqueParameter = el.LookupParameter(ShowColumnCategory.uniqueParameter);
                        if (item.ToString() != uniqueParameter.AsString())
                        {
                            
                        }

                    }
                }
                MappingColumnParameter mapingColumnParameter = new MappingColumnParameter(LoadExcelFile.document);
                mapingColumnParameter.ShowDialog();

            //}
            //catch
            //{
            //    TaskDialog.Show("Error!", "Unique key is not correct!");
            //}

        }
    }
}
