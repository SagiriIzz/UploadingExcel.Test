using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace UploadingExcel.Test.Adapter
{
    public class Excel
    {
        _Application _excel = new Application();
        Worksheet _ws;

        public Excel(string path, int sheet)
        {
            var wb = _excel.Workbooks.Open(path);
            _ws = (Worksheet) wb.Worksheets[sheet];
        }

        public string ReadCell(int i, int j)
        {
            var cells = (Range) _ws.Cells[i, j];
            var result = cells.Value2;

            return result;
        }
    }
}