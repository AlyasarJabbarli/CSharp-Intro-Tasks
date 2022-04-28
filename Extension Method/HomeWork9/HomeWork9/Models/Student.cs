using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Models
{
    class Student
    {
        private string _fullname;
        public string FullName 
        {   get=> _fullname;
            set
            {
                while (!(_fullname == value))
                {

                    bool checkwhitespace = false;
                    bool checkupper1 = false;
                    bool checkupper2 = false;
                    int a = 0;

                    while (!checkwhitespace)
                    {
                        foreach (char item in value)
                        {
                            if (char.IsWhiteSpace(item))
                            {
                                checkwhitespace = true;
                                a = value.IndexOf(item);
                            }
                        }
                        if (!checkwhitespace) 
                        {    
                            Console.WriteLine("Zehmet olmasa Adiniz ve Soyadiniz arasinda bosluq buraxin");
                            value = Console.ReadLine();     
                        }
                    }
                    if (char.IsUpper(value[0]))
                    {
                        checkupper1 = true;
                    }
                    if (char.IsUpper(value[a + 1]))
                    {
                        checkupper2 = true;
                    }
                    if (checkupper1 && checkupper2)
                    {
                        _fullname = value;
                    }
                    else
                    {
                        Console.WriteLine("Zehmet olmasa Adinizin ve Soyadinizin ilk herfini boyuk herfle yazin");
                        value = Console.ReadLine();
                    }
                }
                
            } 
        }
        private string _groupno;
        public string GroupNo 
        { 
            get=>_groupno;
            set 
            {   while (!(_groupno == value))
                {
                    if (value.Length == 4)
                    {
                        bool checkupper = false;
                        if (char.IsUpper(value[0]))
                        {
                            checkupper = true;
                        }
                        if (!checkupper)
                        {
                            Console.WriteLine("Qrup nomresi Boyuk herfle baslamalidir.Zehmet olmasa Duzgun Daxil Edin");
                            value = Console.ReadLine();
                        }
                        else
                        {
                            int countdigit = 0;

                            foreach (char item in value)
                            {
                                if (char.IsDigit(item))
                                {
                                    countdigit += 1;
                                }
                            }
                            if (countdigit == 3 && checkupper)
                            {
                                _groupno = value;
                            }
                            else
                            {
                                Console.WriteLine("Qrup nomresinde 3 reqem olmalidir.Zehmet olmasa Duzgun Daxil Edin");
                                value = Console.ReadLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Qrup nomresi 4 deyerden ibaret olmalidir.Zehmet olmasa Duzgun Daxil Edin");
                        value = Console.ReadLine();
                    }
                }
               
               

            }
        }
        public int Age { get; set; }
        public Student(string fullname , string groupno, int age)
        {
            FullName = fullname;
            GroupNo = groupno;
            Age = age;
            Console.WriteLine(CheckGroupNo(GroupNo));
            Console.WriteLine(CheckFullname(FullName));

        }
        public static bool CheckGroupNo(string Groupno)
        {
            if (Groupno.Length == 4)
            {
                bool checkupper = false;
                if (char.IsUpper(Groupno[0]))
                {
                    checkupper = true;
                }
                if (!checkupper)
                {
                    return false;
                }
                else
                {
                    int countdigit = 0;

                    foreach (char item in Groupno)
                    {
                        if (char.IsDigit(item))
                        {
                            countdigit += 1;
                        }
                    }
                    if (countdigit == 3 && checkupper)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            return false;
        }
        public static bool CheckFullname(string Fullname)
        {
            bool checkwhitespace = false;
            bool checkupper1 = false;
            bool checkupper2 = false;
            int a = 0;
            foreach (char item in Fullname)
            {
                if (char.IsWhiteSpace(item))
                {
                    checkwhitespace = true;
                    a = Fullname.IndexOf(item);
                }
            }
            if (!checkwhitespace)
            {
                return false;
            }
            if (char.IsUpper(Fullname[0]))
            {
                checkupper1 = true;
            }
            if (char.IsUpper(Fullname[a + 1]))
            {
                checkupper2 = true;
            }
            if (checkupper1 && checkupper2)
            {
                return true;            
            }
            else
            {
                return false;
            }

        }



    }
}
