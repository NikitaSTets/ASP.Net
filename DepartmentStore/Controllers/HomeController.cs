using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepartmentStore.Models;
namespace DepartmentStore.Controllers
{
    public class HomeController : Controller
    {
        Shop db = new Shop();
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            return View(db.ShopInfoes);
        }
        public ActionResult Goods(int id)
        {
           IEnumerable<ProductInfo>pr = db.ProductInfoes.Where(b=>b.shop_id==id);
            return PartialView(pr);
        }

    }
}