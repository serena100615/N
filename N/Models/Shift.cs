using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace N.Models
{
    public class Shift
    {
       
        [Key]
        public int ShiftId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("日期")]
        public DateTime ClassDate { get; set; }
        [DisplayName("部門")]
        public string DepName { get; set; }
        [DisplayName("早班")]
        public int Early { get; set; }
        [DisplayName("小夜班")]
        public int Lnig { get; set; }
        [DisplayName("大夜班")]
        public int Bnig { get; set; }
    }
}
