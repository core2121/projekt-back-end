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

        public Task<User> GetByIdAsync(int id)
        {
            return Task.FromResult(repository.GetById(id));
        }

        public string InsertUser(User user)
        {
            try
            {
                repository.Insert(user);

                return string.Empty;
            }
            catch (Exception ex)
            {

                return $"Exception when inserting user: {user.Name}, Message: {ex.Message}, InnerException: {ex.InnerException?.Message}";
            }        
        }

        public string UpdateUser(User user)
        {
            try
            {
                repository.Update(user);

                return string.Empty;
            }
            catch (Exception ex)
            {

                return $"Exception when updating user: {user.Name}, Message: {ex.Message}, InnerException: {ex.InnerException?.Message}";
            }
        }

        public Task<User[]> GetUsersAsync()
        {
            return Task.FromResult(repository.GetAll().ToArray());
        }

        public string LoginUser(string login, string password)
        {
            var u = repository.GetAll().Where(x => x.Login == login && x.Password == password).ToList();

            if (u.Count == 0)
                return "There is no user with entered details";

            if (u.Count == 1)
            {
                LoggedUserService.IsUserLogged = true;
                LoggedUserService.UserName = u.FirstOrDefault().Name;
                LoggedUserService.UserId = u.FirstOrDefault().Id;
                LoggedUserService.UserPrivilages = u.FirstOrDefault().UserPrivilagesId;

                return string.Empty;
            }

            return "There is more than one user with entered details";
        }

        public Task<string> Logout()
        {
            LoggedUserService.IsUserLogged = false;
            LoggedUserService.UserName = string.Empty;
            LoggedUserService.UserId = 0;
            LoggedUserService.UserPrivilages = 0;

            return Task.FromResult(string.Empty);
        }
    }
}
