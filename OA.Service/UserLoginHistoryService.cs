using OA.Data;
using OA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class UserLoginHistoryService : IUserLoginHistoryService
    {
        private IRepository<UserLoginHistory> repository;

        public UserLoginHistoryService(IRepository<UserLoginHistory> repository)
        {
            this.repository = repository;
        }

        public Task<IEnumerable<UserLoginHistory>> GetById(int id)
        {
            return Task.FromResult(repository.GetAll().Where(x => x.UserId == id));
        }

        public string InsertHistory(UserLoginHistory loginHistory)
        {
            try
            {
                repository.Insert(loginHistory);

                return string.Empty;
            }
            catch (Exception ex)
            {

                return $"Exception when inserting user history, Message: {ex.Message}, InnerException: {ex.InnerException?.Message}";
            }
        }
    }
}
