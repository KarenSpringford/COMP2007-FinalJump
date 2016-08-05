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
    public class ClothingsController : Controller
    {
        private MVCFinalJumpContext db = new MVCFinalJumpContext();

        // GET: Clothings
        public async Task<ActionResult> Index()
        {
            return View(await db.Clothing.ToListAsync());
        }

        // GET: Clothings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothing clothing = await db.Clothing.FindAsync(id);
            if (clothing == null)
            {
                return HttpNotFound();
            }
            return View(clothing);
        }

        // GET: Clothings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clothings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "clothingID,Name,ItemPrice,ShortDesc,ThumbnailURL")] Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                db.Clothing.Add(clothing);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clothing);
        }

        // GET: Clothings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothing clothing = await db.Clothing.FindAsync(id);
            if (clothing == null)
            {
                return HttpNotFound();
            }
            return View(clothing);
        }

        // POST: Clothings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "clothingID,Name,ItemPrice,ShortDesc,ThumbnailURL")] Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clothing).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(clothing);
        }

        // GET: Clothings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothing clothing = await db.Clothing.FindAsync(id);
            if (clothing == null)
            {
                return HttpNotFound();
            }
            return View(clothing);
        }

        // POST: Clothings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Clothing clothing = await db.Clothing.FindAsync(id);
            db.Clothing.Remove(clothing);
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
