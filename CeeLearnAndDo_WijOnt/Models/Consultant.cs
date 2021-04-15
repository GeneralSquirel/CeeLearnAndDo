using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WijOnt.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public User User { get; set; }

        [Display(Name = "Consultant")]
        public string UserId { get; set; }

        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }

        [Display(Name = "Informatie")]
        public string Biography { get; set; }

        [Display(Name = "Vakgebied")]
        public string Language { get; set; }
    }
}
