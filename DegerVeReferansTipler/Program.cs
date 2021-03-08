using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 25;
            sayi1 = sayi2;
            sayi2 = 38;
            Console.WriteLine(sayi1);
            Console.WriteLine("********");

            int[] sayilar1 = new[] {10, 20, 30};
            int[] sayilar2 = new[] {100, 200, 300};

            sayilar1 = sayilar2;
            sayilar2[0] = 888;
            Console.WriteLine(sayilar1[0]);

        }
    }
}
