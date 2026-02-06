using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mthree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n را وارد کنید: ");
            int n = int.Parse(Console.ReadLine());

            PrintMultiplesOfThree(n - 1); // از n-1 شروع می‌کنیم چون باید کوچکتر از n باشد
            Console.ReadKey();
        }




        static void PrintMultiplesOfThree(int n)
        {
            // شرط پایان بازگشت
            if (n < 3)
                return;

            // اگر n مضرب 3 است، چاپش می‌کنیم
            if (n % 3 == 0)
                Console.WriteLine(n);

            // حرکت به عدد کوچکتر
            PrintMultiplesOfThree(n - 1);
        }
    }
}
