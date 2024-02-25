using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPresentationLayer.Controllers
{
    public class MaintenanceController : Controller
    {
        // GET: Maintenance
        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Make()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }


    }
}