using formation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formation.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly SchoolDb _schoolDb;

        public GenericRepository(SchoolDb schoolDb)
        {
            _schoolDb = schoolDb;
        }
        public void Add(T entity)
        {
            _schoolDb.Set<T>().Add(entity);
           
        }

        public List<T> GetAll()
        {
          return  _schoolDb.Set<T>().ToList<T>();
        }
    }
}
