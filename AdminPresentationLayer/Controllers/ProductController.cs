using BusinessLayer;
using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListProducts() {
            List<Product> list = new CN_Product().List();
            return Json(new { data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}