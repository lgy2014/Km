using System.Data.Common;
using Abp.Zero.EntityFramework;
using Lgy.Km.Authorization.Roles;
using Lgy.Km.MultiTenancy;
using Lgy.Km.Users;

namespace Lgy.Km.EntityFramework
{
    public class KmDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public KmDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in KmDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of KmDbContext since ABP automatically handles it.
         */
        public KmDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public KmDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public KmDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
