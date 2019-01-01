using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Memo
    {
        [Key]
        [DisplayName("填表人")]
        public string Empid { get; set; }
        [DisplayName("主旨")]
        public string Title { get; set; }
        [DisplayName("內容")]
        public string Memos { get; set; }

        public Nurse Nurse { get; set; }
       
    }
}
