//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEAM6_CMART
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUPPLIER
    {
        public SUPPLIER()
        {
            this.PRODUCTs = new HashSet<PRODUCT>();
            this.PROPOSED_IMPORT_COUPON = new HashSet<PROPOSED_IMPORT_COUPON>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string house { get; set; }
        public string street { get; set; }
        public string township { get; set; }
        public string city { get; set; }
        public string mobile { get; set; }
    
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
        public virtual ICollection<PROPOSED_IMPORT_COUPON> PROPOSED_IMPORT_COUPON { get; set; }
    }
}