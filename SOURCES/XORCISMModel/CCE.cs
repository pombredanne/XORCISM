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
    
    public partial class CCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CCE()
        {
            this.CCEFORASSET = new HashSet<CCEFORASSET>();
            this.CCEFORCPE = new HashSet<CCEFORCPE>();
            this.CCEFORTHREATACTORTTP = new HashSet<CCEFORTHREATACTORTTP>();
            this.CCEPARAMETERFORCCE = new HashSet<CCEPARAMETERFORCCE>();
            this.CCEREFERENCEFORCCE = new HashSet<CCEREFERENCEFORCCE>();
            this.CCETECHNICALMECHANISMFORCCE = new HashSet<CCETECHNICALMECHANISMFORCCE>();
            this.PLATFORMFORCCE = new HashSet<PLATFORMFORCCE>();
            this.RECOMMENDATIONCCE = new HashSet<RECOMMENDATIONCCE>();
        }
    
        public int CCEID { get; set; }
        public string cce_id { get; set; }
        public string platform { get; set; }
        public Nullable<int> PlatformID { get; set; }
        public Nullable<System.DateTimeOffset> modified { get; set; }
        public string description { get; set; }
        public string parameter { get; set; }
        public string technical_mechanism { get; set; }
        public string reference { get; set; }
        public string resource_id { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public string CreationObjectGUID { get; set; }
        public Nullable<int> SourceID { get; set; }
        public string SourceGUID { get; set; }
        public Nullable<int> RepositoryID { get; set; }
        public string RepositoryGUID { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string VocabularyGUID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ImportanceID { get; set; }
        public string ImportanceGUID { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public string ConfidenceLevelGUID { get; set; }
        public Nullable<int> ConfidenceReasonID { get; set; }
        public string ConfidenceReasonGUID { get; set; }
        public Nullable<int> TrustLevelID { get; set; }
        public string TrustLevelGUID { get; set; }
        public Nullable<int> TrustReasonID { get; set; }
        public string TrustReasonGUID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual CONFIDENCEREASON CONFIDENCEREASON { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual IMPORTANCE IMPORTANCE { get; set; }
        public virtual PLATFORM PLATFORM1 { get; set; }
        public virtual REPOSITORY REPOSITORY { get; set; }
        public virtual TRUSTLEVEL TRUSTLEVEL { get; set; }
        public virtual TRUSTREASON TRUSTREASON { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEFORASSET> CCEFORASSET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEFORCPE> CCEFORCPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEFORTHREATACTORTTP> CCEFORTHREATACTORTTP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEPARAMETERFORCCE> CCEPARAMETERFORCCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCEREFERENCEFORCCE> CCEREFERENCEFORCCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCETECHNICALMECHANISMFORCCE> CCETECHNICALMECHANISMFORCCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMFORCCE> PLATFORMFORCCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECOMMENDATIONCCE> RECOMMENDATIONCCE { get; set; }
    }
}
