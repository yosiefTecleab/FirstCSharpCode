using System;
using System.Collections.Generic;
using System.Text;

namespace FirstCSharpCode
{
    class Book
    {
        private string title;
        public string author;
        public int page;
        public Book(string title, string author, int page)
        {
            this.Title = title;
            this.author = author;
            this.page = page;
        }

        public string Title
        { 
            get{ return title; } 
            set
            {
                title = value;
            } 
        }
    }
}
