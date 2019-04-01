using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTMDT.Models;
namespace WebTMDT.Controllers
{
    public class ProductController : Controller
    {
        ThuongMai db = new ThuongMai();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SanPham(int loaiHang)
        {
            var sanpham = db.SanPhams.Where(x => x.loaiHang == loaiHang).ToList();
            return View(sanpham);
        }

        //public ActionResult ListDanhMucLoaiHang()
        //{
        //    var loaiHang = db.LoaiHangs.ToList();
        //    return View(loaiHang);
        //}

    }
}