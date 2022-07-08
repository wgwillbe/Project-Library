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
            this.book_data1 = new Library.Controls.BookDataSheet();
            this.borrow = new System.Windows.Forms.Button();
            this.give_back = new System.Windows.Forms.Button();
            this.add_day = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.book_tab = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.page2 = new System.Windows.Forms.TabPage();
            this.book_data2 = new Library.Controls.BookDataSheet();
            this.page3 = new System.Windows.Forms.TabPage();
            this.book_data3 = new Library.Controls.BookDataSheet();
            this.label = new System.Windows.Forms.Label();
            this.book_tab.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.page3.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_barcode
            // 
            this.user_barcode.Location = new System.Drawing.Point(12, 281);
            this.user_barcode.Name = "user_barcode";
            this.user_barcode.Size = new System.Drawing.Size(208, 31);
            this.user_barcode.TabIndex = 0;
            this.user_barcode.Text = "";
            this.user_barcode.TextChanged += new System.EventHandler(this.ChangeUserBarcode);
            // 
            // book_barcode
            // 
            this.book_barcode.Location = new System.Drawing.Point(230, 281);
            this.book_barcode.Name = "book_barcode";
            this.book_barcode.Size = new System.Drawing.Size(208, 31);
            this.book_barcode.TabIndex = 0;
            this.book_barcode.Text = "";
            this.book_barcode.TextChanged += new System.EventHandler(this.ChangeBookBarcode);
            // 
            // user_data
            // 
            this.user_data.Library = null;
            this.user_data.Location = new System.Drawing.Point(12, 37);
            this.user_data.Multiline = true;
            this.user_data.Name = "user_data";
            this.user_data.ReadOnly = true;
            this.user_data.Size = new System.Drawing.Size(208, 238);
            this.user_data.TabIndex = 1;
            // 
            // book_data1
            // 
            this.book_data1.Library = null;
            this.book_data1.Location = new System.Drawing.Point(0, 0);
            this.book_data1.Multiline = true;
            this.book_data1.Name = "book_data1";
            this.book_data1.ReadOnly = true;
            this.book_data1.Size = new System.Drawing.Size(208, 238);
            this.book_data1.TabIndex = 2;
            // 
            // borrow
            // 
            this.borrow.Location = new System.Drawing.Point(444, 34);
            this.borrow.Name = "borrow";
            this.borrow.Size = new System.Drawing.Size(163, 38);
            this.borrow.TabIndex = 3;
            this.borrow.Text = "대출";
            this.borrow.UseVisualStyleBackColor = true;
            this.borrow.Click += new System.EventHandler(this.ClickBorrow);
            // 
            // give_back
            // 
            this.give_back.Location = new System.Drawing.Point(444, 78);
            this.give_back.Name = "give_back";
            this.give_back.Size = new System.Drawing.Size(163, 36);
            this.give_back.TabIndex = 3;
            this.give_back.Text = "반납";
            this.give_back.UseVisualStyleBackColor = true;
            this.give_back.Click += new System.EventHandler(this.ClickGiveBack);
            // 
            // add_day
            // 
            this.add_day.Location = new System.Drawing.Point(444, 236);
            this.add_day.Name = "add_day";
            this.add_day.Size = new System.Drawing.Size(163, 36);
            this.add_day.TabIndex = 3;
            this.add_day.Text = "날짜+";
            this.add_day.UseVisualStyleBackColor = true;
            this.add_day.Click += new System.EventHandler(this.ClickAddDay);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(444, 194);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(163, 36);
            this.Save.TabIndex = 3;
            this.Save.Text = "저장";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.ClickSave);
            // 
            // book_tab
            // 
            this.book_tab.Controls.Add(this.page1);
            this.book_tab.Controls.Add(this.page2);
            this.book_tab.Controls.Add(this.page3);
            this.book_tab.Location = new System.Drawing.Point(226, 10);
            this.book_tab.Name = "book_tab";
            this.book_tab.SelectedIndex = 0;
            this.book_tab.Size = new System.Drawing.Size(216, 269);
            this.book_tab.TabIndex = 4;
            // 
            // page1
            // 
            this.page1.Controls.Add(this.book_data1);
            this.page1.Location = new System.Drawing.Point(4, 25);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(208, 240);
            this.page1.TabIndex = 0;
            this.page1.Text = "도서 1";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.book_data2);
            this.page2.Location = new System.Drawing.Point(4, 25);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(208, 236);
            this.page2.TabIndex = 1;
            this.page2.Text = "도서 2";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // book_data2
            // 
            this.book_data2.Library = null;
            this.book_data2.Location = new System.Drawing.Point(0, 0);
            this.book_data2.Multiline = true;
            this.book_data2.Name = "book_data2";
            this.book_data2.ReadOnly = true;
            this.book_data2.Size = new System.Drawing.Size(208, 238);
            this.book_data2.TabIndex = 3;
            // 
            // page3
            // 
            this.page3.Controls.Add(this.book_data3);
            this.page3.Location = new System.Drawing.Point(4, 25);
            this.page3.Name = "page3";
            this.page3.Padding = new System.Windows.Forms.Padding(3);
            this.page3.Size = new System.Drawing.Size(208, 236);
            this.page3.TabIndex = 2;
            this.page3.Text = "도서 3";
            this.page3.UseVisualStyleBackColor = true;
            // 
            // book_data3
            // 
            this.book_data3.Library = null;
            this.book_data3.Location = new System.Drawing.Point(0, 0);
            this.book_data3.Multiline = true;
            this.book_data3.Name = "book_data3";
            this.book_data3.ReadOnly = true;
            this.book_data3.Size = new System.Drawing.Size(208, 238);
            this.book_data3.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 15);
            this.label.TabIndex = 5;
            this.label.Text = "이용자";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(619, 327);
            this.Controls.Add(this.label);
            this.Controls.Add(this.book_tab);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.add_day);
            this.Controls.Add(this.give_back);
            this.Controls.Add(this.borrow);
            this.Controls.Add(this.user_data);
            this.Controls.Add(this.book_barcode);
            this.Controls.Add(this.user_barcode);
            this.Font = new System.Drawing.Font("굴림", 11F);
            this.Name = "MainForm";
            this.book_tab.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page3.ResumeLayout(false);
            this.page3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BarcodeScanner user_barcode;
        private Controls.BarcodeScanner book_barcode;
        private Controls.UserDataSheet user_data;
        private Controls.BookDataSheet book_data1;
        private System.Windows.Forms.Button borrow;
        private System.Windows.Forms.Button give_back;
        private System.Windows.Forms.Button add_day;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TabControl book_tab;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.TabPage page3;
        private Controls.BookDataSheet book_data2;
        private Controls.BookDataSheet book_data3;
        private System.Windows.Forms.Label label;
    }
}

