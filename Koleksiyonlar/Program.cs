﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>{"engin","murat","kerem","halil"};

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler.Add("İlker");
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            List<int> sayilar = new List<int>{1,21,45,5,8,79,7,65,14};

            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}