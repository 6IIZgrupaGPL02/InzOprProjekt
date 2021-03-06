//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFizjoTerm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Visit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visit()
        {
            this.Report = new HashSet<Report>();
        }

        public int IdVisit { get; set; }
        [Display(Name = "Fizjoterapeuta")]
        public int IdPhysiotherapist { get; set; }
        [Display(Name = "Pacjent")]
        public int IdReferral { get; set; }
        [Display(Name = "Data wizyty")]
        [DataType(DataType.Date)]
        public System.DateTime VisitDate { get; set; }
        [Display(Name = "Godzina wizyty")]
        public string VisitTime { get; set; }
        [Display(Name = "Data zapisu")]
        [DataType(DataType.Date)]
        public System.DateTime DateSaved { get; set; }
        [Display(Name = "Wizyta zrealizowana")]
        public bool VisitCompleted { get; set; }
        [Display(Name = "Wizyta rozliczona")]
        public bool VisitSettled { get; set; }
    
        public virtual Physiotherapist Physiotherapist { get; set; }
        public virtual Referral Referral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Report { get; set; }
    }
}
