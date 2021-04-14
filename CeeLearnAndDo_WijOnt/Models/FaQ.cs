using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeeLearnAndDo_WijOnt.Models
{
    public class FaQ
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime CreationTime { get; set; }
        public User User { get; set; }

    }
}
