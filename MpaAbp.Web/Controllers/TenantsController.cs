using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MpaAbp.Authorization;
using MpaAbp.MultiTenancy;

namespace MpaAbp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MpaAbpControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}