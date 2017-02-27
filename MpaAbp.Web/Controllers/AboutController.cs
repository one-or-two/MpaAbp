using System.Web.Mvc;

namespace MpaAbp.Web.Controllers
{
    public class AboutController : MpaAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}