using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Węzeł
    {
        public int wartość;
        public List<Węzeł> dzieci = new();

        public Węzeł(int liczba)
        {
            this.wartość = liczba;
        }
    }
}
