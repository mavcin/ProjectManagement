
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
    
public partial class TaskStatus
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TaskStatus()
    {

        this.Tasks = new HashSet<Task>();

    }


    public System.Guid Id { get; set; }

    public string Abrv { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public System.DateTime DateCreated { get; set; }

    public System.DateTime DateUpdated { get; set; }

    public byte[] TimeStamp { get; set; }

    public int SortOrder { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Task> Tasks { get; set; }

}

}
