﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserRole : BaseEntity
    {
        public string RoleName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
