using System;
using System.ComponentModel;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();

            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new[] {urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi+ " " + urun.Fiyati+ " " + urun.Aciklama);
            }

            Console.WriteLine("***********");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(urun1);
            sepetManager.Add(urun2);

            
        }
    }
}
