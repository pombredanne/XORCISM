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
    
    public partial class WASCFORCAPEC
    {
        public int WASCForCAPECID { get; set; }
        public int WASCID { get; set; }
        public string WASCRefID { get; set; }
        public Nullable<int> AttackPatternID { get; set; }
        public string capec_id { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<int> RepositoryID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual REPOSITORY REPOSITORY { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        public virtual WASC WASC { get; set; }
    }
}