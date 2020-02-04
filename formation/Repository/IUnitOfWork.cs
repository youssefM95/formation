using formation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formation.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        int Commit();
    }

   
}
