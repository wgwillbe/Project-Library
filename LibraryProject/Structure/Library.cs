using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Structure
{
    /// <summary>
    /// 도서관의 메인 중앙 시스템 정보 클래스입니다.
    /// </summary>
    internal class Library
    {
        private List<Book> books;
        private List<User> users;

        private int max_days;

        /// <summary>
        /// 도서관 시스템을 생성하는 생성자입니다.
        /// </summary>
        /// <param name="path"> 책과 유저의 데이터가 담긴 엑셀의 주소입니다. </param>
        public Library(string path)
        {
            this.books = new List<Book>();
            this.users = new List<User>();
        }

        /// <summary>
        /// 책을 빌릴 수 있는 최대 기한입니다.
        /// </summary>
        public int MaxDays { get => this.max_days; set => this.max_days = value; }

        /// <summary>
        /// 유저의 정보가 담긴 리스트입니다.
        /// </summary>
        public List<User> Users { get => this.users; }
    }
}
