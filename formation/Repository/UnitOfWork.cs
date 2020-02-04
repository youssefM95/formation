using formation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formation.Repository
{
    public class UnitOfWork: IUnitOfWork
    
        
    {
        public SchoolDb _context { get; }
        public UnitOfWork(SchoolDb myDbContext)
        {
            _context = myDbContext;
        }



        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
