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
    
    public partial class FIXACTIONPATCH
    {
        public int FixActionPatchID { get; set; }
        public Nullable<int> FixActionID { get; set; }
        public string FixActionGUID { get; set; }
        public string FixActionPatchRelationship { get; set; }
        public string FixActionPatchDescription { get; set; }
        public Nullable<int> PatchID { get; set; }
        public string PatchGUID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual FIXACTION FIXACTION { get; set; }
        public virtual PATCH PATCH { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
    }
}
