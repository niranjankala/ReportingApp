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
    
    public partial class KMEmailNotification
    {
        public KMEmailNotification()
        {
            this.KMUserEmailNotification = new HashSet<KMUserEmailNotification>();
        }
    
        public System.Guid EmailNotificationId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ActionText { get; set; }
        public bool IsAllowed { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string DisplayTextController { get; set; }
        public Nullable<int> DisplaySequence { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual ICollection<KMUserEmailNotification> KMUserEmailNotification { get; set; }
    }
}
