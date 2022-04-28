using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10._03._2022.Models
{
    class Book
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int count = 0;
        public Book(string name, string authorname , int pagecount)
        {
            count++;
            Name = name.Trim().ToUpper();
            AuthorName = authorname.Trim().ToUpper();
            PageCount = pagecount;
            Code = Name.Substring(0, 1) + count;
        }
    }
}
