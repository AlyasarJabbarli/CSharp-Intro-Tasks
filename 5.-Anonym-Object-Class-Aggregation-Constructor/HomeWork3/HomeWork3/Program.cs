using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int[] array ={ 1, 0, 6, 7, 5, 9 };
            //CustomSort(array);
            #endregion
            #region Task2
            string[] array = { "Hello", "World", "Code", "Academy", "University", "College" };
            char char1 = 'o';
            FindChar(array, char1);
            #endregion

        }
        #region Task1
        //        Task - 1
        //Ədədlərdən ibarət array qəbul edən method yazın.Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.

        static void CustomSort(int[] arr) 
        {
            //int x;
            //for (int i = 0; i < arr.Length - 1; i++)

            //    for (int j = i + 1; j < arr.Length; j++)
            //        if (arr[i] < arr[j])
            //        {

            //            x = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = x;
            //        }
            //foreach (int value in arr)
            //{
            //    Console.Write(value + " ");
            //}
        }
        #endregion
        #region Task2
        //        Task - 2
        //Stringlerden ibaret array-i və char qəbul edən metod yazın.Arrdayin hansi index-ə bu qəbul edilən char varsa, o string-ləri ekranda yazdirin
        static void FindChar(string[] arr, char b)
        { 
        }


        #endregion

    }
}
