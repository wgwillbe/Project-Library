using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    /// <summary>
    /// 책의 정보를 표현하는 텍스트입니다.
    /// </summary>
    internal class BookDataSheet : TextBox
    {
        private Classes.Library library;

        /// <summary>
        /// 컨트롤의 기본 생성자입니다.
        /// </summary>
        public BookDataSheet() : base()
        {
            base.ReadOnly = true;
            base.Multiline = true;
        }

        /// <summary>
        /// 책을 검색할 도서관 시스템 정보입니다.
        /// </summary>
        public Classes.Library Library { get => this.library; set => this.library = value; }

        /// <summary>
        /// 바코드를 사용해 도서를 찾습니다.
        /// </summary>
        /// <param name="barcode"> 찾을 도서의 바코드입니다. </param>
        public void FindBook(string barcode)
        {
            Classes.Book book = this.library.FindBook(barcode);

            if (book != null)
            {
                base.Text = "책: " + book.Title + "; " + book.Description + "\r\n";

                base.Text += "저자: " + book.Author + "\r\n";

                base.Text += "코드: " + book.BookCode + "; " + book.Barcode + "\r\n";

                base.Text += "상태: ";
                if (book.Days == -1)
                {
                    base.Text += "대출 가능\r\n";
                }
                else
                {
                    base.Text += $"대출 불가({book.Days}일 전 대출)\r\n";
                }
            }
        }
    }
}
