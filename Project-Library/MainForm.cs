using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private Classes.Library library = new Classes.Library(@"C:\Users\tkvkf\source\repos\cs-wave\Project-Library\Project-Library\bin\Debug\excel.xlsx")
        {
            MaxDays = 7,
            MaxBooks = 3,
        };
        private Classes.User user;
        private Classes.Book book;

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.OpenBook;
            this.Text = "내 손으로 코딩하는 작은 도서관";
            this.Font = new Font("Verdana", 11, FontStyle.Regular);
            this.Width = 800;
            this.Height = 600;
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void ChangeBookBarcode(object sender, EventArgs e)
        {
            this.book_data.Library = this.library;
            this.book_data.FindBook((sender as RichTextBox).Text);

            this.book = this.library.FindBook((sender as RichTextBox).Text);
        }

        private void ChangeUserBarcode(object sender, EventArgs e)
        {
            this.user_data.Library = this.library;
            this.user_data.FindUser((sender as RichTextBox).Text);

            this.user = this.library.FindUser((sender as RichTextBox).Text);
        }

        private void ClickAddDay(object sender, EventArgs e)
        {
            this.library.AddDay();

            ChangeBookBarcode(this.book_barcode, e);
            ChangeUserBarcode(this.user_barcode, e);
        }

        private void ClickBorrow(object sender, EventArgs e)
        {
            if (!this.library.Borrow(this.user, this.book))
            {
                MessageBox.Show("대출에 실패했습니다.");
            }
        
            ChangeBookBarcode(this.book_barcode, e);
            ChangeUserBarcode(this.user_barcode, e);
        }

        private void ClickGiveBack(object sender, EventArgs e)
        {
            this.library.GiveBack(this.user, this.book);

            ChangeBookBarcode(this.book_barcode, e);
            ChangeUserBarcode(this.user_barcode, e);
        }
    }
}
