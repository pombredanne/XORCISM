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
    
    public partial class PLATFORM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLATFORM()
        {
            this.APIPLATFORM = new HashSet<APIPLATFORM>();
            this.ASSETPLATFORM = new HashSet<ASSETPLATFORM>();
            this.CCE = new HashSet<CCE>();
            this.CPEFORPLATFORM = new HashSet<CPEFORPLATFORM>();
            this.EXPLOITPLATFORM = new HashSet<EXPLOITPLATFORM>();
            this.OSFAMILYPLATFORM = new HashSet<OSFAMILYPLATFORM>();
            this.PLATFORMFORCCE = new HashSet<PLATFORMFORCCE>();
            this.PLATFORMFORTECHNICALCONTEXT = new HashSet<PLATFORMFORTECHNICALCONTEXT>();
            this.PLATFORMMAPPING = new HashSet<PLATFORMMAPPING>();
            this.PLATFORMMAPPING1 = new HashSet<PLATFORMMAPPING>();
            this.PLATFORMTAG = new HashSet<PLATFORMTAG>();
            this.PRODUCTPLATFORM = new HashSet<PRODUCTPLATFORM>();
            this.MEASURESOURCE = new HashSet<MEASURESOURCE>();
            this.PLATFORMSPECIFICATIONIDENTIFIERS = new HashSet<PLATFORMSPECIFICATIONIDENTIFIERS>();
        }
    
        public int PlatformID { get; set; }
        public string PlatformGUID { get; set; }
        public string PlatformName { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public string PlatformDescription { get; set; }
        public string structuring_format { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APIPLATFORM> APIPLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSETPLATFORM> ASSETPLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CCE> CCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CPEFORPLATFORM> CPEFORPLATFORM { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPLOITPLATFORM> EXPLOITPLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OSFAMILYPLATFORM> OSFAMILYPLATFORM { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMFORCCE> PLATFORMFORCCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMFORTECHNICALCONTEXT> PLATFORMFORTECHNICALCONTEXT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMMAPPING> PLATFORMMAPPING { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMMAPPING> PLATFORMMAPPING1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMTAG> PLATFORMTAG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTPLATFORM> PRODUCTPLATFORM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MEASURESOURCE> MEASURESOURCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLATFORMSPECIFICATIONIDENTIFIERS> PLATFORMSPECIFICATIONIDENTIFIERS { get; set; }
    }
}
