using OrphanangeSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrphanangeSystem1.Controllers
{
    public class SponsorController : Controller
    {
        private OrphanageDbContext db = new OrphanageDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index( SponsorViewModel svm)
        {
            if (ModelState.IsValid)
            {
                db.Sponsors.Add(new Sponsor()
                {
                    FirstName=svm.FirstName,
                    LastName=svm.LastName,
                    Email =svm.Email,
                    Password = svm.Password,
                    ContactNo = svm.ContactNo,
                    Address=svm.Address,
                    Amount = svm.Amount
                });
                db.SaveChanges();
                return Redirect("~/Home/Index");
                    }
            return View();
        }
    }
}