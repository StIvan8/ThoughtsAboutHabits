using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public interface IRepository<in T>
    {
        void Edit(T entity);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Delete(T entity);

    }
}
