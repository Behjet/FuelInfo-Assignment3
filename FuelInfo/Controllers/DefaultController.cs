using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuelInfo.Models;

namespace FuelInfo.Controllers
{
    public class DefaultController : Controller
    {
        private ContextClass context = new ContextClass();
        

        public ActionResult Index()
        {
            
            ContextClass context = new ContextClass();
            var products = context.Categories.ToList();
            products = products.Skip(Math.Max(0, products.Count() - 3)).ToList();
            return View(products);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Category());
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }
    }
}