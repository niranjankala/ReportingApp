//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sdlcRDLCReport
{
    using System;
    using System.Collections.Generic;
    
    public partial class KMDocumentSubType
    {
        public KMDocumentSubType()
        {
            this.KMSubDocuments = new HashSet<KMSubDocuments>();
        }
    
        public System.Guid DocumentSubTypeID { get; set; }
        public string DocumentSubTypeName { get; set; }
    
        public virtual ICollection<KMSubDocuments> KMSubDocuments { get; set; }
    }
}