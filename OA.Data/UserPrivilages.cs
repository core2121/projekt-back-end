using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserPrivilages : BaseEntity
    {
        public int Privilages { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
