using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Nurse
    {
        [Key]
        [DisplayName("ID")]
        public string Empid { get; set; }
        [DisplayName("姓名")]
        public string Hecname { get; set; }
        [DisplayName("部門")]
        public string DepName { get; set; }

        public ICollection<Ad> Ads { get; set; }
        public ICollection<Memo> Memos { get; set; }
        public ICollection<State> States { get; set; }
        public ICollection<Work> Works { get; set; }
    }
}
