﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    /// <summary>
    /// 책의 정보를 담은 클래스입니다.
    /// </summary>
    internal class Book
    {
        private string title;
        private string description;
        private string author;
        private string book_code;
        private string barcode;
        private int days;
        private string borrower;

        /// <summary>
        /// 책의 정보를 생성하는 생성자입니다.
        /// </summary>
        /// <param name="title"> 책의 제목입니다. </param>
        /// <param name="description"> 책의 설명입니다. </param>
        /// <param name="author"> 책의 저자입니다. </param>
        /// <param name="book_code"> 책의 식별 코드입니다. </param>
        /// <param name="barcode"> 책의 바코드입니다. </param>
        public Book(string title = "", string description = "", string author = "",
            string book_code = "", string barcode = "")
        {
            this.title = title;
            this.description = description;
            this.author = author;
            this.book_code = book_code;
            this.barcode = barcode;
        }

        /// <summary>
        /// 책의 제목입니다.
        /// </summary>
        public string Title { get => this.title; set => this.title = value; }

        /// <summary>
        /// 책의 설명입니다.
        /// </summary>
        public string Description { get => this.description; set => this.description = value; }
        
        /// <summary>
        /// 책의 저자입니다.
        /// </summary>
        public string Author { get => this.author; set => this.author = value; }
        
        /// <summary>
        /// 책의 식별 코드입니다.
        /// </summary>
        public string BookCode { get => this.book_code; set => this.book_code = value; }

        /// <summary>
        /// 책의 바코드입니다.
        /// </summary>
        public string Barcode { get => this.barcode; set => this.barcode = value; }

        /// <summary>
        /// 현재 책을 빌린 사람의 바코드입니다. 만약 책이 도서관에 있다면 값은 "library"입니다.
        /// </summary>
        public string Borrower { get => this.borrower; set => this.borrower = value; }

        /// <summary>
        /// 책을 빌린 기한이며, 시간이 지날수록 증가합니다. 책이 대출 상태가 아닐 시 -1이 됩니다.
        /// </summary>
        public int Days { get => this.days; set => this.days = value; }
    }
}
