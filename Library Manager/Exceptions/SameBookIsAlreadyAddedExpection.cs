using System;
using System.Collections.Generic;
using System.Text;

namespace Lasthomework.Exceptions
{
    class SameBookIsAlreadyAddedExpection : Exception
    {
        public SameBookIsAlreadyAddedExpection(string ex) : base(ex) { }
    }
}
