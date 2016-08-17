using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDwithJSON_CLIENT.Models;
using CRUDwithJSON_CLIENT.ViewModells;

namespace CRUDwithJSON_CLIENT.Models
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductServiceClient psc = new ProductServiceClient();
            ViewBag.listProducts = psc.findAll();
            return View();
        }
    }
}