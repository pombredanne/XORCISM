//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PACKAGEINTENT
    {
        public int PackageIntentID { get; set; }
        public string PackageIntentGUID { get; set; }
        public string PackageIntentName { get; set; }
        public string PackageIntentDescription { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromdate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<int> ImportanceID { get; set; }
        public Nullable<int> EnumerationVersionID { get; set; }
    
        public virtual ENUMERATIONVERSION ENUMERATIONVERSION { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}