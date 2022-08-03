using Datos.Conexion;
using Microsoft.EntityFrameworkCore;
using Servicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Repositorio
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDBContext _context;

        private DbSet<T> _entities;
        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;
            _entities=_context.Set<T>();
        }
    
        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
                return await _entities.ToListAsync();

            }
            catch (Exception ex)
            {

                throw new Exception("Error"+ex);
            }
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}
