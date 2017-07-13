using DemoDocker.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDocker.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext(Config.ProductConnectionString);
        public ActionResult Index()
        {
            ViewBag.Path = Config.Path;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}