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
        public Item(string ItemName)
        {
            this.ItemName = ItemName;
        }
        public virtual string ItemName { get; set; }
     
    }
}