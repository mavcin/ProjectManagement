
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
    
public partial class Task
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Task()
    {

        this.TaskComments = new HashSet<TaskComment>();

    }


    public System.Guid Id { get; set; }

    public System.Guid ProjectId { get; set; }

    public System.Guid CreatedByUserId { get; set; }

    public System.Guid AssignedToUserId { get; set; }

    public System.Guid StatusId { get; set; }

    public System.Guid PriorityId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public Nullable<System.DateTime> DueDate { get; set; }

    public System.DateTime DateCreated { get; set; }

    public System.DateTime DateUpdated { get; set; }

    public byte[] TimeStamp { get; set; }

    public byte Progress { get; set; }



    public virtual Project Project { get; set; }

    public virtual TaskPriority TaskPriority { get; set; }

    public virtual TaskStatus TaskStatus { get; set; }

    public virtual User AssignedToUser { get; set; }

    public virtual User CreatedByUser { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TaskComment> TaskComments { get; set; }

}

}
