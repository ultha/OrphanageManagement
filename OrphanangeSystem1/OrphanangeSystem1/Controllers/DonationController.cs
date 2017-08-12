using OrphanangeSystem1.Models;
using OrphanangeSystem1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrphanangeSystem1.Controllers
{
    public class DonationController : Controller
    {
        private OrphanageDbContext db = new OrphanageDbContext();
        private List<SelectListItem> items;
        public DonationController()
        {
            items = new List<SelectListItem>();
            items.Add(new SelectListItem()
            {
                Text="Education",
                Value="Education"
            });
            items.Add(new SelectListItem()
            {
                Text = "Food",
                Value = "Food"
            });
            items.Add(new SelectListItem()
            {
                Text = "Health",
                Value = "Health"
            });
            items.Add(new SelectListItem()
            {
                Text = "Maintenance",
                Value = "Maintenance"
            });
        }
        public ActionResult Index()
        {
            ViewBag.items = items;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DonatorViewModel dvm)
        {
            if(ModelState.IsValid)
            {
                db.Donators.Add(new Donator()
                {
                    FirstName = dvm.FirstName,
                    MiddleName = dvm.MiddleName,
                    LastName = dvm.LastName,
                    Address=dvm.Address,
                    ContactNo = dvm.ContactNo,
                    Email=dvm.Email,
                    DonatingAmount =dvm.DonatingAmount,
                    FeildToSpend = dvm.FeildToSpend
                });
                db.SaveChanges();
                return RedirectToAction("Index");             
            }
           
            return View(dvm);
        }
        public ActionResult Thankyou()
        {
            return View();
        }
    }
}