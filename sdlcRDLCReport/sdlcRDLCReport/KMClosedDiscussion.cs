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
    
    public partial class KMClosedDiscussion
    {
        public System.Guid ClosedDiscussionId { get; set; }
        public System.Guid RefId { get; set; }
        public string MessageContent { get; set; }
        public System.Guid PostedBy { get; set; }
        public System.DateTime PostedOn { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual KMMessage KMMessage { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
    }
}
