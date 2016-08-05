using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Canopie
    {
        //empty constructor
        public Canopie() { }

        //this constructor takes one paramet NAME
        public Canopie(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

    }
}