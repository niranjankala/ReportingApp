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
    
    public partial class KMTeams
    {
        public KMTeams()
        {
            this.KMQCProjects = new HashSet<KMQCProjects>();
            this.KMTeamMembers = new HashSet<KMTeamMembers>();
        }
    
        public System.Guid TeamId { get; set; }
        public System.Guid PlantId { get; set; }
        public string TeamName { get; set; }
        public bool IsActive { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual ICollection<KMQCProjects> KMQCProjects { get; set; }
        public virtual ICollection<KMTeamMembers> KMTeamMembers { get; set; }
    }
}