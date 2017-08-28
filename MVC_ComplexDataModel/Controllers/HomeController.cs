using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_ComplexDataModel.DAL;
using MVC_ComplexDataModel.Models;
using MVC_ComplexDataModel.ViewModels;

namespace MVC_ComplexDataModel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            return View();
        }

        private SchoolContext db = new SchoolContext();
        public ActionResult About()
        {
            var data = from student in db.Students
                       group student by student.EnrollmentDate into dateGroup
                       select new EnrollmentDateGroup()
                       {
                           EnrollmentDate =  dateGroup.Key,
                           StudentCount = dateGroup.Count()
                       };

            return View(data);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}