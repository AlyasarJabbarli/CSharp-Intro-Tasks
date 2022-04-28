using System;
using System.Collections.Generic;
using System.Text;

namespace Lasthomework.Exceptions
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string ex) : base(ex) { }
    }
}
