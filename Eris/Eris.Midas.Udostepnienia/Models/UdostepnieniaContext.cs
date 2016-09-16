using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Eris.Bazowy;

namespace Eris.Midas.Udostepnienia.Models
{
    public class UdostepnieniaContext :BazowyErisContext
    {
        public DbSet<Wniosek> Wnioski { get;  set; }
        public DbSet<KogoDotyczy> KogoDotyczy { get;  set; }
        public DbSet<CzegoDotyczy> CzegoDotyczy { get;  set; }


        public UdostepnieniaContext(string nazwaBazy) : base(nazwaBazy)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Wniosek>().ToTable("Wnioski");
            modelBuilder.Entity<KogoDotyczy>().ToTable("KogoDotyczy");
            modelBuilder.Entity<CzegoDotyczy>().ToTable("CzegoDotyczy"); 
        }
    }
}