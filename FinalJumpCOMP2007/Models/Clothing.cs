﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Clothing
    {
        public int clothingID { get; set; }
        public virtual string ClothingName { get; set; }

        [DataType(DataType.Currency)]
        public virtual decimal ItemPrice { get; set; }

        [Display(Name = "Short Description")]
        public virtual string ShortDesc { get; set; }

        [Display(Name = "Thumbnail")]
        public virtual string ThumbnailURL { get; set; }
    }
}