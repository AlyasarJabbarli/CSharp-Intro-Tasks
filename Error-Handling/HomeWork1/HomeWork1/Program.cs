using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1Main
            //Console.WriteLine("Zəhmət olmasa Söz Daxil Edin");
            //string word = Console.ReadLine();
            //Console.WriteLine("Zəhmət olmasa Hərf Daxil Edin");
            //string letter = Console.ReadLine();
            //char L = char.Parse(letter);
            //Console.WriteLine(FindCharIndex(word, L));
            #endregion
            #region Task2Main
            //Console.WriteLine("Zehmet olmasa Eded Daxil Edin");
            //string num = Console.ReadLine();
            //int N = int.Parse(num);
            //Console.WriteLine(IsPrime(N));
            #endregion
            #region Task3Main
            int[] points = { 52, 55, 59, 68, 65, 61 };
            CalcAvg(points);
            if (CalcAvg(points) > 60)
            {
                Console.WriteLine("Mezun oldunuz");
            }
            else
            {
                Console.WriteLine("Mezun ola bilmediniz");
            }


            #endregion
        }
        #region Task1
        //    Task - 1
        //FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve gonderilmis char deyeri gonderilmis
        //string deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir.
        //Misal ucun metodu call ederken "alama" ve 'c' deyerlerini gondersek metod bize -1, "alma" ve 'a' deyerlerini gondersek 0 qaytarmalidir
        //Bu metodu Main metodunda call edib isledeceksiniz.Metodu call ederken gondereceyiniz deyerleri Main metodunda
        //console-dan istifadeci daxil etmelidir.

        static int FindCharIndex(string a, char b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    return -1;
                }
            }
            return 0;

            
            

        }
        #endregion
        #region Task2
        //IsPrime metodu - parametr olaraq ineteger value qebul edir. Gonderilims integer deyerin sade olub olmadigini qaytarir.Eded sadedirse true, deyilse false qayitmalidir
        static bool IsPrime(int a)
        {
            int result = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    result++;
                }
            }
            return result == 0 ? true : false;
        }
        #endregion
        #region Task3
        //CalcAvg metodu - Gondeirlmis imtahanlar qiymeti siyahisina(integer array) esasen hemin qiymetlerin ortalamasini qaytaran metod yazin.Main metodunda bu metodu call edib,
        //burdan qayidan deyere esasen ortalama 60-dan boyukdursa console-da "mezun oldunuz" eks halda "mezun ola bilmediniz" yazisi yazdirin
        static int CalcAvg(int[] arr) 
        {
            int count = 0;
            int i = 0;
            int sum = 0;  
            while (i < arr.Length) 
            {
                sum += arr[i];
                i++;
                count++;
            }
            int avg = sum / count;
            return avg;
        }
        #endregion
    }


}
