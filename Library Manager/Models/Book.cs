using Lasthomework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lasthomework.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public Genres Genre { get; set; }

        public Book(string name, string author, int pagecount, Genres genre)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Name: {Name.ToUpper()}\n" +
                $"Author: {Author.ToUpper()}\n" +
                $"Page count: {PageCount}\n" +
                $"Genre: {Genre.ToString().Replace('_', ' ')}";
        }
    }
}
