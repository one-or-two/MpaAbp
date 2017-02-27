using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MpaAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MpaAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}