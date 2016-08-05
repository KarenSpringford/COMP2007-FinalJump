using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Item
    {
        //empty constructor
        public Item() { }

        //constructor returns 1 parameter Manufacturer
        public Item(string Manufacturer)
        {
            this.Manufacturer = Manufacturer;
        }
        public virtual string Manufacturer { get; set; }
        public virtual string Name { get; set; }

    }
}