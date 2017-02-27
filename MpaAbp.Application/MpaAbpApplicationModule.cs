using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MpaAbp
{
    [DependsOn(typeof(MpaAbpCoreModule), typeof(AbpAutoMapperModule))]
    public class MpaAbpApplicationModule : AbpModule
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
