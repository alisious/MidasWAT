using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Bazowy
{
    public abstract class Entity 
    {
        protected Entity()
        {
            DataUtworzenia = DateTime.Now;
        }


        [Display(Name="ID obiektu: ")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name="Data utworzenia: ")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true, NullDisplayText = "", ConvertEmptyStringToNull = true)]
        public DateTime DataUtworzenia { get; protected set; }

    }
}
