using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserPrivilagesService : IUserPrivilagesService
    {
        private IRepository<UserPrivilages> repository;

        public UserPrivilagesService(IRepository<UserPrivilages> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<UserPrivilages> GetAll()
        {
            return repository.GetAll();
        }

        public UserPrivilages GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
