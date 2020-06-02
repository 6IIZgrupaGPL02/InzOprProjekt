using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FizjoTermWeb.Models;

namespace FizjoTermWeb.Controllers
{
    public class PhysiotherapistsController : Controller
    {
        private DefConnEntities db = new DefConnEntities();

        // GET: Physiotherapists
        public ActionResult Index()
        {
            return View(db.Physiotherapist.ToList());
        }

        // GET: Physiotherapists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Physiotherapist physiotherapist = db.Physiotherapist.Find(id);
            if (physiotherapist == null)
            {
                return HttpNotFound();
            }
            return View(physiotherapist);
        }

        // GET: Physiotherapists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Physiotherapists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Npwz,Name,Surname,Adress,Phone")] Physiotherapist physiotherapist)
        {
            if (ModelState.IsValid)
            {
                db.Physiotherapist.Add(physiotherapist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(physiotherapist);
        }

        // GET: Physiotherapists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Physiotherapist physiotherapist = db.Physiotherapist.Find(id);
            if (physiotherapist == null)
            {
                return HttpNotFound();
            }
            return View(physiotherapist);
        }

        // POST: Physiotherapists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Npwz,Name,Surname,Adress,Phone")] Physiotherapist physiotherapist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(physiotherapist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(physiotherapist);
        }

        // GET: Physiotherapists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Physiotherapist physiotherapist = db.Physiotherapist.Find(id);
            if (physiotherapist == null)
            {
                return HttpNotFound();
            }
            return View(physiotherapist);
        }

        // POST: Physiotherapists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Physiotherapist physiotherapist = db.Physiotherapist.Find(id);
            db.Physiotherapist.Remove(physiotherapist);
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
