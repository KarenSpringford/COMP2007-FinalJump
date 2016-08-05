using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Canopy
    {
        //empty constructor
        public Canopy() { }

        //this constructor takes one parameter NAME
        public Canopy(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

        public virtual int ID { get; set; }

        [DataType(DataType.Currency)]
        public virtual decimal ItemPrice { get; set; }

        [Display(Name = "Short Description")]
        public virtual string ShortDesc { get; set; }

        [Display(Name = "Thumbnail")]
        public virtual string ThumbnailURL { get; set; }

        public virtual int ItemID { get; set; }


    }
}
