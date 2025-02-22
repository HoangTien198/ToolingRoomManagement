//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolingRoomManagement.Areas.NVIDIA.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseRequest()
        {
            this.DevicePRs = new HashSet<DevicePR>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdUserRequest { get; set; }
        public Nullable<System.DateTime> DateRequest { get; set; }
        public Nullable<System.DateTime> DateRequired { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DevicePR> DevicePRs { get; set; }
        public virtual User UserRequest { get; set; }
    }
}
