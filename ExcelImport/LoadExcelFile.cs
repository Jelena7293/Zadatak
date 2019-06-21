using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImport
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    class LoadExcelFile : IExternalCommand
    {
        public static Document document;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            document = commandData.Application.ActiveUIDocument.Document;
            Form1 frm1 = new Form1(document);
            frm1.ShowDialog();

            return Result.Succeeded;
        }
        
    }
}
