//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManager.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task_Table()
        {
            this.Users_Table = new HashSet<Users_Table>();
        }
    
        public long Task_ID { get; set; }
        public Nullable<long> Parent_ID { get; set; }
        public Nullable<long> Project_ID { get; set; }
        public string Task { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public Nullable<int> Priority { get; set; }
        public bool Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Users_Table> Users_Table { get; set; }
    }
}
