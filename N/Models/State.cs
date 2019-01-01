using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class State
    {
        [Key]
        [DisplayName("流水編號")]
        public int StateID { get; set; }
        [DisplayName("員工編號")]
        public string Empid { get; set; }
        [DisplayName("狀態")]
        public string Title { get; set; }
        [DisplayName("支援部門")]
        public string SupportDep { get; set; }
        [DisplayName("原因")]
        public string Reason { get; set; }
        [DisplayName("時間(小時)")]
        public float Time { get; set; }

        public Nurse Nurse { get; set; }
    }
}
