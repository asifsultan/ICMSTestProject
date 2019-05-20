using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMSTestProject
{
    class InteropExcelReader
    {


        public static void ReadFromExcel(string path)
        {
            var xlApp = new Application();
            var xlWorkbook = xlApp.Workbooks.Open(path);

            for (var i = 1; i <= xlWorkbook.Sheets.Count; i++)
            {
                _Worksheet xlWorksheet = xlWorkbook.Sheets[i];
                var name = xlWorksheet.Name.ToLower();
                switch (name)
                {
                    case "first":
                        FirstPageData(xlWorksheet, "First");
                        break;
                    case "second - rp":
                        SecondPageData(xlWorksheet, "Second - RP");
                        break;
                    case "third - complainant":
                        ThirdPageData(xlWorksheet, "Third - Complainant");
                        break;
                    case "fourth - involved party":
                        FourthPageData(xlWorksheet, "Fourth - Involved Party");
                        break;
                    case "fifth - witness":
                        FifthPageData(xlWorksheet, "Fifth - Witness");
                        break;
                    case "sixth - nature":
                        SixthPageData(xlWorksheet, "Sixth - Nature");
                        break;
                    case "seventh - voluntaryeeo":
                        SeventhPageData(xlWorksheet, "Seventh - VoluntaryEEO");
                        break;
                    case "eighth - nature":
                        EighthPageData(xlWorksheet, "Eighth - Confirmation");
                        break;
                }
            }


           // GenerateDql(path, _fileName);
        }


        public static void FirstPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
            try
            {

                for (var i = 2; i <= rowCount; i++)
                {
                    var employee = xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null
                        ? (string)xlRange.Cells[i, 1].Value2.ToString()
                        : "";
                    var anonymous = xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null
                        ? (string)xlRange.Cells[i, 2].Value2.ToString()
                        : "";
                    var filling = xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null
                        ? (string)xlRange.Cells[i, 3].Value2.ToString()
                        : "";
                    if (string.IsNullOrEmpty(filling))
                        return;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test failed with following error: ");
                Console.WriteLine(ex.Message);

            }
        }

        public static void SecondPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
           
            try
            {

                for (var i = 2; i <= rowCount; i++)
                {
                    var category = xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null
                        ? (string)xlRange.Cells[i, 1].Value2.ToString()
                        : "";
                    var reason = xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null
                        ? (string)xlRange.Cells[i, 2].Value2.ToString()
                        : "";
                    var dept = xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null
                        ? (string)xlRange.Cells[i, 3].Value2.ToString()
                        : "";
                    if (string.IsNullOrEmpty(dept))
                        return;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test failed with following error: ");
                Console.WriteLine(ex.Message);

            }
        }

        public static void ThirdPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        public static void FourthPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        public static void FifthPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        public static void SixthPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        public static void SeventhPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        public static void EighthPageData(_Worksheet xlWorksheet, string rowNum)
        {
            var xlRange = xlWorksheet.UsedRange;
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
        }

        
    }
}
