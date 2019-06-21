using Autodesk.Revit.UI;
using ClosedXML.Excel;
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
    public partial class FileColumns : Form
    {
        string address;
        public FileColumns()
        {
            InitializeComponent();
        }
        
        public string SelColumn
        {
            get { return address; }
            set { address = value; }
        }
        private void FileColumns_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            ShowColumn showColumn = new ShowColumn();
            showColumn.ShowColumnName(Form1.fileName, listBoxColumn);
        }

        private void ListBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedColumn = listBoxColumn.SelectedItem.ToString();
            //address = selectedColumn;
            Form1 frm = new Form1();

            //var wb = new XLWorkbook(frm.FileName);
            //var ws = wb.Worksheet(1);
            //var col = ws.Column(selectedColumn);
            ////address = col.FirstCellUsed().Address.ToString();
            //address = ws.Cell(selectedColumn).Address.ToString();
            //if(ws.Cell().Value== selectedColumn)
            //{ }

            var wb = new XLWorkbook(Form1.fileName);
            var ws = wb.Worksheet(1);
            var firstRowUsed = ws.FirstRowUsed();
            var categoryRow = firstRowUsed.RowUsed();
            categoryRow = categoryRow.RowBelow();
            var firstPossibleAddress = ws.Row(categoryRow.RowNumber()).FirstCell().Address;
            var lastPossibleAddress = ws.LastCellUsed().Address;
            var companyRange = ws.Range(firstPossibleAddress, lastPossibleAddress).RangeUsed();
            foreach (IXLCell cell in companyRange.FirstRow().Cells())
            {
                
                if(selectedColumn == cell.Value.ToString())
                {
                    address = cell.Address.ToString();
                    TaskDialog.Show("ss", selectedColumn + "   " + cell.Address.ToString());
                }

            }
            

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
            //TaskDialog.Show("SS", selectedColumn);
        }
    }
}
