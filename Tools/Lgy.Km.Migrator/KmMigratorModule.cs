using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Lgy.Km.EntityFramework;

namespace Lgy.Km.Migrator
{
    [DependsOn(typeof(KmDataModule))]
    public class KmMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<KmDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}