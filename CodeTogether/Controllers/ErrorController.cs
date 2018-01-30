using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error

        public ActionResult Found()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }
      
    }
}