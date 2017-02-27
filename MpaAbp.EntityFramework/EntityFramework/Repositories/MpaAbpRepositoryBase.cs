using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MpaAbp.EntityFramework.Repositories
{
    public abstract class MpaAbpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MpaAbpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MpaAbpRepositoryBase(IDbContextProvider<MpaAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MpaAbpRepositoryBase<TEntity> : MpaAbpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MpaAbpRepositoryBase(IDbContextProvider<MpaAbpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
