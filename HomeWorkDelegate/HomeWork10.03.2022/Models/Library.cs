using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HomeWork10._03._2022.Delegates;

namespace HomeWork10._03._2022.Models
{
    class Library
    {
        List<Book> books = new List<Book>();
        public List<Book> ProcessOnAllBooksByName(string value ,Check check)
        {
            List<Book> names = new List<Book>();

            foreach (Book book in books)
            {
                if (check(value))
                {
                    names.Add(book);
                }
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Kitab tapilmadi");
            }
            return names;
        }
        public List<Book> RemoveAllBooksByName(string value)
        {
            foreach (Book book in books)
            {
                if (book.Name.Contains(value.Trim().ToUpper()))
                {
                    books.Remove(book);
                }
            }
            if (books.Count == 0)
            {
                Console.WriteLine("Daxil etdiyiniz adda kitab tapilmadi");
            }
            return books;
        }
        public List<Book> FindAllBooksByPageCountRange(int a ,int b)
        {
            List<Book> names = new List<Book>();

            foreach (Book book in books)
            {
                if (a<book.PageCount && b>book.PageCount)
                {
                    names.Add(book);
                }
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Daxil etdiyiniz parametrde kitab tapilmadi");
            }
            return names;
        }
        public List<Book> RemoveByNo(string value)
        {
            foreach (Book book in books)
            {
                if (book.Code == value.Trim().ToUpper())
                {
                    books.Remove(book);
                }
            }
            if (books.Count == 0)
            {
                Console.WriteLine("Sizin kitab siyahiniz bosdur");
            }
            return books;
        }
        public bool FindByName(string value) 
        {
            foreach (Book book in books)
            {
                return book.Name.Contains(value.Trim().ToUpper());
            }
            return false;
        }
        public bool Search(string value)
        {
            foreach (Book book in books)
            {
                return book.Name.Contains(value.Trim().ToUpper()) || book.AuthorName.Contains(value.Trim().ToUpper());
            }
            return false;
        }
        



    }
}
