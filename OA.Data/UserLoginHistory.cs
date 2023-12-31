﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserLoginHistory : BaseEntity
    {
        public DateTime LoginDate { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
