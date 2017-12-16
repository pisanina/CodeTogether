using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class LoginController : Controller
    {
       // Get: Login
        [Route("Login")]
        public ActionResult LoginIndex()
        {
            return View();
        }
    }
}