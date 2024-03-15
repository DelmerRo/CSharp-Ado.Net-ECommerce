using BusinessLayer;
using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListCategories() {
            List<Category> list = new CN_Categories().List();

            return Json(new { data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}