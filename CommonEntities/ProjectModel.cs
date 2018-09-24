using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonEntities
{
    public class ProjectModel
    {
        public ProjectModel()
        {
            this.UsersModel = new HashSet<UsersModel>();
        }

        public long Project_ID { get; set; }
        public string Project { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Time { get; set; }
        public int Priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersModel> UsersModel { get; set; }
    }
}