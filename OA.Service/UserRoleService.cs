using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    internal class UserRoleService : IUserRoleService
    {
        private IRepository<UserRole> repository;

        public UserRoleService(IRepository<UserRole> repository)
        {
            this.repository = repository;
        }

        IEnumerable<UserRole> IUserRoleService.GetAll()
        {
            return repository.GetAll();
        }
    }
}
