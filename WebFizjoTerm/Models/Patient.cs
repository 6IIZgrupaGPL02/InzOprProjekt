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

    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Referral = new HashSet<Referral>();
        }

        public int Id { get; set; }
        [Display(Name = "PESEL")]
        public string Pesel { get; set; }
        [Display(Name = "Imi�")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Adres")]
        public string Adress { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [Display(Name = "Pacjent")]
        public string ImieNazwiskoPesel
        {
            get
            {
                return string.Format("{0} {1} {2}", Name, Surname, Pesel);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referral { get; set; }
    }
}
