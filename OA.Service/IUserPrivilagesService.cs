using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface IUserPrivilagesService
    {
        public IEnumerable<UserPrivilages> GetAll();

        public UserPrivilages GetById(int id);

    }
}
