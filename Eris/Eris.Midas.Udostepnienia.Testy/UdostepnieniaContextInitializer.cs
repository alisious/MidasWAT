using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eris.Midas.Udostepnienia.Models;

namespace Eris.Midas.Udostepnienia.Testy
{
    class UdostepnieniaContextInitializer :DropCreateDatabaseAlways<UdostepnieniaContext>
    {
        protected override void Seed(UdostepnieniaContext context)
        {
            //TODO: Inicjowanie niezbęnych składników kontekstu np: słowników 
            base.Seed(context);
        }

        public static void InicjijWystapieniaContext(UdostepnieniaContext db)
        {
            Database.SetInitializer(new UdostepnieniaContextInitializer());
            db.Database.Delete();
            db.Database.Create();
            db.Database.Initialize(true);
        }
    }
}
