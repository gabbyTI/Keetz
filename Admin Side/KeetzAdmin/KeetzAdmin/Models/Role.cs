//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeetzAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.admin_Login = new HashSet<admin_Login>();
        }
    
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<admin_Login> admin_Login { get; set; }
    }
}
