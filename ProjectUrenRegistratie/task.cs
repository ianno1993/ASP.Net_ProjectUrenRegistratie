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
    
    public partial class task
    {
        public task()
        {
            this.UserTasks = new HashSet<UserTask>();
        }
    
        public int taskId { get; set; }
        public int projectId { get; set; }
        public string taskName { get; set; }
        public string taskDescription { get; set; }
    
        public virtual project project { get; set; }
        public virtual ICollection<UserTask> UserTasks { get; set; }
    }
}
