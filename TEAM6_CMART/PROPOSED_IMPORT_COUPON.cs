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
    
    public partial class PROPOSED_IMPORT_COUPON
    {
        public PROPOSED_IMPORT_COUPON()
        {
            this.IMPORTED_COUPON_HQ = new HashSet<IMPORTED_COUPON_HQ>();
            this.PROPOSED_IMPORT_COUPON_DETAIL = new HashSet<PROPOSED_IMPORT_COUPON_DETAIL>();
        }
    
        public string id { get; set; }
        public string supplierid { get; set; }
        public string accountid { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual ICollection<IMPORTED_COUPON_HQ> IMPORTED_COUPON_HQ { get; set; }
        public virtual ICollection<PROPOSED_IMPORT_COUPON_DETAIL> PROPOSED_IMPORT_COUPON_DETAIL { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
