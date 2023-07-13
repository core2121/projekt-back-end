using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        void SaveChanges();
    }
}
