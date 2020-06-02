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
    
    public partial class Visit
    {
        public int IdVisit { get; set; }
        public int IdPhysiotherapist { get; set; }
        public int IdReferral { get; set; }
        public System.DateTime VisitDate { get; set; }
        public string VisitTime { get; set; }
        public System.DateTime DateSaved { get; set; }
        public Nullable<int> Report_IdReport { get; set; }
    
        public virtual Physiotherapist Physiotherapist { get; set; }
        public virtual Referral Referral { get; set; }
        public virtual Report Report { get; set; }
    }
}