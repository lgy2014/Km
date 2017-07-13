using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Lgy.Km.EntityFramework.Repositories
{
    public abstract class KmRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<KmDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected KmRepositoryBase(IDbContextProvider<KmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class KmRepositoryBase<TEntity> : KmRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected KmRepositoryBase(IDbContextProvider<KmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
