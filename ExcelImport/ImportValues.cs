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
            //string param = "";
            List<string> valuesParameter = Table.DataRange.Rows().Select(companyRow => companyRow.Field(ShowColumnCategory.uniqueParameter).GetString()).ToList();
            try
            {
                foreach (string item in valuesParameter)
                {
                    Categories categories = LoadExcelFile.document.Settings.Categories;
                    Category cat;
                    cat = categories.get_Item(Form1.selectedCategory);
                    BuiltInCategory builtInCategory = (BuiltInCategory)cat.Id.IntegerValue;
                    FilteredElementCollector collector = new FilteredElementCollector(LoadExcelFile.document);
                    IList<Element> elementsOfCategory = collector.WhereElementIsNotElementType().OfCategory(builtInCategory).ToElements();
                    using (Transaction t = new Transaction(LoadExcelFile.document, "Add value"))
                    {
                        t.Start();
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

                                    //for (int k = 0; k < MappingColumnParameter.mappingColumn.Count; k++)
                                    //{
                                    //    Parameter hhhhhhh = el.LookupParameter(MappingColumnParameter.mappingParameter[k]);
                                    //    if(hhhhhhh.IsReadOnly)
                                    //    {
                                    //        param += hhhhhhh.Definition.Name + ", ";
                                    //    }

                                    //}

                                    //mappingParameter.Set(vrij);
                                    //mappingParameter.SetValueString(vrij);
                                    //mappingParameter.AsElementId.((ElementId)vrij as ElementId);
                                    //mappingParameter.Set(new ElementId(Convert.ToInt16(vrij)));
                                    SetParameterValue.SetParamValue(mappingParameter, vrij);
                                    
                                    //TaskDialog.Show("Finish", "Successfully entered values of parameters!");
                                    //}

                                    //--------------------------------------------------------------------------------------------------------------------------
                                    //foreach (string mappingColumn in MappingColumnParameter.mappingColumn)
                                    //{
                                    //    foreach (string mappingParam in MappingColumnParameter.mappingParameter)
                                    //    {
                                    //        if (cellCol.Value.ToString() == mappingColumn)
                                    //        {
                                    //            TaskDialog.Show("wwww", mappingColumn + "/" + mappingParam);
                                    //            var cellColumnAddress = cellCol.Address.ColumnNumber.ToString();
                                    //            var vrij = ws.Cell(int.Parse(cellRowAddress), int.Parse(cellColumnAddress)).Value.ToString();

                                    //            Parameter mappingParameter = el.LookupParameter(mappingParam);
                                    //            mappingParameter.Set(vrij);
                                    //        }
                                    //    }
                                    //}




                                }
                            }
                            
                        }
                        t.Commit();
                    }


                }
                
                TaskDialog.Show("Finish", "Successfully entered values of parameters!");
            }
            catch(Exception ex)
            {
                //TaskDialog.Show("ReadOnly", "Parameter " + param + " is ReadOnly!");
                TaskDialog.Show("ReadOnly", ex.Message);
            }
        }
    }
}
