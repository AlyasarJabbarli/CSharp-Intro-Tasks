using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Models
{
    static class ExtentionMethods
    {
        public static bool IsEven(int a) 
        {
            if (a % 2 == 0) 
            {
                return true;
            }
            return false;

        }
        public static int[] GetValueIndexes(int a) 
        {
            int[] newarr = new int[0];
            int[] arr = {5,23,324,5,3243,6778,43,31,5 };
            int index = -1;

            foreach (int item in arr)
            {
                if(a == item) 
                {
                    Array.Resize(ref newarr, newarr.Length + 1);
                    index++;
                    newarr[newarr.Length - 1] = index;
                }
            }
            return newarr;
            
            
        }
        public static bool IsOdd(int a)
        {
            if (a % 2 == 0)
            {
                return false;
            }
            return true;

        }
        public static bool IsContainsDigit(string stringtest)
        {
            bool checkdigit = false;
            foreach (char item in stringtest)
            {
                if (char.IsDigit(item))
                {
                    checkdigit = true;
                }
                if (checkdigit)
                {
                    return true;
                }
            }
            if (!checkdigit)
            {
                return false;
            }
            return true;

        }
        public static int[] GetValueIndexes(char a) 
        {
            string b = "asddsfadfasf";
            int[] newarr = new int[0];
            int index = -1;
            foreach (char item in b)
            {               
                if (a == item)
                {
                    Array.Resize(ref newarr, newarr.Length + 1);
                    index++;
                    newarr[newarr.Length - 1] = index;
                }             
            }
            return newarr;
        }
    }
}
