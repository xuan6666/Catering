using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMvc.OnLineOrdering.Controllers
{
    public class LoginRegisterController : Controller
    {
        // GET: LoginRegister
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();
        }
    }
}