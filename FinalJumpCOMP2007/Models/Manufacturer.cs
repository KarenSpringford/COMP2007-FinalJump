using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Manufacturer
    {
        //empty constructor
        public Manufacturer() { }

        //constructor returns 1 parameter Manufacturer
        public Manufacturer(string Manufacturer)
        {
            this.ManufacturerName = Manufacturer;
        }
        public virtual string ManufacturerName { get; set; }
        
        public int manufacturerID { get; set; }

    }
}