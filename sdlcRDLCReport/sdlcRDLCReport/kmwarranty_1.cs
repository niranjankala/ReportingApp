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
    
    public partial class kmwarranty_1
    {
        public System.Guid WarrantyID { get; set; }
        public System.Guid MessageID { get; set; }
        public System.Guid PlantId { get; set; }
        public Nullable<System.Guid> FieldClaimID { get; set; }
        public System.Guid CustomerID { get; set; }
        public string PartNumber { get; set; }
        public string CustomerVehicle { get; set; }
        public System.DateTime CountermeasureImpDate { get; set; }
        public string CountermeasureDesc { get; set; }
        public Nullable<System.DateTime> KMSClosureDate { get; set; }
        public string AdditionalInformation { get; set; }
        public System.Guid ModifiedBy { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public System.Guid CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
    }
}