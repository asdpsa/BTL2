﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aa
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLCuaHangMayTinhEntities : DbContext
    {
        public QLCuaHangMayTinhEntities()
            : base("name=QLCuaHangMayTinhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public virtual DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual DbSet<Hoadonban> Hoadonbans { get; set; }
        public virtual DbSet<Hoadonnhap> Hoadonnhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongTinMayTinh> ThongTinMayTinhs { get; set; }
    }
}
