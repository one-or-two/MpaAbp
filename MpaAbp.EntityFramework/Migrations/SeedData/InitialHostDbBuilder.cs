using MpaAbp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MpaAbp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MpaAbpDbContext _context;

        public InitialHostDbBuilder(MpaAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
