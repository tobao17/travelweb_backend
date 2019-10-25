using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class CONTACT
    {
        [Key]
        public int contact_id { get; set; }
        public string content { get; set; }
        public string status { get; set; }

    }
}