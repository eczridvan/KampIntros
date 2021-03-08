using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslarim = new[] {"yazılım geliştirme", "phyton", "java", "angular"};

            string[] projeler = new[] {"farmakit","orbikey"};



            foreach (var kurs in kurslarim)
            {
                Console.WriteLine(kurs);
            }

            for (int i = 0; i < projeler.Length; i ++)
            {
                Console.WriteLine(projeler[i]);
                Console.WriteLine("--*****");
            }
        }
    }
}
