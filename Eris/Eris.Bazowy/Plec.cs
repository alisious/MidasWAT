using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Bazowy
{
    public class Plec : PozycjaSlownika
    {
        public Plec()
        {

        }

        public Plec(int id, string nazwa)
            : base(id, nazwa)
        {

        }

        public static List<Plec> Lista
        {
            get
            {
                return new List<Plec> { new Plec(0, "M"), new Plec(1, "K") };
            }
        }
    }
}
