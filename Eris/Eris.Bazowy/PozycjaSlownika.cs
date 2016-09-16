using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Bazowy
{
    public class PozycjaSlownika :ValueObject
    {

        public PozycjaSlownika()
        {
            Grupa = "";
        }

        public PozycjaSlownika(int id,string nazwa)
        {
            Id = id;
            Nazwa = nazwa;
            Grupa = "";
        }

        public PozycjaSlownika(int id,string nazwa,string grupa)
        {
            Id = id;
            Nazwa = nazwa;
            Grupa = grupa;

        }

        [Display(Name = "Nazwa: ")]
        [Required(AllowEmptyStrings = false)]
        [MaxLength(100)]
        public string Nazwa { get; set; }

        [Display(Name = "Nazwa grupy: ")]
        [MaxLength(100)]
        public string Grupa { get; set; }
    }
}
