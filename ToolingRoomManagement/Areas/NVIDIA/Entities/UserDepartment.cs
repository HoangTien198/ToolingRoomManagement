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
    
    public partial class UserDepartment
    {
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdDepartment { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
