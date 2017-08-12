using OrphanangeSystem1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrphanangeSystem1.Controllers
{
    public class HomeController : Controller
    {
        private OrphanageDbContext db = new OrphanageDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult Sponsor()
        {
          

            return View();
        }
        
        public ActionResult Adoptions()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adoptions(AdoptorRequestView avm)
        {
            if (ModelState.IsValid)
            {
                db.AdoptorRequests.Add(new AdoptorRequest()
                {
                   Name=avm.Name,
                   DateOfBirth = avm.DateOfBirth,
                   Gender = avm.Gender,
                   Address=avm.Address,
                   ZipCode=avm.ZipCode,
                   EmailAddress = avm.EmailAddress,
                   ContactNo = avm.ContactNo,
                   Married = avm.Married,
                   DateOfMarriage =avm.DateOfMarriage,Profession=avm.Profession,
                    MonthlyIncome= avm.MonthlyIncome,
                    ReasonOfAdoption=avm.ReasonOfAdoption,
                    IfAnyChild=avm.IfAnyChild
                });
                db.SaveChanges();
                return Redirect("~/Home/Index");
            }
                return View(avm);
        }
        public ActionResult GetInvolved()
        {
            return View();

        }
        public ActionResult Contact()
        {
            return View();

        }
    }
}