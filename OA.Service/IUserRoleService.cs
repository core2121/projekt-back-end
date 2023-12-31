﻿using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IUserRoleService
    {
        public IEnumerable<UserRole> GetAll();

        public UserRole GetById(int id);
    }
}
