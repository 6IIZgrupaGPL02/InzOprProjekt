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
        private DefConnEntities1 db = new DefConnEntities1();

        // GET: Visits
        [Authorize]
        public ActionResult Index()
        {
            var visit = db.Visit.Include(v => v.Physiotherapist).Include(v => v.Referral).Include(v => v.Report);
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
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email");
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis");
            ViewBag.Report_IdReport = new SelectList(db.Report, "IdReport", "Name");
            return View();
        }

        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdVisit,IdPhysiotherapist,IdReferral,VisitDate,VisitTime,DateSaved,Report_IdReport")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Visit.Add(visit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis", visit.IdReferral);
            ViewBag.Report_IdReport = new SelectList(db.Report, "IdReport", "Name", visit.Report_IdReport);
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
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis", visit.IdReferral);
            ViewBag.Report_IdReport = new SelectList(db.Report, "IdReport", "Name", visit.Report_IdReport);
            return View(visit);
        }

        // POST: Visits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdVisit,IdPhysiotherapist,IdReferral,VisitDate,VisitTime,DateSaved,Report_IdReport")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPhysiotherapist = new SelectList(db.Physiotherapist, "Id", "Email", visit.IdPhysiotherapist);
            ViewBag.IdReferral = new SelectList(db.Referral, "IdReferral", "Diagnosis", visit.IdReferral);
            ViewBag.Report_IdReport = new SelectList(db.Report, "IdReport", "Name", visit.Report_IdReport);
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
