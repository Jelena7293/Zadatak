using Autodesk.Revit.UI;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelImport
{
    class ShowColumn
    {
        //zakucano, neje dobroJ, kontam
        public void ShowColumnName(String txtFileName, ListBox listBox1)
        {
            //var workbook = new XLWorkbook(txtFileName);
            //var ws1 = workbook.Worksheet(1);
            //var row = ws1.Row(5);
            //foreach (IXLCell cell in row.Cells())
            //{
            //    listBox1.Items.Add(cell.Value.ToString());
            //}
            //------------------------------------
            var wb = new XLWorkbook(txtFileName);
            var ws = wb.Worksheet(1);
            var firstRowUsed = ws.FirstRowUsed();
            var categoryRow = firstRowUsed.RowUsed();
            categoryRow = categoryRow.RowBelow();
            var firstPossibleAddress = ws.Row(categoryRow.RowNumber()).FirstCell().Address;
            var lastPossibleAddress = ws.LastCellUsed().Address;
            var companyRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
            //TaskDialog.Show("Adress", firstPossibleAddress.ToString() + " " + lastPossibleAddress.ToString()+ " " + companyRange.ToString());
            foreach (IXLCell cell in companyRange.FirstRow().Cells())
            {
                listBox1.Items.Add(cell.Value.ToString());
            }

            //------------------------------------
        }
    }
}
