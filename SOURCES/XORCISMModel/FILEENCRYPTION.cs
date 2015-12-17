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
    
    public partial class FILEENCRYPTION
    {
        public int FileEncryptionID { get; set; }
        public int FileID { get; set; }
        public int EncryptionID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
    
        public virtual CONFIDENCELEVEL CONFIDENCELEVEL { get; set; }
        public virtual ENCRYPTION ENCRYPTION { get; set; }
        public virtual FILE FILE { get; set; }
    }
}