using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VapeStore.Models;

namespace VapeStore.Controllers
{
    public class JuicesController : Controller
    {
        private VapeStoreDBEntities db = new VapeStoreDBEntities();

        // GET: Juices
        public ActionResult Index()
        {
            return View(db.Juices.ToList());
        }

        // GET: Juices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juice juice = db.Juices.Find(id);
            if (juice == null)
            {
                return HttpNotFound();
            }
            return View(juice);
        }

        // GET: Juices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JuiceName,JuiceID,Brand")] Juice juice)
        {
            if (ModelState.IsValid)
            {
                db.Juices.Add(juice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(juice);
        }

        // GET: Juices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juice juice = db.Juices.Find(id);
            if (juice == null)
            {
                return HttpNotFound();
            }
            return View(juice);
        }

        // POST: Juices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JuiceName,JuiceID,Brand")] Juice juice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(juice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(juice);
        }

        // GET: Juices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Juice juice = db.Juices.Find(id);
            if (juice == null)
            {
                return HttpNotFound();
            }
            return View(juice);
        }

        // POST: Juices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Juice juice = db.Juices.Find(id);
            db.Juices.Remove(juice);
            db.SaveChanges();
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
