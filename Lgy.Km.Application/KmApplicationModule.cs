using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Lgy.Km
{
    [DependsOn(typeof(KmCoreModule), typeof(AbpAutoMapperModule))]
    public class KmApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
