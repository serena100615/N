using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Ad
    {
        [Key]
        public string Empid { get; set; }
        public string Password { get; set; }

        public Nurse Nurse { get; set; }
    }
}
