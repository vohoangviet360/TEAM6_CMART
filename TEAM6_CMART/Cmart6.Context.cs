﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMART6Entities : DbContext
    {
        public CMART6Entities()
            : base("name=CMART6Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public DbSet<BILL> BILLs { get; set; }
        public DbSet<BILL_DETAIL> BILL_DETAIL { get; set; }
        public DbSet<HISTORICAL_PRICE> HISTORICAL_PRICE { get; set; }
        public DbSet<IMPORTED_COUPON_BR> IMPORTED_COUPON_BR { get; set; }
        public DbSet<IMPORTED_COUPON_BR_DETAIL> IMPORTED_COUPON_BR_DETAIL { get; set; }
        public DbSet<IMPORTED_COUPON_HQ> IMPORTED_COUPON_HQ { get; set; }
        public DbSet<IMPORTED_COUPON_HQ_DETAIL> IMPORTED_COUPON_HQ_DETAIL { get; set; }
        public DbSet<PRODUCT> PRODUCTs { get; set; }
        public DbSet<PRODUCT_TYPE> PRODUCT_TYPE { get; set; }
        public DbSet<PROMO_INFO> PROMO_INFO { get; set; }
        public DbSet<PROPOSED_IMPORT_COUPON> PROPOSED_IMPORT_COUPON { get; set; }
        public DbSet<PROPOSED_IMPORT_COUPON_DETAIL> PROPOSED_IMPORT_COUPON_DETAIL { get; set; }
        public DbSet<SUPPLIER> SUPPLIERs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TestTable> TestTables { get; set; }
    }
}
