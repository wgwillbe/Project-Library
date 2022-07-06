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
            this.Width = 1100;
            this.Height = 600;
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void barcodeScanner1_TextChanged(object sender, EventArgs e)
        {
            this.bookDataSheet1.Library = this.library;
            this.bookDataSheet1.FindBook((sender as RichTextBox).Text);

            this.book = library.FindBook((sender as RichTextBox).Text);

            borrow1.Library = library;
            borrow1.User = user;
            borrow1.Book = book;
            giveBack1.Library = library;
            giveBack1.User = user;
            giveBack1.Book = book;
        }

        private void barcodeScanner2_TextChanged(object sender, EventArgs e)
        {
            this.userDataSheet1.Library = this.library;
            this.userDataSheet1.FindUser((sender as RichTextBox).Text);

            this.user = library.FindUser((sender as RichTextBox).Text);

            borrow1.Library = library;
            borrow1.User = user;
            borrow1.Book = book;
            giveBack1.Library = library;
            giveBack1.User = user;
            giveBack1.Book = book;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            library.AddDay();
        }
    }
}
