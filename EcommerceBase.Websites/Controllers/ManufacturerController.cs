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
    public class ManufacturerController : Controller
    {
        private EcommerceDbContext dbContext = new EcommerceDbContext(); // khoi tao contructor.

        public ManufacturerController()
        {
            // khoi tao ham ko doi.
        }
        // GET: Manufacturer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Manufacturer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Manufacturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufacturer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manufacturer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Manufacturer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manufacturer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manufacturer/Delete/5
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
