using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Lgy.Km.WebSpaAngular.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KmControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}