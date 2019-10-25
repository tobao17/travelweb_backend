using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class BOOKTOUR
    {
        [Key]
        public int Booktour_id { get; set; }

        public string Datetime { get; set;}
        public int User_id { get; set; }

        public virtual List<USER>KHACHHANGs { get; set; }
        public virtual List<TOUR>TOURs { get; set; }
    }
}