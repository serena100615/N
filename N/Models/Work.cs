using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Work
    {
        [Key]
        [DisplayName("員工編號")]
        public string Empid { get; set; }
        public string Hecname { get; set; }
        public string DepName { get; set; }
        public string ClassId { get; set; }
        public int Cstime { get; set; }
        public string Present { get; set; }
        public string Reason { get; set; }
        

        public Class Class { get; set; }
       
    }
}
