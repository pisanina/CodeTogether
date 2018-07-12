using CodeTogether.Models.EntityManager;
using CodeTogether.Models.ViewModel;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class MySettingsController : Controller
    {
        // GET: MyProfile
        [Authorize]
        public ActionResult MySettingsIndex()
        {
            UserManager US = new UserManager();
            return View(US.MySettings());
        }

        [Authorize]
        [HttpPost]
        public ActionResult MySettingsIndex(MySettingsViewModel tUD)
        {
            if (ModelState.IsValid)
            {
                UserManager US = new UserManager();
                if (US.SaveProfile(tUD) == 1)
                    ModelState.AddModelError("", "Confirm password dont mach");
                else
                {
                    tUD.SaveMessage = "Changes were saved";
                }
            }
            return View(tUD);
        }
    }
}