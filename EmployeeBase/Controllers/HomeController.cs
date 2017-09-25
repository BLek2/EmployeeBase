using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeBase.Models;
using System.IO;

namespace EmployeeBase.Controllers
{
    
    public class HomeController : Controller
    {
        OrganizationContext organizationDb = new OrganizationContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee, HttpPostedFileBase Photo, HttpPostedFileBase Biography)
        {
           
            if (ModelState.IsValid == true && Photo != null && Biography !=null)
            {
                 
              
                string PhotoName = System.IO.Path.GetFileName(Photo.FileName); // Get Photo Name

                Photo.SaveAs(Server.MapPath("~/Content/Photo/" + PhotoName));   // Save Photo in our path

                string BiographyName = System.IO.Path.GetFileName(Biography.FileName); // Get Biography Name

                Biography.SaveAs(Server.MapPath("~/Content/Biography/" + BiographyName));   // Save Biography in our path

                string PhotoPath = "~/Content/Photo/" + PhotoName;
                string BiographyPath = "~/Content/Biography/" + BiographyName;

                employee.Photo = PhotoPath;
                employee.Biography = BiographyPath;
             
                organizationDb.Employees.Add(employee);
                organizationDb.SaveChanges();

             

                return RedirectToAction("Index");
            }
           
            return View();
        }
        public ActionResult Read()
        {
            return View();
        }
        public ActionResult UpdateAndDelete()
        {

            IEnumerable<Employee> employee = organizationDb.Employees;

            ViewBag.employee = employee;

            return View();
        }
        [HttpPost]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete()
        {
            return View();
        }
    }
}