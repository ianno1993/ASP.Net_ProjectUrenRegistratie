//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectUrenRegistratie
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTask
    {
        public UserTask()
        {
            this.hourRegistrations = new HashSet<hourRegistration>();
        }
    
        public int userTaskId { get; set; }
        public int userId { get; set; }
        public int taskId { get; set; }
        public int projectId { get; set; }
    
        public virtual ICollection<hourRegistration> hourRegistrations { get; set; }
        public virtual project project { get; set; }
        public virtual task task { get; set; }
        public virtual User User { get; set; }
    }
}
