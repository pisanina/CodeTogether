using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class UserDashboardController : Controller
    {
        // GET: UserDashboard
        [Route("UserDashboard")]
        public ActionResult UserDashboardIndex()
        {
            return View();
        }
    }
}