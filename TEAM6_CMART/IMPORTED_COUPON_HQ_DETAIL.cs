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
    
    public partial class IMPORTED_COUPON_HQ_DETAIL
    {
        public string imcouphqid { get; set; }
        public string productid { get; set; }
        public int price { get; set; }
        public System.DateTime date { get; set; }
        public int amount { get; set; }
        public string status { get; set; }
    
        public virtual IMPORTED_COUPON_HQ IMPORTED_COUPON_HQ { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
