using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Eris.Bazowy;
using Eris.Midas.Udostepnienia.Models.Enums;

namespace Eris.Midas.Udostepnienia.Models
{
    [TableName("Wnioski")]
    public class Wniosek : Entity
    {
        #region Attribute

        [Required]
        [StringLength(50)]
        [EnumDataType(typeof(JednostkaOrg))]
        [Display(Name = "Instytucja wnioskująca")]
        public JednostkaOrg Kto { get;  set; }

        [Required]
        [StringLength(50)]
        [EnumDataType(typeof(JednostkaOrg))]
        [Display(Name = "Instytucja docelowa")]
        public JednostkaOrg DlaKogo { get;  set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Dokument z wnioskiem")]
        public string Dokument { get;  set; }

        [Required]
        [EnumDataType(typeof(SposobNadeslaniaEnum))]
        [Display(Name = "Sposob nadesłania")]
        public SposobNadeslaniaEnum SposobNadeslania { get;  set; }

        [Required]
        [Display(Name = "Nr wniosku zewnetrzy")]
        public string NrWychodzacy { get;  set; }

        [Required]
        [Display(Name = "Data nadania")]
        [DataType(DataType.Date)]
        public DateTime DataNadania { get;  set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nr kancelaryjny")]
        public string NrWchodzacy { get;  set; }

        [Required]
        [Display(Name = "Data rejestracji")]
        [DataType(DataType.Date)]
        public DateTime DataRejestracji { get;  set; }

        [Required]
        [EnumDataType(typeof(StanWnioskuEnum))]
        [Display(Name = "Stan wniosku")]
        public StanWnioskuEnum StanWniosku { get;  set; }

        [Required]
        [Display(Name = "Lista osob")]
        public List<KogoDotyczy> ListaOsob { get;  set; }

        #endregion

        public Wniosek(List<KogoDotyczy> listaOsob, StanWnioskuEnum stanWniosku, DateTime dataRejestracji, JednostkaOrg dlaKogo, JednostkaOrg kto, string nrWchodzacy, DateTime dataNadania, string nrWychodzacy, string dokument, SposobNadeslaniaEnum sposobNadeslania)
        {
            ListaOsob = listaOsob;
            StanWniosku = stanWniosku;
            DataRejestracji = dataRejestracji;
            DlaKogo = dlaKogo;
            Kto = kto;
            NrWchodzacy = nrWchodzacy;
            DataNadania = dataNadania;
            NrWychodzacy = nrWychodzacy;
            Dokument = dokument;
            SposobNadeslania = sposobNadeslania;
        }


    }
}