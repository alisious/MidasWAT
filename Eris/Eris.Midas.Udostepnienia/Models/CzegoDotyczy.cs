using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Eris.Bazowy;
using Eris.Midas.Udostepnienia.Models.Enums;

namespace Eris.Midas.Udostepnienia.Models
{
    [TableName("CzegoDotyczy")]
    public class CzegoDotyczy : Entity
    {
        public TypDokumentuEnum TypDokumentu { get; private set; }
        public int Rok { get; private set; }
    }
}