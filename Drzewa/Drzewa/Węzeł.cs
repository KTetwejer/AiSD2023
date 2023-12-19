using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewa
{
    internal class Węzeł
    {
        public int wartość;
        public List<Węzeł> dzieci = new();

        public Węzeł(int liczba)
        {
            this.wartość = liczba;
        }
        public void Add(Węzeł w)
        {
            this.dzieci.Add(w);
            w.dzieci.Add(this);
        }
    }

    public class Węzeł3
    {
        public int wartość;
        public Węzeł3? rodzic;
        public Węzeł3? leweDziecko;
        public Węzeł3? praweDziecko;
        public Węzeł3(int liczba)
        {
            this.wartość = liczba;

        }
        public override string ToString()
        {
            return this.wartość.ToString();
        }

        internal void Add(int liczba)
        {
            var dziecko = new Węzeł3(liczba);
            dziecko.rodzic = this;
            if (liczba < this.wartość)
            {
                this.leweDziecko = dziecko;
            }
            else
            {
                this.praweDziecko = dziecko;
            }
        }

        public int GetLiczbaDzieci()
        {
            int wynik = 0;
            if (this.leweDziecko != null)
            {
                wynik++;
            }

            if(this.praweDziecko != null)
            {
                wynik++;
            }

            return wynik;
        }
    }

    public class DrzewoBinarne
    {
        public Węzeł3? korzeń;
        public DrzewoBinarne(int liczba)
        {
            this.korzeń = new Węzeł3(liczba);
        }

        private void Add(int liczba)
        {
            Węzeł3 rodzic = this.ZnajdzRodzica(liczba);
            rodzic.Add(liczba);
        }

        private Węzeł3 ZnajdzRodzica(int liczba)
        {
            var w = this.korzeń;
            while (true)
            {
                if (liczba < w.wartość)
                {
                    if (w.leweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.leweDziecko;
                    }
                }
                else
                {
                    if (w.praweDziecko == null)
                    {
                        return w;
                    }
                    else
                    {
                        w = w.praweDziecko;
                    }
                }
            }
        }

        private Węzeł3? Znajdz(int liczba)
        {
            var w = this.korzeń;
            
            while (true)
            {
                if (liczba == w.wartość)
                {
                    return w;
                }

                if (liczba < w.wartość)
                {

                    if (w.leweDziecko != null)
                    {
                        w = w.leweDziecko;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        private Węzeł3 ZnajdzMin(Węzeł3 w)
        {
            while (w.leweDziecko != null)
            {
                w = w.leweDziecko;
            }

            return w;
        }

        private Węzeł3 ZnajdzMax(Węzeł3 w)
        {
            while (w.praweDziecko != null)
            {
                w = w.praweDziecko;
            }

            return w;
        }

        private Węzeł3 Następnik(Węzeł3 w)
        {
            if (w.praweDziecko != null)
            {
                return this.ZnajdzMin(w.praweDziecko);
            }
                
            while(w.rodzic != null)
            {
                if (w.rodzic.leweDziecko == w)
                {
                    return w.rodzic;
                }

                w = w.rodzic;
            }

            return null;
        }

        private Węzeł3 UsunGdy0(Węzeł3 w)
        {
            if (w.rodzic == null)
            {
                this.korzeń = null;
                return w;
            }

            if(w.rodzic.leweDziecko == w)
            {
                w.rodzic.leweDziecko = null;
            }
            else
            {
                w.rodzic.praweDziecko = null;
            }

            w.rodzic = null;
            return w;
        }

        private Węzeł3 UsunGdy1(Węzeł3 w)
        {
            Węzeł3 dziecko = null;
            if (w.leweDziecko != null)
            {
                dziecko = w.leweDziecko;
                w.leweDziecko = null;
            }
            else
            {
                dziecko = w.praweDziecko;
                w.praweDziecko = null;
            }

            if (w.rodzic == null)
            {
                this.korzeń = dziecko;
            }
            else
            {
                if (w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = dziecko;
                }
                else
                {
                    w.rodzic.praweDziecko = dziecko;
                }

                w.rodzic = null;
            }

            return w;
        }

        private Węzeł3 UsunGdy2(Węzeł3 w)
        {
            Węzeł3 zamiennik = this.Następnik(w);
            zamiennik = this.Remove(zamiennik);
            if(w.leweDziecko != null)
            {
                zamiennik.leweDziecko = w.leweDziecko;
                w.leweDziecko.rodzic = zamiennik;
                w.leweDziecko = null;
            }

            if(w.rodzic == null)
            {
                this.korzeń = zamiennik;
            }
            else
            {
                if(w.rodzic.leweDziecko == w)
                {
                    w.rodzic.leweDziecko = zamiennik;
                }
                else
                {
                    w.rodzic.praweDziecko = zamiennik;
                }
                zamiennik.rodzic = w.rodzic;
                w.rodzic = null;
            }
            return w;
        }

        private Węzeł3 Remove(Węzeł3 w)
        {
            switch (w.GetLiczbaDzieci())
            {
                case 0:
                    w = this.UsunGdy0(w);
                    break;
                case 1:
                    w = this.UsunGdy1(w);
                    break;
                case 2:
                    w = this.UsunGdy2(w);
                    break;
            }

            return w;
        }
    }

    }
/*klasa Graf 
            listaWęzłów
            listaKrawędzi
klasa Krawędź
        waga
        początek
        koniec
klasa Węzeł
        wartość
        lista krawędzi*/

