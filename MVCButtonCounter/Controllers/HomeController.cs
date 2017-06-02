using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCButtonCounter.Models;

namespace MVCButtonCounter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Counter model = new Counter();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            Counter model = new Counter();
            model.incrementCounter();

            return View(model);
        }

    }
}