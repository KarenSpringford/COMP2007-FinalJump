using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalJumpCOMP2007.Models;


namespace FinalJumpCOMP2007.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var canopy = new List<Canopy>
            {
                new Canopy (" Main" ),
                new Canopy (" Reserve" ),
                new Canopy (" Used" ),
                new Canopy (" Rectangle"),
                new Canopy (" Circle" )
            };

            return View(canopy);
            
        }
        //
        // GET: /Store/Browse?canopies=AeroDyne
        public ActionResult Browse(string canopy)
        {
            var canopyModel = new Canopy(canopy);
            return View(canopyModel);
        }

        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            var canopy = new Canopy("Manufacturer " + id);
            
            return View(canopy);
        }
    }
}