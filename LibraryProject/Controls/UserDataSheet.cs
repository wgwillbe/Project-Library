using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    /// <summary>
    /// 유저의 정보를 표현하는 텍스트입니다.
    /// </summary>
    internal class UserDataSheet : TextBox
    {
        private Classes.Library library;

        /// <summary>
        /// 컨트롤의 기본 생성자입니다.
        /// </summary>
        public UserDataSheet() : base()
        {
            base.ReadOnly = true;
            base.Multiline = true;
        }

        /// <summary>
        /// 이용자를 검색할 도서관 시스템 정보입니다.
        /// </summary>
        public Classes.Library Library { get => this.library; set => this.library = value; }

        /// <summary>
        /// 바코드를 사용해 이용자를 찾습니다.
        /// </summary>
        /// <param name="barcode"> 찾을 이용자의 바코드입니다. </param>
        public void FindUser(string barcode)
        {
            Classes.User user = this.library.FindUser(barcode);

            if (user != null)
            {
                base.Text += "이름: " + user.Name + "\r\n";

                base.Text += "아이디: " + user.ID + "\r\n";

                base.Text += "비밀번호: ";
                for (int i = 0; i < user.Password.Length; i++)
                {
                    base.Text += "*";
                }
                base.Text += "\r\n";

                base.Text += "연체일: " + user.Overdue + "\r\n";

                base.Text += "대출한 도서" + "\r\n";
                for (int i = 0; i < user.Borrows.Count; i++)
                {
                    Classes.Book book = this.library.FindBook(user.Borrows[i]);
                    base.Text += $" - {book.Title}; {book.Author} 저: {book.BookCode}" + "\r\n";
                }
            }
        }
    }
}
