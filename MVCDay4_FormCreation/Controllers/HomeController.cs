using MVCDay4_FormCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay4_FormCreation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

            [HttpPost]
        public ActionResult Index1(Employee e1)
        {
            return View(e1);
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}