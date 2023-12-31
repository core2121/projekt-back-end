﻿using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserRoleService : IUserRoleService
    {
        private IRepository<UserRole> repository;

        public UserRoleService(IRepository<UserRole> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<UserRole> GetAll()
        {
            return repository.GetAll();
        }

        public UserRole GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
