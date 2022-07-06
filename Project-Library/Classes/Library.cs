using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace Library.Classes
{
    /// <summary>
    /// 도서관의 메인 중앙 시스템 정보 클래스입니다.
    /// </summary>
    internal class Library
    {
        private string path;

        private List<Book> books;
        private List<User> users;

        private int max_days;
        private int max_books;

        /// <summary>
        /// 도서관 시스템을 생성하는 생성자입니다.
        /// </summary>
        /// <param name="path"> 책과 유저의 데이터가 담긴 엑셀의 주소입니다. </param>
        public Library(string path)
        {
            this.path = path;

            this.books = new List<Book>();
            this.users = new List<User>();

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(Environment.CurrentDirectory + path);

            Excel.Worksheet usersheet = workbook.Worksheets[1];
            Excel.Worksheet booksheet = workbook.Worksheets[2];

            for (int r = 1; r <= usersheet.UsedRange.Rows.Count; r++)
            {
                this.users.Add(new User()
                {
                    Name = usersheet.Cells[r, 1].Value2.ToString(),
                    ID = usersheet.Cells[r, 2].Value2.ToString(),
                    Password = usersheet.Cells[r, 3].Value2.ToString(),
                    Barcode = usersheet.Cells[r, 4].Value2.ToString(),
                    Overdue = int.Parse(usersheet.Cells[r, 5].Value2.ToString()),
                    Borrows = usersheet.Cells[r, 6].Value2.ToString() == "null" ? 
                        new List<string> { "" } : 
                        ((string)usersheet.Cells[r, 6].Value2.ToString()).Split('/').ToList(),
                });
                this.users[r - 1].Borrows.RemoveAt(this.users[r - 1].Borrows.Count - 1);
            }

            for (int r = 1; r <= booksheet.UsedRange.Rows.Count; r++)
            {
                this.books.Add(new Book()
                {
                    Title = booksheet.Cells[r, 1].Value2.ToString(),
                    Description = booksheet.Cells[r, 2].Value2.ToString(),
                    Author = booksheet.Cells[r, 3].Value2.ToString(),
                    BookCode = booksheet.Cells[r, 4].Value2.ToString(),
                    Barcode = booksheet.Cells[r, 5].Value2.ToString(),
                    Days = int.Parse(booksheet.Cells[r, 6].Value2.ToString()),
                    Borrower = booksheet.Cells[r, 7].Value2.ToString() == "library" ? 
                        null : booksheet.Cells[r, 7].Value2.ToString(),
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
        /// 도서관에서 한 번에 빌릴 수 있는 최대 도서의 수 입니다.
        /// </summary>
        public int MaxBooks { get => this.max_books; set => this.max_books = value; }

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

        /// <summary>
        /// 이용자가 책을 빌리기 위해 시도합니다.
        /// </summary>
        /// <param name="user"> 책을 빌릴 이용자입니다. </param>
        /// <param name="book"> 빌릴 책입니다. </param>
        /// <returns> 이용자가 여러 사유로 책을 빌리지 못했다면 거짓, 빌렸다면 참을 반환합니다. </returns>
        public bool Borrow(User user, Book book)
        {
            if (book.Borrower == null && user.Overdue == 0 && user.Borrows.Count < this.max_books)
            {
                user.Borrows.Add(book.Barcode);
                book.Borrower = user.Barcode;
                book.Days = 0;

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 빌린 책을 반납합니다.
        /// </summary>
        /// <param name="user"> 책을 반납하는 이용자입니다. </param>
        /// <param name="book"> 반납할 도서입니다. </param>
        public void GiveBack(User user, Book book)
        {
            user.Borrows.Remove(book.Barcode);
            book.Borrower = null;
            book.Days = -1;
        }

        /// <summary>
        /// 테스트를 위해, 하루를 진행합니다.
        /// </summary>
        public void AddDay()
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                if (this.books[i].Days != -1) 
                {
                    this.books[i].Days++; 

                    if (this.books[i].Days > this.max_days)
                    {
                        FindUser(this.books[i].Borrower).Overdue++;
                    }
                }
            }

            for (int i = 0; i <this.users.Count; i++)
            {
                if (this.users[i].Overdue > 0 && this.users[i].Borrows.Count == 0)
                {
                    this.users[i].Overdue--;
                }
            }
        }

        /// <summary>
        /// 현재 도서관의 상태를 엑셀에 다시 저장합니다.
        /// </summary>
        public void SaveData()
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(Environment.CurrentDirectory + this.path);

            Excel.Worksheet usersheet = workbook.Worksheets[1];
            Excel.Worksheet booksheet = workbook.Worksheets[2];

            usersheet.UsedRange.Clear();
            booksheet.UsedRange.Clear();

            for (int r = 0; r < this.users.Count; r++)
            {
                usersheet.Cells[r + 1, 1] = this.users[r].Name;
                usersheet.Cells[r + 1, 2] = this.users[r].ID;
                usersheet.Cells[r + 1, 3] = this.users[r].Password;
                usersheet.Cells[r + 1, 4] = this.users[r].Barcode;
                usersheet.Cells[r + 1, 5] = this.users[r].Overdue;
                string str = "";
                for (int i = 0; i < this.users[r].Borrows.Count; i++)
                {
                    str += this.users[r].Borrows[i] + "/";
                }
                if (this.users[r].Borrows.Count == 0)
                {
                    str += "null";
                }
                usersheet.Cells[r + 1, 6] = str;
            }

            for (int r = 0; r < this.books.Count; r++)
            {
                booksheet.Cells[r + 1, 1] = this.books[r].Title;
                booksheet.Cells[r + 1, 2] = this.books[r].Description;
                booksheet.Cells[r + 1, 3] = this.books[r].Author;
                booksheet.Cells[r + 1, 4] = this.books[r].BookCode;
                booksheet.Cells[r + 1, 5] = this.books[r].Barcode;
                booksheet.Cells[r + 1, 6] = this.books[r].Days;
                booksheet.Cells[r + 1, 7] = this.books[r].Borrower;
                if (this.books[r].Borrower == null)
                {
                    booksheet.Cells[r + 1, 7] = "library";
                }
            }

            workbook.Save();
            workbook.Close();
            app.Quit();
        }
    }
}
