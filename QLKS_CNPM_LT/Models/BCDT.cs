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
    
    public partial class BCDT
    {
        public string MABC { get; set; }
        public string MAHD { get; set; }
        public Nullable<System.DateTime> NGAY { get; set; }
        public Nullable<int> TONGTHU { get; set; }
    
        public virtual HOADON HOADON { get; set; }
    }
}
