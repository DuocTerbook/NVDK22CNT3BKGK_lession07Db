//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NvdBKGK_lession07.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nvdKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nvdKhoa()
        {
            this.nvdSinhViens = new HashSet<nvdSinhVien>();
        }
    
        public string NvdMaKH { get; set; }
        public string NvdTenKH { get; set; }
        public Nullable<bool> NvdTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nvdSinhVien> nvdSinhViens { get; set; }
    }
}
