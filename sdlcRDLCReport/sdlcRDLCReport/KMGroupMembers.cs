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
    
    public partial class KMGroupMembers
    {
        public System.Guid GroupMemberId { get; set; }
        public System.Guid GroupId { get; set; }
        public System.Guid UserId { get; set; }
        public bool IsFollowingGroup { get; set; }
        public bool IsGroupAdmin { get; set; }
        public bool IsGroupOwner { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual KMGroups KMGroups { get; set; }
        public virtual Users Users { get; set; }
        public virtual Users Users1 { get; set; }
        public virtual Users Users2 { get; set; }
    }
}
