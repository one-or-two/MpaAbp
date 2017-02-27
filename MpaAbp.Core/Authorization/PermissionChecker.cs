using Abp.Authorization;
using MpaAbp.Authorization.Roles;
using MpaAbp.MultiTenancy;
using MpaAbp.Users;

namespace MpaAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
