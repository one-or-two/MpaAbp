using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MpaAbp.EntityFramework;

namespace MpaAbp.Migrator
{
    [DependsOn(typeof(MpaAbpDataModule))]
    public class MpaAbpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MpaAbpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}