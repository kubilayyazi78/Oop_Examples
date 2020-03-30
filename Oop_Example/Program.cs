using System;

namespace Oop_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);

            int[] sayilar = new[] { 1, 2, 3 };
            int[] sayilar2 = new[] { 10, 22, 33 };
            sayilar = sayilar2;

            sayilar2[0] = 100;

            Console.WriteLine(sayilar[1]);
            Console.ReadKey();
        }
    }
}
