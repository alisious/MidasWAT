using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eris.Midas.Udostepnienia.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eris.Midas.Udostepnienia.Testy
{
    [TestClass]
    public class WniosekDaoTesty
    {
        private UdostepnieniaContext _db;

        [TestInitialize]
        public void ResetujUdostepnieniaContext()
        {
            _db = new UdostepnieniaContext("UdostepnieniaContextTestowy");
            UdostepnieniaContextInitializer.InicjijWystapieniaContext(_db);
        }

    }
}
