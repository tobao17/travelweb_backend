using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace doan_cnpm.Models.DATA
{
    public class TRAVELCONTEXT :DbContext
    {
        public DbSet <ABOUT>ABOUT { get; set; }
        public DbSet <ADMIN>ADMIN { get; set; }

        public DbSet <BLOG> BLOG { get; set; }
        public DbSet <BOOKTOUR>BOOKTOUR { get; set; }
        public DbSet <COMMENT>COMMENT { get; set; }
        public DbSet <CONTACT>CONTACT { get; set; }
        public DbSet <FEEDBACK>FEEDBACK { get; set; }
        public DbSet<USER>USER { get; set; }
        public DbSet <KINDTOUR>KINDTOUR { get; set; }
        public DbSet<TOUR>TOUR { get; set; }




    }
}