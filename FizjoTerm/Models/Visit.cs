﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TabMenu2.Models
{
    /// <summary>
    /// Klasa reprezentująca dane wizyty
    /// </summary>
    [Table("Visit")]
    public class Visit

    {
        [Key]
        public int IdVisit { get; set; }

        [ForeignKey("Physiotherapist")]
        public int IdPhysiotherapist { get; set; }
        [ForeignKey("Referral")]
        public int IdReferral { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public DateTime DateSaved { get; set; }
        public bool VisitCompleted { get; set; }
        public bool VisitSettled { get; set; }
        public virtual Physiotherapist Physiotherapist { get; set; }
        public virtual Referral Referral { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

        public Visit() { }
        public Visit(Physiotherapist physio, Referral referral, DateTime date, string time, bool visitCompleted = false, bool visitSettled = false)
        {
            this.Physiotherapist = physio;
            this.Referral = referral;
            this.VisitDate = date;
            this.VisitTime = time;
            this.DateSaved = DateTime.Now;
            this.VisitCompleted = visitCompleted;
            this.VisitSettled = visitSettled;
        }

        public static void AddVisit(Physiotherapist physio, Referral referral, DateTime date, string time, ApplicationDbContext dbcontext)
        {
            Visit vis = new Visit(physio, referral, date, time);
            try
            {
                dbcontext.Visits.Add(vis);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteVisit(Visit vis, ApplicationDbContext dbcontext)
        {
            try
            {
                dbcontext.Visits.Remove(vis);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static IEnumerable<Visit> SearchVisit(Patient patient, Physiotherapist physio, DateTime? selDate, ApplicationDbContext dbcontext)
        {

            //Visit w = dbcontext.Visits.Local.Where(ww => ww.IdVisit == 36) as Visit;
            //DateTime dt = DateTime.Now;
            //MessageBox.Show(selDate.Value.ToShortDateString() + " " + dt.ToShortDateString());
            IEnumerable <Visit> results = dbcontext.Visits.Local.Where(v => (patient != null ? v.Referral.Patient.Equals(patient) : true) && (physio != null ? v.Physiotherapist.Equals(physio) : true) && (selDate != null ? v.VisitDate.Equals(selDate) : true));
            return results;
        }

        public override string ToString()
        {
            if(VisitCompleted)
            return VisitDate.ToShortDateString() + " " + VisitTime + "\t" +  Referral.Patient.ToString() + "\t" + Physiotherapist + "\t- zrealizowana";
            else
            return VisitDate.ToShortDateString() + " " + VisitTime + "\t" + Referral.Patient.ToString() + "\t" + Physiotherapist + "\t- niezrealizowana";
        }
    }
}
