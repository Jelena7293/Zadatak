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
        public static string imeParametra = "";
        public static string tipParametra = "";
        public static string imeKolone = "";
        public static string tipKolone = "";
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
            var cellRowAddress = string.Empty;
            var cellColumnAddress = string.Empty;
            var cellColumnName = string.Empty;

            //int k = 0;
            //int k = MappingColumnParameter.mappingParameter.Count;
            //string greska = "";
            //public static List<String> mappingParameter = new List<string>();
            Parameter mappingParameter = null;
            //List<String> nisujednakiP = new List<string>();
            //List<String> nisujednakiK = new List<string>();
            //List<String> jednaki = new List<string>();
            List<String> pomocna = new List<string>();
            List<String> greska = new List<string>();
            string invalidInput = "";
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
                                    //-----------------------------------------------
                                    //var itemm = from val in valuesParameter
                                    //            where val.ToString() == uniqueParameter.AsString()
                                    //            select val;
                                    //-----------------------------------------------
                                    if (cell.Value.ToString() == item.ToString())
                                    {
                                        cellRowAddress = cell.Address.RowNumber.ToString();
                                        var row = ws.Row(int.Parse(cellRowAddress));
                                        foreach (IXLCell cellCol in Range.FirstRow().Cells())
                                        {
                                            if (cellCol.Value.ToString() == MappingColumnParameter.mappingColumn[i])
                                            {
                                                cellColumnAddress = cellCol.Address.ColumnNumber.ToString();
                                                //cellColumnName = cellCol.Address.ColumnLetter.ToString();
                                                cellColumnName = cellCol.Value.ToString();
                                            }
                                        }
                                    }
                                }
                                var vrij = ws.Cell(int.Parse(cellRowAddress), int.Parse(cellColumnAddress)).Value.ToString();

                                mappingParameter = el.LookupParameter(MappingColumnParameter.mappingParameter[i]);

                                using (SubTransaction subtr = new SubTransaction(LoadExcelFile.document))
                                {
                                    subtr.Start();
                                    ////mappingParameter.Set(vrij);
                                    ////mappingParameter.SetValueString(vrij);
                                    try
                                    {
                                        SetParameterValue.SetParamValue(mappingParameter, vrij);
                                        //pomocna.Add("\nSuccessfully entered column " + MappingColumnParameter.mappingColumn[i] + " in parameter " + mappingParameter.Definition.Name);
                                    }
                                    catch
                                    {
                                        greska.Add("Parameter " + mappingParameter.Definition.Name + " storage type is: " + mappingParameter.StorageType + " \nand type of column " + cellColumnName + " is: " + cellColumnAddress.GetType().Name + "\n");
                                        continue;
                                    }


                                    subtr.Commit();
                                }
                            }

                        }
                    }



                }

                invalidInput = string.Empty;
                for (int j = 0; j < (greska.Count / 32); j++)
                {
                    if(greska.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        invalidInput += greska[j];
                    }

                }
                greska.Clear();
                cellColumnName = string.Empty;
                MappingColumnParameter.mappingColumn.Clear();
                MappingColumnParameter.mappingParameter.Clear();
                if (invalidInput == string.Empty)
                {
                    TaskDialog.Show("Finish", "Successfully entered values of parameters!");
                }
                else
                {
                    TaskDialog.Show("Warning!", "Invalid Value Input! \n" + invalidInput);
                    TaskDialog.Show("Finish", "Successfully entered values of parameters!");
                }
                
                

                //TaskDialog.Show("Finish", "Successfully entered values of parameters!");

                //Successfully successfully = new Successfully();
                //successfully.ShowDialog();
                t.Commit();
            }
            //}
            //catch
            //{
            //    TaskDialog.Show("Error!", "Invalid Value Input! " + " \nParameter " + mappingParameter.Definition.Name + " storage type is: " + mappingParameter.StorageType + " \nand type of column " + cellColumnName + " is: " + cellColumnName.GetType().Name + "\nRemove it!");
            //}

        }
    }
}
