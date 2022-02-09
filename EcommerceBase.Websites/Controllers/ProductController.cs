using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using EcommerceBase.Domain;
using EcommerceBase.Domain.Entities;
using EcommerceBase.Domain.Enums;
using EcommerceBase.Websites.Models;

namespace EcommerceBase.Websites.Controllers
{   
    public class ProductController : Controller
    {
        private EcommerceDbContext dbContext = new EcommerceDbContext(); // khai bao contructor

        // GET: Product
        public ActionResult Index()
        {
            var products = dbContext.Products.Take(15);
            var productViewModel = Mapper.Map<IEnumerable<ProductViewModel>>(products);

            return View(productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(Guid id)
        {
            var product = dbContext.Products.FirstOrDefault(s => s.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            var productViewModel = Mapper.Map<ProductViewModel>(product);
            return View(productViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var product = Mapper.Map<Product>(productViewModel);
                    product.Status = CommonStatus.Active;
                    dbContext.Products.Add(product);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                
            }
            return View();
        }

        // GET: Product/Edit/5
        public ActionResult Edit(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var product = dbContext.Products.FirstOrDefault(s => s.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            var productViewModel = Mapper.Map<ProductViewModel>(product);
            return View(productViewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = dbContext.Products.FirstOrDefault(s => s.Id == productViewModel.Id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                Mapper.Map(productViewModel, product);
                product.UpdatedDate = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(productViewModel);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
