using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonEntities
{
    public class TaskModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskModel()
        {
            this.UsersModel = new HashSet<UsersModel>();
        }

        public long Task_ID { get; set; }
        public Nullable<long> Parent_ID { get; set; }
        public Nullable<long> Project_ID { get; set; }
        public string Task { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public int Priority { get; set; }
        public bool Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersModel> UsersModel { get; set; }
    }
}