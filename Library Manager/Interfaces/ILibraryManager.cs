using Lasthomework.Enums;
using Lasthomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lasthomework.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        List<Book> Search(string input);
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Filter(string author, Genres genre);
    }
}
