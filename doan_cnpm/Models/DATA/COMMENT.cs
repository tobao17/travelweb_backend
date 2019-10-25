using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class COMMENT
    {
        [Key]
       public   int Comment_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public int Tour_id { get; set; }
        public int User_id { get; set; }
        public virtual TOUR TOUR { get; set; }
        public virtual USER KHACHHANG { get; set; }

    }
}