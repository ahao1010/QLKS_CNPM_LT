//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS_CNPM_LT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string MA_PHONG { get; set; }
        public string TENPhong { get; set; }
        public string TRANGTHAI { get; set; }
        public Nullable<double> GIA { get; set; }
        public string ANH { get; set; }
        public string MaLoai { get; set; }
        public Nullable<bool> DADUYET { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual LOAIPHONG LOAIPHONG { get; set; }
    }
}
