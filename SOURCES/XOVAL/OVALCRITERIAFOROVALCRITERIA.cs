//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOVALModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class OVALCRITERIAFOROVALCRITERIA
    {
        public int OVALCriteriaRelationshipID { get; set; }
        public int OVALCriteriaRefID { get; set; }
        public string RelationshipName { get; set; }
        public int OVALCriteriaSubjectID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<int> CriteriaRank { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual OVALCRITERIA OVALCRITERIA { get; set; }
        public virtual OVALCRITERIA OVALCRITERIA1 { get; set; }
    }
}