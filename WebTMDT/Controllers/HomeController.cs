using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTMDT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Truyền dữ liệu từ controller -> dùng Model hoặc ViewBag
            ViewBag.WelcomeString = "Hello";
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