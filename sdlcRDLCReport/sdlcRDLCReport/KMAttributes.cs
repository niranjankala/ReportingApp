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
    
    public partial class KMAttributes
    {
        public KMAttributes()
        {
            this.KMMessage = new HashSet<KMMessage>();
            this.KMMessage1 = new HashSet<KMMessage>();
        }
    
        public System.Guid AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual ICollection<KMMessage> KMMessage { get; set; }
        public virtual ICollection<KMMessage> KMMessage1 { get; set; }
    }
}