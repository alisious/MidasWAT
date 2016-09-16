using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Eris.Bazowy;

namespace Eris.Midas.Udostepnienia.Models
{
    [TableName("KogoDotyczy")]
    public class KogoDotyczy : Entity
    {
        [Required]
        [StringLength(50)]
        public string Imie { get; private set; }
        [Required]
        public string Nazwisko { get; private set; }
        [Required]
        public string Pesel { get; private set; }
        public string MiejscePracy { get; private set; }

        [Required]
        public List<CzegoDotyczy> Dokumenty { get; private set; }
    }
}