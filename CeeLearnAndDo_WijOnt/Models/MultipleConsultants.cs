using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WijOnt.Models
{
    public class MultipleConsultants
    {
        public Consultant Consultants { get; set; }
        public List<Consultant> RelatedConsultants { get; set; }
    }
}
