using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace akm.sklp.tracker.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataTable()
        {
            return View();
        }

        public ActionResult TabWizard()
        {
            return View();
        }
    }
}