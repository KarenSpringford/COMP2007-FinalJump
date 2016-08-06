namespace FinalJumpCOMP2007.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FinalJumpContext : DbContext
    {
        public FinalJumpContext()
            : base("name=FinalJumpConnection")
        {
        }

    }
}
