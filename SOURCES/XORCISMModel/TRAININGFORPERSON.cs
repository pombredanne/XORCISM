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
    
    public partial class TRAININGFORPERSON
    {
        public int TrainingPersonID { get; set; }
        public int PersonID { get; set; }
        public int TrainingID { get; set; }
    
        public virtual PERSON PERSON { get; set; }
        public virtual TRAINING TRAINING { get; set; }
    }
}
