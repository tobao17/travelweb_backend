using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class ADMIN
    {
        [Key]
        public int Admin_id { get; set; }
        public string Pass_admin { get; set; }
        public string Emai_admin { get; set; }
        public string status { get; set; }
    }
}