using Autodesk.Revit.UI;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImport
{
    class ShowColumnMapping
    {
        public void ShowColumnName(String txtFileName, ListBox listBox1)
        {
            var wb = new XLWorkbook(txtFileName);
            var ws = wb.Worksheet(1);
            var firstRowUsed = ws.FirstRowUsed();
            var categoryRow = firstRowUsed.RowUsed();
            categoryRow = categoryRow.RowBelow();
            var firstPossibleAddress = ws.Row(categoryRow.RowNumber()).FirstCell().Address;
            var lastPossibleAddress = ws.LastCellUsed().Address;
            var companyRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
            foreach (IXLCell cell in companyRange.FirstRow().Cells())
            {
                listBox1.Items.Add(cell.Value.ToString());
                if (cell.Value.ToString() == ShowColumnCategory.uniqueColumn)
                {
                    //TaskDialog.Show("cell value", cell.Value.ToString() + "/" + ShowColumnCategory.uniqueColumn);
                    listBox1.Items.Remove(cell.Value.ToString());
                }
            }

        }
    }
}
