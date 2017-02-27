using System.Linq;
using MpaAbp.EntityFramework;
using MpaAbp.MultiTenancy;

namespace MpaAbp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MpaAbpDbContext _context;

        public DefaultTenantCreator(MpaAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
