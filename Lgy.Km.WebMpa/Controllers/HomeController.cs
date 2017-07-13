using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Lgy.Km.WebMpa.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}