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

        [HttpGet]
        public ActionResult Create()
        {   
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pvm)
        {
            ProductServiceClient psc = new ProductServiceClient();
            psc.create(pvm.product);
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(string id)
        {
            ProductServiceClient psc = new ProductServiceClient();
            psc.delete(psc.find(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            ProductServiceClient psc = new ProductServiceClient();
            ProductViewModel pvm = new ProductViewModel();
            pvm.product = psc.find(id);
            return View("Edit",pvm);
        }
        [HttpPost]
        public ActionResult Edit(ProductViewModel pvm)
        {
            ProductServiceClient psc = new ProductServiceClient();
            psc.edit(pvm.product);
            return RedirectToAction("Index");
        }
    }
}