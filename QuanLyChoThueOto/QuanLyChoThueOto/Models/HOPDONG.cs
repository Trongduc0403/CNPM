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
    
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            this.THANHTOANs = new HashSet<THANHTOAN>();
        }
    
        public string Số_HĐ { get; set; }
        public string Số_xe { get; set; }
        public string Mã_KH { get; set; }
        public string Mã_NV { get; set; }
        public System.DateTime Ngày_HĐ { get; set; }
        public string Nội_dung_HĐ { get; set; }
        public string Tiền_đặt { get; set; }
        public string Khuyến_mãi { get; set; }
        public string Giấy_tờ_giữ_lại { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual XE XE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN> THANHTOANs { get; set; }
    }
}
