using BusinessLayer;
using IdentityLayer;
using System.Collections.Generic;

using System.Web.Mvc;


namespace AdminPresentationLayer.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListUsers()
        {
            List<User> list = new CN_Users().List();
            return Json(new { data = list }, JsonRequestBehavior.AllowGet);
        }
    }
}