//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectUser
    {
        public System.Guid Id { get; set; }
        public System.Guid ProjectId { get; set; }
        public System.Guid UserId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public byte[] TimeStamp { get; set; }
        public System.Guid ProjectRoleId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual User User { get; set; }
        public virtual ProjectRole ProjectRole { get; set; }
    }
}
