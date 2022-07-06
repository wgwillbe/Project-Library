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
            this.barcodeScanner1 = new Library.Controls.BarcodeScanner();
            this.bookDataSheet1 = new Library.Controls.BookDataSheet();
            this.userDataSheet1 = new Library.Controls.UserDataSheet();
            this.barcodeScanner2 = new Library.Controls.BarcodeScanner();
            this.borrow1 = new Library.Controls.Borrow();
            this.giveBack1 = new Library.Controls.GiveBack();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Location = new System.Drawing.Point(37, 209);
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.Size = new System.Drawing.Size(143, 50);
            this.barcodeScanner1.TabIndex = 0;
            this.barcodeScanner1.Text = "";
            this.barcodeScanner1.TextChanged += new System.EventHandler(this.barcodeScanner1_TextChanged);
            // 
            // bookDataSheet1
            // 
            this.bookDataSheet1.Library = null;
            this.bookDataSheet1.Location = new System.Drawing.Point(37, 12);
            this.bookDataSheet1.Multiline = true;
            this.bookDataSheet1.Name = "bookDataSheet1";
            this.bookDataSheet1.ReadOnly = true;
            this.bookDataSheet1.Size = new System.Drawing.Size(129, 166);
            this.bookDataSheet1.TabIndex = 1;
            // 
            // userDataSheet1
            // 
            this.userDataSheet1.Library = null;
            this.userDataSheet1.Location = new System.Drawing.Point(191, 17);
            this.userDataSheet1.Multiline = true;
            this.userDataSheet1.Name = "userDataSheet1";
            this.userDataSheet1.ReadOnly = true;
            this.userDataSheet1.Size = new System.Drawing.Size(144, 161);
            this.userDataSheet1.TabIndex = 2;
            // 
            // barcodeScanner2
            // 
            this.barcodeScanner2.Location = new System.Drawing.Point(200, 209);
            this.barcodeScanner2.Name = "barcodeScanner2";
            this.barcodeScanner2.Size = new System.Drawing.Size(135, 38);
            this.barcodeScanner2.TabIndex = 3;
            this.barcodeScanner2.Text = "";
            this.barcodeScanner2.TextChanged += new System.EventHandler(this.barcodeScanner2_TextChanged);
            // 
            // borrow1
            // 
            this.borrow1.Book = null;
            this.borrow1.Library = null;
            this.borrow1.Location = new System.Drawing.Point(404, 26);
            this.borrow1.Name = "borrow1";
            this.borrow1.Size = new System.Drawing.Size(110, 59);
            this.borrow1.TabIndex = 4;
            this.borrow1.Text = "borrow1";
            this.borrow1.User = null;
            this.borrow1.UseVisualStyleBackColor = true;
            // 
            // giveBack1
            // 
            this.giveBack1.Book = null;
            this.giveBack1.Library = null;
            this.giveBack1.Location = new System.Drawing.Point(404, 118);
            this.giveBack1.Name = "giveBack1";
            this.giveBack1.Size = new System.Drawing.Size(97, 41);
            this.giveBack1.TabIndex = 5;
            this.giveBack1.Text = "giveBack1";
            this.giveBack1.User = null;
            this.giveBack1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giveBack1);
            this.Controls.Add(this.borrow1);
            this.Controls.Add(this.barcodeScanner2);
            this.Controls.Add(this.userDataSheet1);
            this.Controls.Add(this.bookDataSheet1);
            this.Controls.Add(this.barcodeScanner1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.BarcodeScanner barcodeScanner1;
        private Controls.BookDataSheet bookDataSheet1;
        private Controls.UserDataSheet userDataSheet1;
        private Controls.BarcodeScanner barcodeScanner2;
        private Controls.Borrow borrow1;
        private Controls.GiveBack giveBack1;
        private System.Windows.Forms.Button button1;
    }
}

