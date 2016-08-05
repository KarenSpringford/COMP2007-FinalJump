using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalJumpCOMP2007.Models;

namespace FinalJumpCOMP2007.Controllers
{
    public class CanopiesController : Controller
    {
        private MVCFinalJumpContext db = new MVCFinalJumpContext();

        // GET: Canopies
        public async Task<ActionResult> Index()
        {
            return View(await db.Canopy.ToListAsync());
        }

        // GET: Canopies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canopy canopy = await db.Canopy.FindAsync(id);
            if (canopy == null)
            {
                return HttpNotFound();
            }
            return View(canopy);
        }

        // GET: Canopies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Canopies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CanopyID,Name,ItemPrice,ShortDesc,ThumbnailURL")] Canopy canopy)
        {
            if (ModelState.IsValid)
            {
                db.Canopy.Add(canopy);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(canopy);
        }

        // GET: Canopies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canopy canopy = await db.Canopy.FindAsync(id);
            if (canopy == null)
            {
                return HttpNotFound();
            }
            return View(canopy);
        }

        // POST: Canopies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CanopyID,Name,ItemPrice,ShortDesc,ThumbnailURL")] Canopy canopy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(canopy).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(canopy);
        }

        // GET: Canopies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Canopy canopy = await db.Canopy.FindAsync(id);
            if (canopy == null)
            {
                return HttpNotFound();
            }
            return View(canopy);
        }

        // POST: Canopies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Canopy canopy = await db.Canopy.FindAsync(id);
            db.Canopy.Remove(canopy);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
