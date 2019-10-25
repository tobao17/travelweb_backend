using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class TOUR
    {
        [Key]
        public int Tour_id { get; set; }
        public int Kind_id { get; set; }
        public string  NameTour { get; set; }

        public string Price { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public string Start_day { get; set; }
        public string Location { get; set; }
        public virtual List<BOOKTOUR>BOOKTOURs { get; set; }
        public virtual KINDTOUR KINDTOUR { get; set; }
        public virtual List<COMMENT>COMMENTs { get; set; }

    }
}