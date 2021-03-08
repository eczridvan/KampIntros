using System;
using System.ComponentModel;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kurs kurs1 = new Kurs();

            //kurs1.KursAdi = "c#";
            //kurs1.Egitmen = "engin demirog";
            //kurs1.IzlenmeOrani = 54;

            //Kurs kurs2 = new Kurs();
            //kurs2.KursAdi = "java";
            //kurs2.Egitmen = "rıdvan bozkır";
            //kurs2.IzlenmeOrani = 87;

            //Kurs kurs3 = new Kurs();
            //kurs3.KursAdi = "pyhton";
            //kurs3.Egitmen = "oso";
            //kurs3.IzlenmeOrani = 87;
            //kurs3.Tekrar = "TEKRAR YOK";

            //Kurs kurs4 = new Kurs();
            //kurs4.KursAdi = "php";
            //kurs4.Egitmen = " bozkır";
            //kurs4.IzlenmeOrani = 87;
            //kurs4.Ucret = 125;

            //Console.WriteLine("Lütfen bir sayı giriniz?");
            //int sayi = Int32.Parse(Console.ReadLine());

            //int result = sayi < 3 ? sayi * 5 : (((sayi > 3 && sayi < 9) ? sayi * 3 : ((sayi >= 9 && sayi % 2 ==0) ? sayi * 10 :  sayi)));

             
            //Console.WriteLine(result);


            //int bugun =DateTime.Now.Day;



            //switch (bugun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    default:
            //        Console.WriteLine("Pazar");
            //        break;
            //}

            //Console.WriteLine(bugun);

            

           //Console.WriteLine(kurs1.Egitmen + " :" + kurs1.KursAdi);

           //Kurs[] kurslar = new Kurs[]{kurs1, kurs2, kurs3, kurs4};
           //foreach (var kurs in kurslar)
           //{
           //    Console.WriteLine(kurs.KursAdi+ " ***" + kurs.Ucret + "----- " + kurs.Tekrar);
           //}

           Product urun = new Product();
           urun.Name = "bilgisayar";
           urun.Fiyat = 4200;
           urun.StokAdeti = "25";
           urun.Uretici = "hp";

           Product urun2 = new Product();
           urun2.Name = "masa";
           urun2.Fiyat = 120;
           urun2.StokAdeti = "27";
           urun2.Uretici = "bellona";

           Product urun3 = new Product();
           urun3.Name = "yazıcı";
           urun3.Fiyat = 1200;
           urun3.StokAdeti = "874";
           urun3.Uretici = "hp";

           Product urun4 = new Product();
           urun4.Name = "telefon";
           urun4.Fiyat = 2900;
           urun4.StokAdeti = "11";
           urun4.Uretici = "xiaomi";

           Product[] urunler = new[] {urun, urun2, urun3, urun4};

           for (int i = 0; i < urunler.Length; i++)
           {
               Console.WriteLine(urunler[i].Name);
           }

           Console.WriteLine("*/*********/**");
           foreach (var x in urunler)
           {
               Console.WriteLine(x.Name);
           }

           Console.WriteLine("-------------------");
           int value = 0;
           while (value<urunler.Length)
           {
               Console.WriteLine(urunler[value].Name);
               value++;
           }

        }
    }

    class Product
    {
        public string Name { get; set; }
        public decimal Fiyat { get; set; }
        public string KatalogId { get; set; }
        public string Uretici { get; set; }
        public string StokAdeti { get; set; }

    }

  //public class Kurs
  //  {
  //      public string KursAdi { get; set; }
  //      public string Egitmen { get; set; }
  //      public int IzlenmeOrani { get; set; }
  //      public int Ucret { get; set; }
  //      public string Tekrar { get; set; }
  //  }
}
