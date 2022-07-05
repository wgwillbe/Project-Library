using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    /// <summary>
    /// 책을 빌리는 버튼입니다.
    /// </summary>
    internal class Borrow : Button
    {
        private Classes.Library library;
        private Classes.User user;
        private Classes.Book book;

        public Borrow() : base()
        {
            base.Text = "대출하기";
            base.Click += (sender, e) =>
            {
                this.library.Borrow(this.user, this.book);
            };
        }

        /// <summary>
        /// 책을 빌릴 도서관의 시스템입니다.
        /// </summary>
        public Classes.Library Library { get => this.library; set => this.library = value; }

        /// <summary>
        /// 책을 빌리는 이용자입니다.
        /// </summary>
        public Classes.User User { get => this.user; set => this.user = value; }
    
        /// <summary>
        /// 빌릴 도서입니다.
        /// </summary>
        public Classes.Book Book { get => this.book; set => this.book = value; }
    }
}
