using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class MVCFinalJumpContext : DbContext
    {
        public virtual DbSet<Canopy>Canopy { get; set; }
        public virtual DbSet<Manufacturer>Manufacturer { get; set; }
        public virtual DbSet<Clothing>Clothing { get; set; }

    }
}