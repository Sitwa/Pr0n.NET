using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pr0n2.Models;

namespace pr0n2.Controllers
{
    public class CytatyController : Controller
    {
        private CytatyDBContext db = new CytatyDBContext();

        //
        // GET: /Cytaty/

        public ActionResult Index()
        {
            return View(db.Cytat);
        }

        //
        // GET: /Cytaty/Details/5

        public ActionResult Details(int id = 0)
        {
            Cytaty cytaty = db.Cytat.Find(id);
            if (cytaty == null)
            {
                return HttpNotFound();
            }
            return View(cytaty);
        }

        //
        // GET: /Cytaty/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cytaty/Create

        [HttpPost]
        public ActionResult Create(Cytaty cytaty)
        {
            if (ModelState.IsValid)
            {
                db.Cytat.Add(cytaty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cytaty);
        }

        //
        // GET: /Cytaty/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cytaty cytaty = db.Cytat.Find(id);
            if (cytaty == null)
            {
                return HttpNotFound();
            }
            return View(cytaty);
        }

        //
        // POST: /Cytaty/Edit/5

        [HttpPost]
        public ActionResult Edit(Cytaty cytaty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cytaty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cytaty);
        }

        //
        // GET: /Cytaty/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cytaty cytaty = db.Cytat.Find(id);
            if (cytaty == null)
            {
                return HttpNotFound();
            }
            return View(cytaty);
        }

        //
        // POST: /Cytaty/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cytaty cytaty = db.Cytat.Find(id);
            db.Cytat.Remove(cytaty);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}