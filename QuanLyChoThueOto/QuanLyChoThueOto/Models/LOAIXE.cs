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
    
    public partial class LOAIXE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIXE()
        {
            this.LICHCHOTHUEs = new HashSet<LICHCHOTHUE>();
            this.XEs = new HashSet<XE>();
        }
    
        public string Mã_loại { get; set; }
        public string Tên_loại { get; set; }
        public int Số_lượng { get; set; }
        public string Mô_tả { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHCHOTHUE> LICHCHOTHUEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XE> XEs { get; set; }
    }
}
