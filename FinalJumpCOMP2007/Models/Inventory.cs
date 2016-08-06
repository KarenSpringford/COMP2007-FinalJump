using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalJumpCOMP2007.Models
{
    public class Inventory : DropCreateDatabaseIfModelChanges<MenuEntities>
    {
        protected override void Seed (Canopy context)
        {
            var canopy = new List<Canopy>
            {
                new Canopy { CanopyName = "AeroDyne", CanopyID = 001, ItemPrice = 12000,  ShortDesc="Blah blah blah", ThumbnailURL = "~/Assets/images/AeroDyne.jpg" },
                
            };

            var clothing = new List<Clothing>
            {
                new Clothing { ClothingName = "AeroDyne T-Shirt", clothingID= 1001, ItemPrice =40, ShortDesc="dry fit long sleeved tech shirt", ThumbnailURL="~/Assets/images.shirtAero.jpg" },
        
            };

            new List<Manufacturer>
            {
                new Models.Manufacturer {ManufacturerName="AeroDyne", manufacturerID = 100001 }
            };

        }
    }
}