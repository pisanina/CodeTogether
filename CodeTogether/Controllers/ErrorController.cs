using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error

        public ActionResult NotFound()
        {
            return View();
        }
    }
}