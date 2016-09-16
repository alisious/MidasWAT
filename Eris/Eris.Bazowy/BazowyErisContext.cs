using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Eris.Bazowy
{
    public class BazowyErisContext :DbContext
    {

        public BazowyErisContext(string nazwaBazy) :base(nazwaBazy)
        {
            
        }

        public DbSet<JednostkaOrg> JednostkiOrg { get; set; }
        public DbSet<StopienWojskowy> StopnieWojskowe { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));

            modelBuilder.Entity<JednostkaOrg>().ToTable("JednostkiOrg");
            modelBuilder.Entity<StopienWojskowy>().ToTable("StopnieWojskowe");
        }


        //Metody wspólne

        public SelectList ListaWyboruJednostek(int selectedId = 0)
        {
            return new SelectList(JednostkiOrg, "Id", "Nazwa", selectedId);
        }

        public JednostkaOrg JednostkaOrg(int id)
        {
            return JednostkiOrg.FirstOrDefault(j => j.Id == id);
        }

        public SelectList ListaWyboru<T>(int selectedId = 0) where T : PozycjaSlownika
        {

            return new SelectList(Set<T>().AsEnumerable(), "Id", "Nazwa", selectedId);

        }

        public SelectList ListaWyboruPlci(string plec)
        {
            return new SelectList(Plec.Lista, "Nazwa", "Nazwa", plec);
        }

        public T ElementSlownika<T>(int id) where T : PozycjaSlownika
        {
            return Set<T>().FirstOrDefault(e => e.Id == id);
        }

        public StopienWojskowy Stopien(int id)
        {
            return ElementSlownika<StopienWojskowy>(id);
        }
    }
}
