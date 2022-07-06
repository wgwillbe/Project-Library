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
        public MainForm()
        {
            InitializeComponent();

            this.Text = "내 손으로 코딩하는 작은 도서관";
            this.Font = new Font("Verdana", 11, FontStyle.Regular);
            this.Width = 1100;
            this.Height = 600;
            this.MaximizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
