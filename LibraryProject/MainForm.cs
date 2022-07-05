using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Text = "내 손으로 코딩하는 작은 도서관";
            this.Font = new Font("Verdana", 11, FontStyle.Regular);
            this.Width = 1100;
            this.Height = 600;
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //Controls.UserDataSheet user = new Controls.UserDataSheet()
            //{ 
            //    Parent = this,
            //    Library = new Structure.Library(@"C:\Users\tkvkf\source\repos\cs-wave\LibraryProject\LibraryProject\bin\Debug\excel.xlsx") 
            //};
            //user.FindUser("100001");

            //LibraryProject.Controls.BookDataSheet book = new LibraryProject.Controls.BookDataSheet()
            //{
            //    Parent = this,
            //    Library = new Structure.Library(@"C:\Users\tkvkf\source\repos\cs-wave\LibraryProject\LibraryProject\bin\Debug\excel.xlsx")
            //};
            //book.FindBook("200001");

            //bookDataSheet1.Library = new Structure.Library(@"C:\Users\tkvkf\source\repos\cs-wave\LibraryProject\LibraryProject\bin\Debug\excel.xlsx");
            //bookDataSheet1.FindBook("200001");

            //Classes.Library lib = new Classes.Library(@"C:\Users\tkvkf\source\repos\cs-wave\LibraryProject\LibraryProject\bin\Debug\excel.xlsx");
            //lib.Books.RemoveAt(1);
            //lib.SaveData();

            /*
             * 만들거
             * 대출
             * 반납
             * 도서 정보 수정
             * 회원 정보 수정
             */
        }
    }
}
