using Abp.Domain.Entities;
using Abp.NHibernate;
using Abp.NHibernate.Repositories;

namespace Lgy.Km.NHibernate.Repositories
{
    /// <summary>
    /// Base class for all repositories in this application
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Type of the primary key</typeparam>
    public abstract class KmRepositoryBase<TEntity, TPrimaryKey> : NhRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected KmRepositoryBase(ISessionProvider sessionProvider) : base(sessionProvider)
        {
        }

        //add common methods for all repositories
    }

    /// <summary>
    /// A shortcut of KmRepositoryBase for entities with integer Id.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class KmRepositoryBase<TEntity> : KmRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected KmRepositoryBase(ISessionProvider sessionProvider) : base(sessionProvider)
        {
        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
