﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DefConnEntities2 : DbContext
    {
        public DefConnEntities2()
            : base("name=DefConnEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Physiotherapist> Physiotherapist { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
    }
}
