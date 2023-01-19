
using System.Collections.Generic;
using UploadingExcel.Test.Adapter;

namespace UploadingExcel.Test.Logic
{
    public class InputExcel
    {
        Excel excel = new Excel(@"A:\Db.xlsx", 1);
        public void InputId()
        {
            List<string> idProcess = new List<string>();
            for (var i = 5; i < 105; i++)
            {
                var result = excel.ReadCell(i, 2);
                if (result == null)
                    result = "null";
                idProcess.Add(result);
            }
        }
    }
}