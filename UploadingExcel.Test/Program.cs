using System;
using System.Collections.Generic;
using UploadingExcel.Test.Adapter;
using System.Threading.Tasks;


namespace UploadingExcel.Test
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var excel = new Excel(@"A:\Db.xlsx", 1);

            var idProcess = new List<string>();
            for (var i = 5; i < 105; i++)
            {
                var result = excel.ReadCell(i, 2);
                if (result == null)
                    result = "null";
                idProcess.Add(result);
            }

            foreach (var t in idProcess)
            {
                Console.WriteLine(t);
            }

            var nameProcess = new List<string>();
            for (var i = 5; i < 105; i++)
            {
                var result = excel.ReadCell(i, 3);
                if (result == null)
                    continue;
                nameProcess.Add(result);
            }

            foreach (var t in nameProcess)
            {
                Console.WriteLine(t);
            }

            var divisions = new List<string>();
            for (var i = 5; i < 105; i++)
            {
                var result = excel.ReadCell(i, 4);
                if (result == null)
                    result = "null";
                divisions.Add(result);
            }

            foreach (var t in divisions)
            {
                Console.WriteLine(t);
            }


            for (int index = 0; index < 50; index++)
            {
                var dataBase = new DataBase("process", idProcess[index], nameProcess[index], divisions[index]);
                dataBase.InsertValue();
            }
        }
    }
}