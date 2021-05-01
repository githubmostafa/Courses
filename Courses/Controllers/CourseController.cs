using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courses.Models;
using Courses.ViewModels;
namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private DBContext DB;
        public CourseController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }
        public ActionResult Index()
        {
            var crs = DB.Courses.ToList();
            return View(crs);
        }
        public ActionResult Create()
        {
            var dp = DB.Departments.ToList();
            var viewModel = new NewCourseViewModel
            {
                departments = dp
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult CreateNewCourse(Course course)
        {
           
                var dps = DB.Departments.ToList();

                var viewModel = new NewCourseViewModel
                {
                    departments = dps,
                    Course = course
                };
                return View("Create", viewModel);
            
            DB.Courses.Add(course);
            DB.SaveChanges();

            return RedirectToAction("Index", "Courses");
        }
    }
}