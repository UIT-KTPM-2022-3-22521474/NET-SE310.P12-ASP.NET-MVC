﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteQuanLySanPham.Models;

namespace WebsiteQuanLySanPham.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(ConfigurationManager.ConnectionStrings["QuanLySanPhamConnectionString"].ConnectionString);

            List<Catalog> dsCatalog = context.Catalogs.ToList();

            return View(dsCatalog);
        }
    }
}