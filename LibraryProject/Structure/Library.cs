using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace LibraryProject.Structure
{
    /// <summary>
    /// 도서관의 메인 중앙 시스템 정보 클래스입니다.
    /// </summary>
    internal class Library
    {
        private const int TITLE = 1, DESCRIPTION = 2, AUTHOR = 3, BOOKCODE = 4, BARCODE = 5;

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

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(path);

            Excel.Worksheet usersheet = workbook.Worksheets[1];
            Excel.Worksheet booksheet = workbook.Worksheets[2];

            for (int r = 1; r <= usersheet.UsedRange.Rows.Count; r++)
            {
                this.users.Add(new User()
                {
                    Name = usersheet.Cells[r, 1].Value.ToString(),
                    ID = usersheet.Cells[r, 2].Value.ToString(),
                    Password = usersheet.Cells[r, 3].Value.ToString(),
                    Barcode = usersheet.Cells[r, 4].Value.ToString(),
                    Overdue = int.Parse(usersheet.Cells[r, 5].Value.ToString()),
                    Borrows = (usersheet.Cells[r, 6].Value.ToString() as string).Split('/').ToList(),
                });
            }

            for (int r = 1; r <= booksheet.UsedRange.Rows.Count; r++)
            {
                this.books.Add(new Book()
                {
                    Title = booksheet.Cells[r, 1].Value.ToString(),
                    Description = booksheet.Cells[r, 2].Value.ToString(),
                    Author = booksheet.Cells[r, 3].Value.ToString(),
                    BookCode = booksheet.Cells[r, 4].Value.ToString(),
                    Barcode = booksheet.Cells[r, 5].Value.ToString(),
                    Days = int.Parse(booksheet.Cells[r, 6].Value.ToString()),
                    Brorrower = booksheet.Cells[r, 7].Value.ToString(),
                });
            }

            workbook.Close();
            app.Quit();
        }

        /// <summary>
        /// 책을 빌릴 수 있는 최대 기한입니다.
        /// </summary>
        public int MaxDays { get => this.max_days; set => this.max_days = value; }

        /// <summary>
        /// 유저의 정보가 담긴 리스트입니다.
        /// </summary>
        public List<User> Users { get => this.users; }

        /// <summary>
        /// 도서의 정보가 담긴 리스트입니다.
        /// </summary>
        public List<Book> Books { get => this.books; }

        /// <summary>
        /// 바코드를 사용하여 해당 바코드를 지닌 책을 찾습니다.
        /// </summary>
        /// <param name="barcode"> 찾을 책의 바코드입니다. </param>
        /// <returns> 찾은 책입니다. 찾지 못했다면 null입니다. </returns>
        public Book FindBook(string barcode)
        {
            return this.books.Find((x) => { return x.Barcode == barcode; });
        }

        /// <summary>
        /// 바코드를 사용하여 해당 바코드를 지닌 이용자를 찾습니다.
        /// </summary>
        /// <param name="barcode"> 찾을 이용자의 바코드입니다. </param>
        /// <returns> 찾은 이용자입니다. 찾지 못했다면 null입니다. </returns>
        public User FindUser(string barcode)
        {
            return this.users.Find((x) => { return x.Barcode == barcode; });
        }
    }
}
