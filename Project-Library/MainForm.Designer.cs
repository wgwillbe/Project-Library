namespace Library
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_barcode = new Library.Controls.BarcodeScanner();
            this.book_barcode = new Library.Controls.BarcodeScanner();
            this.user_data = new Library.Controls.UserDataSheet();
            this.book_data = new Library.Controls.BookDataSheet();
            this.borrow = new System.Windows.Forms.Button();
            this.give_back = new System.Windows.Forms.Button();
            this.add_day = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_barcode
            // 
            this.user_barcode.Location = new System.Drawing.Point(12, 278);
            this.user_barcode.Name = "user_barcode";
            this.user_barcode.Size = new System.Drawing.Size(208, 31);
            this.user_barcode.TabIndex = 0;
            this.user_barcode.Text = "";
            this.user_barcode.TextChanged += new System.EventHandler(this.ChangeUserBarcode);
            // 
            // book_barcode
            // 
            this.book_barcode.Location = new System.Drawing.Point(226, 278);
            this.book_barcode.Name = "book_barcode";
            this.book_barcode.Size = new System.Drawing.Size(208, 31);
            this.book_barcode.TabIndex = 0;
            this.book_barcode.Text = "";
            this.book_barcode.TextChanged += new System.EventHandler(this.ChangeBookBarcode);
            // 
            // user_data
            // 
            this.user_data.Library = null;
            this.user_data.Location = new System.Drawing.Point(12, 12);
            this.user_data.Multiline = true;
            this.user_data.Name = "user_data";
            this.user_data.ReadOnly = true;
            this.user_data.Size = new System.Drawing.Size(208, 260);
            this.user_data.TabIndex = 1;
            // 
            // book_data
            // 
            this.book_data.Library = null;
            this.book_data.Location = new System.Drawing.Point(226, 12);
            this.book_data.Multiline = true;
            this.book_data.Name = "book_data";
            this.book_data.ReadOnly = true;
            this.book_data.Size = new System.Drawing.Size(208, 260);
            this.book_data.TabIndex = 2;
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(440, 12);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(164, 38);
            this.borrow.TabIndex = 3;
            this.borrow.Text = "대출";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.ClickBorrow);
            // 
            // give_back
            // 
            this.give_back.Location = new System.Drawing.Point(440, 56);
            this.give_back.Name = "give_back";
            this.give_back.Size = new System.Drawing.Size(162, 36);
            this.give_back.TabIndex = 3;
            this.give_back.Text = "반납";
            this.give_back.UseVisualStyleBackColor = true;
            this.give_back.Click += new System.EventHandler(this.ClickGiveBack);
            // 
            // add_day
            // 
            this.add_day.Location = new System.Drawing.Point(440, 236);
            this.add_day.Name = "add_day";
            this.add_day.Size = new System.Drawing.Size(162, 36);
            this.add_day.TabIndex = 3;
            this.add_day.Text = "날짜+";
            this.add_day.UseVisualStyleBackColor = true;
            this.add_day.Click += new System.EventHandler(this.ClickAddDay);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(669, 409);
            this.Controls.Add(this.add_day);
            this.Controls.Add(this.give_back);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.book_data);
            this.Controls.Add(this.user_data);
            this.Controls.Add(this.book_barcode);
            this.Controls.Add(this.user_barcode);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BarcodeScanner user_barcode;
        private Controls.BarcodeScanner book_barcode;
        private Controls.UserDataSheet user_data;
        private Controls.BookDataSheet book_data;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button give_back;
        private System.Windows.Forms.Button add_day;
    }
}

