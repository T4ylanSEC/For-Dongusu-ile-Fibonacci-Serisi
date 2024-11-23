using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_ile_Fibonacci_Serisi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Bir Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz.");
                return;
            }


            int a = 0, b = 1;

            Console.Write("Fibonacci Serisi: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;      
                a = b;                 
                b = temp;              
            }

            Console.ReadKey();

        }

    }
}