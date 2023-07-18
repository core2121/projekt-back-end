using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        Task<User> GetByIdAsync(int id);

        string InsertUser(User user);

        string UpdateUser(User user);

        Task<User[]> GetUsersAsync();

        string LoginUser(string login, string password);

        Task<string> Logout();
    }
}
