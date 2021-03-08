using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   public class SepetManager
    {
        public void Add(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi." + urun.UrunAdi);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler sepete eklendi." + urunAdi);
        }
    }
}
