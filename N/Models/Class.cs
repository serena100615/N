using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Class
    {
        [Key]
        public string ClassId { get; set; }
        public string Classes { get; set; }
        public int Cstime { get; set; }
        public int Cetime { get; set; }

        public ICollection<Work> Works { get; set; }
    }
}
