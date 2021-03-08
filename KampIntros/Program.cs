using System;

namespace KampIntros
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYaptıMı = false;
            //if (sistemeGirisYaptıMı == true)
            //{
            //    Console.WriteLine("Kullanıcı giriş yaptı");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap");
            //}

            double dolarDun = 7.25;
            double dolarBugun = 7.17;
            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("dolar azaldı");
            }
            else if (dolarBugun> dolarDun)
            {
                Console.WriteLine("dolar arttı");
            }
            else
            {
                Console.WriteLine("dolar değişmedi.");
            }
        }
    }
}
