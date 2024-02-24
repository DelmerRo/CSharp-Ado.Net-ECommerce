﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using IdentityLayer;
using BusinessLayer;

namespace AdminPresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }


        [HttpGet]
        public JsonResult ListUsers()
        {
          List<User> list = new CN_Users().List();

            return Json(new { data =  list }, JsonRequestBehavior.AllowGet);
        }
    }
}