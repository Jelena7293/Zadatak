using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelImport
{
    class SetParameterValue
    {
        public static void SetParamValue(Parameter p, object value)
        {
            //try
            //{
                //if (value.GetType().Equals(typeof(string)))
                //{
                //    if (p.SetValueString(value as string))
                //        return;
                //}

                switch (p.StorageType)
                {
                    case StorageType.None:
                        break;
                    case StorageType.Double:

                        if (value.GetType().Equals(typeof(string)))
                        {
                            p.Set(double.Parse(value as string));
                        }
                        else
                        {
                            p.Set(Convert.ToDouble(value));
                        }
                        break;
                    case StorageType.Integer:
                        if (value.GetType().Equals(typeof(string)))
                        {
                            p.Set(int.Parse(value as string));
                        }
                        else
                        {
                            p.Set(Convert.ToInt32(value));
                        }
                        break;
                    case StorageType.ElementId:
                        if (value.GetType().Equals(typeof(ElementId)))
                        {
                            p.Set(value as ElementId);
                        }
                        else if (value.GetType().Equals(typeof(string)))
                        {
                            p.Set(new ElementId(int.Parse(value.ToString())));
                        }
                        else
                        {
                            p.Set(new ElementId(Convert.ToInt32(value)));
                        }
                        break;
                    case StorageType.String:
                        p.Set(value.ToString());
                        break;
                }
            //}
            //catch (Exception ex)
            //{
            //    //throw new Exception("Invalid Value Input!");
            //    TaskDialog.Show("Exception", ex.Message + " Parameter storage type is: " + p.StorageType);
            //}
        }
    }
}
