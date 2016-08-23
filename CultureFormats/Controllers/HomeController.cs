using System.Globalization;
using System.Web.Mvc;

namespace CultureFormats.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string culture = "")
        {
            return View(
                string.IsNullOrEmpty(culture) ? 
                    CultureInfo.InvariantCulture : 
                    CultureInfo.GetCultureInfo(culture));
        }
    }
}