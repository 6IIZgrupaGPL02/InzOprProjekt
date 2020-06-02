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
    public class ReferralsController : Controller
    {
        private DefConnEntities2 db = new DefConnEntities2();

        // GET: Referrals
        public ActionResult Index()
        {
            var referral = db.Referral.Include(r => r.Patient);
            return View(referral.ToList());
        }

        // GET: Referrals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = db.Referral.Find(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            return View(referral);
        }

        // GET: Referrals/Create
        public ActionResult Create()
        {
            ViewBag.IdPatient = new SelectList(db.Patient, "Id", "ImieNazwiskoPesel");
            return View();
        }

        // POST: Referrals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdReferral,IdPatient,Diagnosis,Icd10,NbOfDays,DateReferral,DateSaved,Treatments,Doctor,ReferralCompleted")] Referral referral)
        {
            if (ModelState.IsValid)
            {
                db.Referral.Add(referral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdPatient = new SelectList(db.Patient, "Id", "Pesel", referral.IdPatient);
            return View(referral);
        }

        // GET: Referrals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = db.Referral.Find(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdPatient = new SelectList(db.Patient, "Id", "ImieNazwiskoPesel", referral.IdPatient);
            return View(referral);
        }

        // POST: Referrals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdReferral,IdPatient,Diagnosis,Icd10,NbOfDays,DateReferral,DateSaved,Treatments,Doctor,ReferralCompleted")] Referral referral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdPatient = new SelectList(db.Patient, "Id", "Pesel", referral.IdPatient);
            return View(referral);
        }

        // GET: Referrals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referral referral = db.Referral.Find(id);
            if (referral == null)
            {
                return HttpNotFound();
            }
            return View(referral);
        }

        // POST: Referrals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Referral referral = db.Referral.Find(id);
            db.Referral.Remove(referral);
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
