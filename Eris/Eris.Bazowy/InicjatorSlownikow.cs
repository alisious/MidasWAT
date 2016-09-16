using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Bazowy
{
    public static class InicjatorSlownikow
    {
        public static IList<StopienWojskowy> Stopnie
        {
            get
            {
                return new List<StopienWojskowy>
                {
                    new StopienWojskowy{Id = 1,Nazwa = "BRAK"},
                    new StopienWojskowy{Id = 2,Nazwa = "CYW."},
                    new StopienWojskowy{Id = 3,Nazwa = "PW"},
                    new StopienWojskowy{Id = 4,Nazwa = "SZER."},
                    new StopienWojskowy{Id = 5,Nazwa = "ST.SZER."},
                    new StopienWojskowy{Id = 6,Nazwa = "PPOR."},
                    new StopienWojskowy{Id = 7,Nazwa = "POR."},
                    new StopienWojskowy{Id = 8,Nazwa = "PPŁK"},
                    new StopienWojskowy{Id = 9,Nazwa = "PŁK"},
                    new StopienWojskowy{Id = 10,Nazwa = "GEN."}
                };
            }
        }
        
    }
}
