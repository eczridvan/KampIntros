using System;

namespace Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        { 
            FaktorBul faktorBul = new FaktorBul();

            int result = faktorBul.OzyinelemeliFaktoriyel(6);
            
            Console.WriteLine(result);
        }
    }
}
