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
    public class CategoriesController : Controller
    {
        private EcommerceDbContext dbContext = new EcommerceDbContext(); // khai bao contructor.

        public CategoriesController()
        {

        }
        // GET: Categories
        public ActionResult Index()
        {
            var categories = dbContext.Categories.Take(10);

            var categoryViewModels = Mapper.Map<IEnumerable<CategoryViewModel>>(categories);

            //List<CategoryViewModel> viewModels = new List<CategoryViewModel>();

            //foreach (var item in categories)
            //{
            //    var viewModel = new CategoryViewModel(item.Id, item.Name, item.Description, item.Sort, item.Url);                
            //    viewModels.Add(viewModel);
            //}

            return View(categoryViewModels);
        }

        // GET: Categories/Details/5
        public ActionResult Details(Guid id)
        {
            var category = dbContext.Categories.FirstOrDefault(s => s.Id == id);
            if (category == null)
            {
                return HttpNotFound();
            }
            var categoryViewModel = Mapper.Map<CategoryViewModel>(category);
            return View(categoryViewModel);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(CategoryViewModel categoryViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var category = Mapper.Map<Category>(categoryViewModel);
                    category.Status = CommonStatus.Active;
                    dbContext.Categories.Add(category);
                    dbContext.SaveChanges(); 
                    return RedirectToAction("Index");
                }

            }
            catch
            {

            }

            return View();
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = dbContext.Categories.FirstOrDefault(s => s.Id == id);
            if (category == null)
            {
                return HttpNotFound();
            }

            var categoryViewModel = Mapper.Map<CategoryViewModel>(category);


            return View(categoryViewModel);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                var category = dbContext.Categories.FirstOrDefault(s => s.Id == categoryViewModel.Id);
                if (category == null)
                {
                    return HttpNotFound();
                }
                Mapper.Map(categoryViewModel, category);
                category.UpdatedDate = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var category = dbContext.Categories.FirstOrDefault(s => s.Id == id);
            if (category == null)
            {
                return HttpNotFound();
            }

            var categoryViewModel = Mapper.Map<CategoryViewModel>(category);


            return View(categoryViewModel);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(CategoryViewModel categoryViewModel)
        {
            try
            {
                var category = dbContext.Categories.FirstOrDefault(s => s.Id == categoryViewModel.Id);
                if (category == null)
                {
                    return HttpNotFound();
                }

                dbContext.Categories.Remove(category);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
