using CodeTogether.Models.EntityManager;
using CodeTogether.Models.ViewModel;
using System.Web.Mvc;
using System.Web.Security;

namespace CodeTogether.Controllers
{
    public class RegisterController : Controller
    {

        [Route("Register")]
        public ActionResult RegisterIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterIndex(RegistrationViewModel tUD)
        {
            if (ModelState.IsValid)
            {
                UserManager US = new UserManager();
                if (US.Register(tUD) == 1)
                    ModelState.AddModelError("", "The User name is already taken.");
                else
                {
                    FormsAuthentication.SetAuthCookie(tUD.UserName, false);
                    return RedirectToAction("MySettingsIndex", "MyProfile");
                }
            }
            return View(tUD);
        }
    }
}