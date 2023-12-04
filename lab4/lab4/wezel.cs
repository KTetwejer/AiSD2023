using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Wezel
    {
        public int wartosc;
        public List<Wezel> dzieci = new();

        public Wezel(int liczba)
        {
            this.wartosc = liczba;
        }
    }
}
