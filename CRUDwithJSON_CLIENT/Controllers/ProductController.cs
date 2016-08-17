using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDwithJSON_CLIENT.Models;
using CRUDwithJSON_CLIENT.ViewModels;

namespace CRUDwithJSON_CLIENT.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            ProductServiceClient psc = new ProductServiceClient();
            ViewBag.listProducts = psc.findAll();

            return View();
        }
    }
    }