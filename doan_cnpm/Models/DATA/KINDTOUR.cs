using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class KINDTOUR
    {
        [Key]
        public int Kind_id { get; set; }
        public string Kind_name { get; set; }
        public virtual List<TOUR>TOURs { get; set; }
    }
}