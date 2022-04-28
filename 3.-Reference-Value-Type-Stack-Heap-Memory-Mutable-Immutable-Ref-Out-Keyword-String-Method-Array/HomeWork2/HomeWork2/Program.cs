using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1Main
            //Console.WriteLine("Zehmet olmasa deyer daxil edin");
            //string num1 = Console.ReadLine();
            //int N1 = int.Parse(num1);
            //string num2 = Console.ReadLine();
            //int N2 = int.Parse(num2);
            //string num3 = Console.ReadLine();
            //int N3 = int.Parse(num3);
            //if(N1==N2 || N2==N3 || N1==N3)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //}
            //else 
            //{
            //    Console.WriteLine(AvgPoint(N1, N2, N3));

            //}
            #endregion
            #region Task2Main
            //Console.WriteLine("Zehmet olmasa eded daxil edin");
            //string num = Console.ReadLine();
            //int N =  int.Parse(num) ;
            //if(N<0)
            //{
            //    Console.WriteLine("Duzgun Deyer Daxil Edin");
            //}
            //else 
            //{
            //    Console.WriteLine(SumOfNums(N));
            //}
            #endregion
            #region Task3Main
            Console.WriteLine("Zehmet Olmasa Qiymetleri daxil edin");
            string num1 = Console.ReadLine();
            double N1 = double.Parse(num1);
            string num2 = Console.ReadLine();
            double N2 = double.Parse(num2);
            string num3 = Console.ReadLine();
            double N3 = double.Parse(num3);
            if(N1<0 || N2<0 || N3 < 0) 
            {
                Console.WriteLine("Duzgun Eded Daxil Edin");
            }
            else 
            {
                Console.WriteLine(SumOfPrices(N1, N2, N3));
            }
            #endregion


        }
        #region Task1
        //Task - 1
        //Gonderilmis 3 ededin en boyuyunu tapib qaytaran metod - 3 integer parametr qebul edir ve iclerinde en boyuk hansidirsa onu tapib return edir
        //Eyni sekilde verilmis 4 ve 5 ededin en boyuyunu tapan metodlar da yazin(method overloading)
        static int AvgPoint(int a , int b , int c) 
        {   if (a > b && a > c)
            {
                return a;
            }
            else if (b > c && b > a)
            {
                return b;
            }
            else
            {
                return c;
            }
            
        }
        static int AvgPoint(int a, int b, int c, int d) 
        {
            if (a > b && a > c && a>d)
            {
                return a;
            }
            else if (b > c && b > a && b>d)
            {
                return b;
            }
            else if(c > b && c > a && c>d)
            {
                return c;
            }
            else 
            {
                return d;
            }
        }
        static int AvgPoint(int a, int b, int c, int d , int e) 
        {
            if (a > b && a > c && a > d &&  a>e)
            {
                return a;
            }
            else if (b > c && b > a && b > d && b>e)
            {
                return b;
            }
            else if (c > b && c > a && c > d && c>e)
            {
                return c;
            }
            else if (d > a && d > b && d > c && d>e)
            {
                return d;
            }
            else 
            {
                return e;
            }
            
        }
        #endregion
        #region Task2
        //Task - 2
        //Gonderilmis ededin reqemlerinin cemini qaytaran metod - misalcun bu metodu call ederken arqument olaraq 451 gondersek metoddan geriye 10 qayitmalidir
        static int SumOfNums(int a)
        {
            int Sum = 0;
            while (a>1)
            {
                int f = a % 10;
                a = (a - f) / 10;
                Sum += f;
            }
            return Sum;
        }
        #endregion
        #region Task3
        //Task - 3
        //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir, ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.
        //Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək məbləği hesbalayan metod yazin - yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib qaytarmalidir
        static double SumOfPrices(double a , double b ,double c) 
        { double sum = 0;
            if (a > b && c > b)
            {
                sum = a + c;
            }
            else if (b > a && c > a) 
            {
                sum = b + c;
            }
            else if (a>c && b > c) 
            {
                sum = a + b;
            }
            return sum;
        }

        #endregion
    }
}
