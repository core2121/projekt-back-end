using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string Surname{ get; set; }

        public virtual UserRole UserRole { get; set; }

        public virtual ICollection<UserLoginHistory> UserLoginHistory { get; set; }

        public virtual UserPrivilages UserPrivilages { get; set; }
    }
}
