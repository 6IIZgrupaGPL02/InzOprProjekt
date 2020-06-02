using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebFizjoTerm.Models;

namespace WebFizjoTerm.Controllers
{
    public class VisitsController : Controller
    {
        private DefConnEntities2 db = new DefConnEntities2();

        // GET: Visits
        public ActionResult Index()
        {
            var visit = db.Visit.Include(v => v.Physiotherapist).Include(v => v.Referral);
            return View(visit.ToList());
        }

        // GET: Visits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.Visit.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // GET: Visits/Create
        public ActionResult Create()
        {
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "NameSurname");
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Patient.ImieNazwiskoPesel");
            return View();
        }

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVisit,IdPhysiotherapist,IdReferral,VisitDate,VisitTime,DateSaved,VisitCompleted,VisitSettled")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Visit.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis", visit.IdReferral);
            return View(visit);
        }

        // GET: Visits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.Visit.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "NameSurname", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Patient.ImieNazwiskoPesel", visit.IdReferral);
            return View(visit);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVisit,IdPhysiotherapist,IdReferral,VisitDate,VisitTime,DateSaved,VisitCompleted,VisitSettled")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis", visit.IdReferral);
            return View(visit);
        }

        // GET: Visits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visit visit = db.Visit.Find(id);
            if (visit == null)
            {
                return HttpNotFound();
            }
            return View(visit);
        }

        // POST: Visits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visit visit = db.Visit.Find(id);
            db.Visit.Remove(visit);
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
