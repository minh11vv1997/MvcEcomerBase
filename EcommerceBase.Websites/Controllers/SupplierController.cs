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
    public class SupplierController : Controller
    {
        private EcommerceDbContext dbContext = new EcommerceDbContext(); // khoi tao Contructor.
       

        public SupplierController()
        {
            // Khoi tao ham khong doi.
        }
        // GET: Supplier
        public ActionResult Index()
        {

            var suppliers = dbContext.Suppliers.Take(10);
            var supplierViewModels = Mapper.Map<IEnumerable<SupplierViewModel>>(suppliers);
            return View(supplierViewModels);
        }

        // GET: Supplier/Details/5
        public ActionResult Details(Guid id)
        {

            var supplier = dbContext.Categories.FirstOrDefault(s => s.Id == id);
            if (supplier == null)
            {
                return HttpNotFound();    
            }
            var supplierViewModels = Mapper.Map<SupplierViewModel>(supplier);
            return View(supplierViewModels);
        }

        // GET: Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supplier/Create
        [HttpPost]
        public ActionResult Create(SupplierViewModel supplierViewModel )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var supplier = Mapper.Map<Supplier>(supplierViewModel);
                    supplier.Status = CommonStatus.Active;
                    dbContext.Suppliers.Add(supplier);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index");


                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Supplier/Edit/5
        public ActionResult Edit(Guid id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var supplier = dbContext.Suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            var supplierViewModels = Mapper.Map<SupplierViewModel>(supplier);
            return View(supplierViewModels);
        }

        // POST: Supplier/Edit/5
        [HttpPost]
        public ActionResult Edit(SupplierViewModel supplierViewModel)
        {
            if (ModelState.IsValid)
            {
                var supplier = dbContext.Suppliers.FirstOrDefault(s => s.Id == supplierViewModel.Id);
                if (supplier == null)
                {
                    return HttpNotFound();
                }
                Mapper.Map(supplierViewModel, supplier);
                supplier.UpdatedDate = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(supplierViewModel);
        }

        // GET: Supplier/Delete/5
        public ActionResult Delete(Guid id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            var supplier = dbContext.Suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier == null)
            {
                return HttpNotFound();
            }
            var supplierViewModels = Mapper.Map<SupplierViewModel>(supplier);
            return View(supplierViewModels);
        }

        // POST: Supplier/Delete/5
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
