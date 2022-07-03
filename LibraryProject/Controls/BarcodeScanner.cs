using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryProject.Controls
{
    /// <summary>
    /// RichTextBox를 상속받는 BarcodeScanner 컨트롤입니다.
    /// </summary>
    internal class BarcodeScanner : RichTextBox
    {
        private const int TITLE = 1, DESCRIPTION = 2, AUTHOR = 3, BOOKCODE = 4, BARCODE = 5;

        /// <summary>
        /// 컨트롤의 기본 생성자입니다.
        /// </summary>
        public BarcodeScanner() : base()
        {
            
        }

        /// <summary>
        /// 텍스트 박스 내 입력된, 책의 바코드를 기반으로 같은 바코드를 지닌 책의 정보를 찾습니다.
        /// 책을 찾지 못했다면 null을 반환합니다.
        /// </summary>
        /// <param name="path"> 엑셀 데이터베이스의 상대 경로입니다. </param>
        /// <returns></returns>
        public Structure.Book FindBook(string path)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(path);
            Excel.Worksheet worksheet = workbook.Worksheets[0];

            for (int r = 0; r < worksheet.Rows.Count; r++)
            {
                if (worksheet.Cells[r, BARCODE].Value == this.Text)
                {
                    return new Structure.Book(worksheet.Cells[r, TITLE].Value,
                                              worksheet.Cells[r, DESCRIPTION].Value,
                                              worksheet.Cells[r, AUTHOR].Value,
                                              worksheet.Cells[r, BOOKCODE].Value,
                                              worksheet.Cells[r, BARCODE].Value);
                }
            }

            return null;
        }
    }
}
