using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    /// <summary>
    /// 도서관 이용자의 정보를 담은 클래스입니다.
    /// </summary>
    internal class User
    {
        private string name;
        private string id;
        private string password;
        private string barcode;
        private int overdue;
        private List<string> borrows;

        /// <summary>
        /// 도서관 이용자를 생성하는 생성자입니다.
        /// </summary>
        /// <param name="name"> 이용자의 이름입니다. </param>
        /// <param name="id"> 이용자의 ID입니다. </param>
        /// <param name="password"> 이용자의 비밀번호입니다. </param>
        public User(string name = "", string id = "", string password = "")
        {
            this.name = name;
            this.id = id;
            this.password = password;
            this.borrows = new List<string>();
            this.overdue = 0;
        }

        /// <summary>
        /// 이용자의 이름입니다.
        /// </summary>
        public string Name { get => this.name; set => this.name = value; }

        /// <summary>
        /// 이용자의 ID입니다.
        /// </summary>
        public string ID { get => this.id; set => this.id = value; }

        /// <summary>
        /// 이용자의 비밀번호입니다.
        /// </summary>
        public string Password { get => this.password; set => this.password = value; }

        /// <summary>
        /// 이용자가 빌린 도서의 바코드 정보이며, 책을 빌리지 않았다면 "null"입니다.
        /// </summary>
        public List<string> Borrows { get => this.borrows; set => this.borrows = value; }

        /// <summary>
        /// 이용자의 연체 일자이며, 연체되지 않았다면 값은 0입니다.
        /// </summary>
        public int Overdue { get => this.overdue; set => this.overdue = value; }

        /// <summary>
        /// 책의 바코드입니다.
        /// </summary>
        public string Barcode { get => this.barcode; set => this.barcode = value; }
    }
}
