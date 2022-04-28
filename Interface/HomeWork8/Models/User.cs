using HomeWork8.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8.Models
{
    class User : IAccount
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password) 
        {
            Email = email;
            Console.WriteLine(((IAccount)this).PasswordChecker(password));
            while(PasswordChecker(password) == false)
            {
                Console.WriteLine("Zehmet olmasa duzgun sifre daxil edin");
                password = Console.ReadLine();          
            }
            Password = password;


        }

        public bool PasswordChecker(string a)
        {
            if (a.Length >= 8)
            {
                bool checkDigit = false;
                bool checkUpper = false;
                bool checkLower = false;
                foreach (char item in a)
                {
                    if (char.IsDigit(item))
                    {
                        checkDigit = true;
                    }
                    if (char.IsLower(item))
                    {
                        checkLower = true;
                    }
                    if (char.IsUpper(item))
                    {
                        checkUpper = true;
                    }
                }
                if (checkDigit && checkLower && checkUpper == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
            
            
            
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {Fullname}\n Email: {Email}");   
        }
    }
}
