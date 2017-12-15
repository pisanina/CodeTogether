using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTogether.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        [Route("Register")]
        public ActionResult RegisterIndex()
        {
            return View();
        }
    }
}