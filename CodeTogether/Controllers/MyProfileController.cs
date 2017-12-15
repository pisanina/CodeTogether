using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class MyProfileController : Controller
    {
        // GET: MyProfile
        [Route("MyProfile")]
        public ActionResult MyProfileIndex()
        {
            return View();
        }
    }
}