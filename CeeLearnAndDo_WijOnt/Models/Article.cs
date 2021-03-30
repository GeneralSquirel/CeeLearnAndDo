using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WijOnt.Models
{
    public class Article
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public int ConsultantId { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }
    }
}
