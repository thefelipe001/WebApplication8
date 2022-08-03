using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> Find(int id);
        bool Add (T entity);
        bool Update (T entity);

    }
}
