using BusinessLayer;
using IdentityLayer;

using System.Collections.Generic;

using System.Web.Mvc;

namespace AdminPresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListBrand()
        {
            List<Brand> list = new CN_Brands().List();

            return Json(new {data = list}, JsonRequestBehavior.AllowGet);
        }
    }
}