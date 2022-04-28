using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8.Interfaces
{
    interface IAccount
    {
        bool PasswordChecker(string a);
        void ShowInfo();
    }
}
