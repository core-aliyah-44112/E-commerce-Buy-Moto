using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        WebsiteBanhangOnlineEntities dbWeb = new WebsiteBanhangOnlineEntities();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AccountAdmin(int id)
        {
            var objaccount = dbWeb.Users.Where(n => n.Id == id).FirstOrDefault();
            return View(objaccount);
        }
    }
}