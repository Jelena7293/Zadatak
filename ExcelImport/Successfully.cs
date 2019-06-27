using Autodesk.Revit.UI;
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
    public partial class Successfully : Form
    {
        public Successfully()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MappingColumnParameter mPC = new MappingColumnParameter(LoadExcelFile.document);
            mPC.Close();
            this.Close();


        }
    }
}
