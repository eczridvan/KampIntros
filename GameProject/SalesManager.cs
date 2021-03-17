using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager:ISales
    {
        public void Buy(Gamer gamer)
        {
            Console.WriteLine("Oyun satıldı.");
        }
    }
}
