using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Item
    {
        //empty constructor
        public Item() { }

        //constructoer returns 1 parameter Manufacturer
        public Item(string Manufacturer)
        {
            this.Manufacturer = Manufacturer;
        }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public Canopy Canopie { get; set; }

    }
}