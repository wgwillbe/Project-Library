using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    /// <summary>
    /// RichTextBox를 상속받는 BarcodeScanner 컨트롤입니다.
    /// </summary>
    internal class BarcodeScanner : RichTextBox
    {
        /// <summary>
        /// 컨트롤의 기본 생성자입니다.
        /// </summary>
        public BarcodeScanner() : base()
        {
            
        }

        /// <summary>
        /// 텍스트 박스 내 입력된, 책의 바코드를 기반으로 같은 바코드를 지닌 책의 정보를 찾습니다.
        /// </summary>
        /// <param name="path"> 엑셀 데이터베이스의 상대 경로입니다. </param>
        /// <returns></returns>
        public Structure.Book Find(string path)
        {
            return null; // editting point
        }
    }
}
