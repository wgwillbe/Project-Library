using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    /// <summary>
    /// 숫자만을 입력받도록 설계된 바코드 입력 칸입니다.
    /// </summary>
    internal class BarcodeScanner : RichTextBox
    {
        /// <summary>
        /// 컨트롤의 기본 생성자입니다.
        /// </summary>
        public BarcodeScanner() : base()
        {
            base.TextChanged += (sender, e) =>
            {
                for (int i = 0; i < (sender as RichTextBox).Text.Length; i++)
                {
                    if ((sender as RichTextBox).Text[i] < '0' || (sender as RichTextBox).Text[i] > '9')
                    {
                        (sender as RichTextBox).Text = (sender as RichTextBox).Text.Remove(i, 1);
                        (sender as RichTextBox).SelectionStart = i;
                    }
                }
            };
        }
    }
}
