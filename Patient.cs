//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalManagament
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public long Id { get; set; }
        public string Disease { get; set; }
        public string Occupation { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.TimeSpan> EntryTime { get; set; }
    
        public virtual User User { get; set; }
        public virtual Caregiver Caregiver { get; set; }
    }
}
