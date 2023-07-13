using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserService : IUserService
    {
        private IRepository<User> repository;

        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        IEnumerable<User> IUserService.GetAll()
        {
            return repository.GetAll();
        }

        User IUserService.GetById(int id)
        {
            return repository.GetById(id);
        }

        public void InsertUser(User user)
        {
            repository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            repository.Update(user);
        }
    }
}
