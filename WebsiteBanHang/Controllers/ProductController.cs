using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Controllers
{
    public class ProductController : Controller
    {
        WebsiteBanhangOnlineEntities objwebbanhangonlineEntities =new WebsiteBanhangOnlineEntities();
        // GET: Product
        public ActionResult Product(string currentFilter, int? page)
        {
            ViewBag.CurrentFilter = currentFilter;
            //Số item trong 1 trang = 5
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            //Sắp xếp theo id sản phẩm , sản phẩm mới đưa lên đầu.
            var lstProduct = objwebbanhangonlineEntities.Products.Where(n => n.PriceDiscount != null).ToList();
            Session["countPagePro"] = lstProduct.Count;
            return View(lstProduct.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Detail(int Id)
        {
            var objProduct=objwebbanhangonlineEntities.Products.Where(n=>n.Id==Id).FirstOrDefault();
            
            return View(objProduct);
        }
    }
}