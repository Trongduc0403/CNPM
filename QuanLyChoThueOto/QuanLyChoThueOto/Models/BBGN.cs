//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyChoThueOto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BBGN
    {
        public int idBBGN { get; set; }
        public Nullable<int> idXe { get; set; }
        public Nullable<int> idKH { get; set; }
        public Nullable<int> idNV { get; set; }
        public Nullable<System.DateTime> NgayGiao { get; set; }
        public Nullable<int> KmDi { get; set; }
        public string XangDi { get; set; }
        public string TrangThaiDi { get; set; }
        public Nullable<int> KmVe { get; set; }
        public string XangVe { get; set; }
        public string TrangThaiVe { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual BBGN BBGN1 { get; set; }
        public virtual BBGN BBGN2 { get; set; }
    }
}
