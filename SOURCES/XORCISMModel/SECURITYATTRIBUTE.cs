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
    
    public partial class SECURITYATTRIBUTE
    {
        public int SecurityAttributeID { get; set; }
        public int SecurityAttributeCategoryID { get; set; }
        public string SecurityAttributeName { get; set; }
        public string data_disclosure { get; set; }
        public Nullable<int> SecurityAttributeStateID { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> durationvalue { get; set; }
        public string durationunit { get; set; }
        public int IncidentID { get; set; }
    
        public virtual SECURITYATTRIBUTECATEGORY SECURITYATTRIBUTECATEGORY { get; set; }
        public virtual SECURITYATTRIBUTESTATE SECURITYATTRIBUTESTATE { get; set; }
    }
}
