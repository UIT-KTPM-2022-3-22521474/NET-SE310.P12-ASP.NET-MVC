using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;

namespace WebsiteQuanLySanPham.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString);

            List<Product> dsProduct = context.Products.ToList();

            return View(dsProduct);
        }
    }
}