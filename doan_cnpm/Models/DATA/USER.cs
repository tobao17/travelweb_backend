using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class USER
    {
        [Key]
        public int User_id { get; set; }

        public string user_name { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Identity { get; set; }
        public string Phone { get; set; }

        public virtual List<BOOKTOUR> BOOKTOURs { get; set; }
        public virtual List<COMMENT> COMMENTs { get; set; }



    }
}