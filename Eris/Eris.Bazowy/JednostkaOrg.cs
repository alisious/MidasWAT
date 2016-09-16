using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Eris.Bazowy
{
    
    public class JednostkaOrg :ValueObject
    {
        public JednostkaOrg()
        {
            Kod = "";
            MozeRealizowacZlecenia = false;
        }
        [Display(Name = "Nazwa: ")]
        [MaxLength(100)]
        [Required(AllowEmptyStrings = false)]
        public string Nazwa { get; set; }

        [Display(Name = "Kod: ")]
        [MaxLength(3)]
        [Required(AllowEmptyStrings = true)]
        public string Kod { get; set; }

        [Display(Name = "Może realizować zlecenia: ")]
        public bool MozeRealizowacZlecenia { get; set; }

    }

    public static class InicjatorJednostekOrg
    {
        public static IList<JednostkaOrg> Lista {
            get
            {
                return new List<JednostkaOrg>
                {
                    new JednostkaOrg{Id = 1,Nazwa = "JEDNOSTKA 1",Kod="JE1",MozeRealizowacZlecenia = true},
                    new JednostkaOrg{Id = 2,Nazwa = "JEDNOSTKA 2",Kod="JE2",MozeRealizowacZlecenia = true},
                    new JednostkaOrg{Id = 3,Nazwa = "JEDNOSTKA 3",Kod="JE3",MozeRealizowacZlecenia = true},
                    new JednostkaOrg{Id = 4,Nazwa = "JEDNOSTKA 4"},
                    new JednostkaOrg{Id = 5,Nazwa = "JEDNOSTKA 5"},
                    new JednostkaOrg{Id = 6,Nazwa = "JEDNOSTKA 6"},
                    new JednostkaOrg{Id = 7,Nazwa = "JEDNOSTKA 7"},
                    new JednostkaOrg{Id = 8,Nazwa = "JEDNOSTKA 8"},
                    new JednostkaOrg{Id = 9,Nazwa = "JEDNOSTKA 9"},
                    new JednostkaOrg{Id = 10,Nazwa = "JEDNOSTKA 10"},
                };
            }
        }
    }
}