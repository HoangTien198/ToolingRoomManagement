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
    
    public partial class ReturnDevice
    {
        public int Id { get; set; }
        public Nullable<int> IdReturn { get; set; }
        public Nullable<int> IdDevice { get; set; }
        public Nullable<int> ReturnQuantity { get; set; }
        public Nullable<bool> IsNG { get; set; }
        public Nullable<bool> IsSwap { get; set; }
    
        public virtual Device Device { get; set; }
    }
}
