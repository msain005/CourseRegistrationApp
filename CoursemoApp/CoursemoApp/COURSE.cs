//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoursemoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class COURSE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COURSE()
        {
            this.REGISTRATIONs = new HashSet<REGISTRATION>();
            this.WAITLISTs = new HashSet<WAITLIST>();
        }
    
        public int CRN { get; set; }
        public string Department { get; set; }
        public short CourseNumber { get; set; }
        public string Semester { get; set; }
        public short Year { get; set; }
        public string Type { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public short ClassSize { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REGISTRATION> REGISTRATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WAITLIST> WAITLISTs { get; set; }
    }
}