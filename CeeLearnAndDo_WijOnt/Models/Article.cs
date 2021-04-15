using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WijOnt.Models
{
    public class Article
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Display(Name = "Datum")]
        public DateTime CreationDate { get; set; }
        [Display(Name = "Inhoud")]
        public string Content { get; set; }
    }
}
