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
        public string Index()
        {
            return "THIS IS INSANE from Store.Index()";
        }
        //
        // GET: /Store/Browse?canopies=AeroDyne
        public string Browse(string canopies)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Canopies = " + canopies);
            return message;
        }

        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var item = new Item();
            item.Manufacturer = "Manufacturer " + id;
            return View(item);
        }
    }
}