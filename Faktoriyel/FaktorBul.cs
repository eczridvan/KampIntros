using System;
using System.Collections.Generic;
using System.Text;

namespace Faktoriyel
{
    public class FaktorBul
    {
        public int OzyinelemeliFaktoriyel(int sayi)
        {
            if (sayi == 1)
                return sayi;
            else
                return sayi * OzyinelemeliFaktoriyel(sayi - 1);
        }
    }
}
