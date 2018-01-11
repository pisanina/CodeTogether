using CodeTogether.Models.EntityManager;
using CodeTogether.Models.ViewModel;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class MyProfileController : Controller
    {
        // GET: MyProfile
        [Authorize]
        public ActionResult MyProfileIndex()
        {
            UserManager US = new UserManager();
            return View(US.MyProfile());
        }

        [Authorize]
        [HttpPost]
        public ActionResult MyProfileIndex(MyProfileViewModel tUD)
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