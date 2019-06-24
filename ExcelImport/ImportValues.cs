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
    class ImportValues
    {
        public void ImportValueToParameter(String txtFileName)
        {
            AddValue(txtFileName);
        }

        public void AddValue(String txtFileName)
        {
            var wb = new XLWorkbook(txtFileName);
            var ws = wb.Worksheet(1);
            var firstRowUsed = ws.FirstRowUsed();
            var categoryRow = firstRowUsed.RowUsed();
            categoryRow = categoryRow.RowBelow();
            var firstPossibleAddress = ws.Row(categoryRow.RowNumber()).FirstCell().Address;
            var lastPossibleAddress = ws.LastCellUsed().Address;
            var Range = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
            var Table = Range.AsTable();
            var cellRowAddress = "";
            var cellColumnAddress = "";

            List<string> valuesParameter = Table.DataRange.Rows().Select(companyRow => companyRow.Field(ShowColumnCategory.uniqueParameter).GetString()).ToList();
            //try
            //{
            using (Transaction t = new Transaction(LoadExcelFile.document, "AddValue"))
            {
                t.Start();
                foreach (string item in valuesParameter)
                {
                    Categories categories = LoadExcelFile.document.Settings.Categories;
                    Category cat;
                    cat = categories.get_Item(Form1.selectedCategory);
                    BuiltInCategory builtInCategory = (BuiltInCategory)cat.Id.IntegerValue;
                    FilteredElementCollector collector = new FilteredElementCollector(LoadExcelFile.document);
                    IList<Element> elementsOfCategory = collector.WhereElementIsNotElementType().OfCategory(builtInCategory).ToElements();
                    for (int i = 0; i < MappingColumnParameter.mappingColumn.Count; i++)
                    {
                        foreach (Element el in elementsOfCategory)
                        {
                            Parameter uniqueParameter = el.LookupParameter(ShowColumnCategory.uniqueParameter);

                            if (item.ToString() == uniqueParameter.AsString())
                            {
                                foreach (IXLCell cell in Range.Cells())
                                {
                                    if (cell.Value.ToString() == item.ToString())
                                    {
                                        cellRowAddress = cell.Address.RowNumber.ToString();
                                        var row = ws.Row(int.Parse(cellRowAddress));
                                        foreach (IXLCell cellCol in Range.FirstRow().Cells())
                                        {
                                            if (cellCol.Value.ToString() == MappingColumnParameter.mappingColumn[i])
                                            {
                                                cellColumnAddress = cellCol.Address.ColumnNumber.ToString();
                                            }
                                        }
                                    }
                                }
                                var vrij = ws.Cell(int.Parse(cellRowAddress), int.Parse(cellColumnAddress)).Value.ToString();
                                Parameter mappingParameter = el.LookupParameter(MappingColumnParameter.mappingParameter[i]);
                                using (SubTransaction subtr = new SubTransaction(LoadExcelFile.document))
                                {
                                    subtr.Start();
                                    //mappingParameter.Set(vrij);
                                    //mappingParameter.SetValueString(vrij);
                                    SetParameterValue.SetParamValue(mappingParameter, vrij);
                                    subtr.Commit();
                                }
                            }

                        }
                    }



                }
                t.Commit();
            }

            TaskDialog.Show("Finish", "Successfully entered values of parameters!");

            //}
            //catch (Exception ex)
            //{
            //    TaskDialog.Show("ReadOnly", ex.Message);


            //}
        }
    }
}
