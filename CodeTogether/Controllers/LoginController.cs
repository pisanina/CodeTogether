using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Security.Principal;
using System.Data.Entity;
using CodeTogether.Models;
using CodeTogether.Models.EntityManager;

namespace CodeTogether.Controllers
{

    public class LoginController : Controller
    {
        // Get: Login
        //[Route("Login")]
        
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIndex(tblUserData tUD)
        {
            if (ModelState.IsValid)
            {
                UserManager US = new UserManager();
                string password = US.GetUserPassword(tUD.UserName);

                if (string.IsNullOrEmpty(password))
                    ModelState.AddModelError("", "The user login or password provided is incorect.");
                else{
                    if (tUD.UserPassword.Equals(password))
                    {
                        FormsAuthentication.SetAuthCookie(tUD.UserName, false);
                        return RedirectToAction("MyProfileIndex", "MyProfile");

                    }
                    else
                    {
                        ModelState.AddModelError("", "The password provided is incorect.");
                    }
                }
            }
            return View(tUD);
        }

        //Get:
        //nieużywane narazie - do zabronienia ponownego logowania
        private void EnsureLogedOut()
        {
            if (Request.IsAuthenticated)
                Logout();
        }

        //Post:
        [Authorize]
        //[ValidateAntiForgeryToken]   tutaj nie można robic walidacji - dlaczego ?
        public ActionResult Logout()
        {
            try
            {
                FormsAuthentication.SignOut();
               // HttpContext.User = new GenericPrincipal(new GenericIdentity(string.Empty), null);
                //Session.Clear();
                //System.Web.HttpContext.Current.Session.RemoveAll();
                return RedirectToAction("Index", "Home");
            }
            catch { throw; }

        }

       




    }
}