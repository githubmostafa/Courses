using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Courses.Models;
using Courses.ViewModels;

namespace Courses.Controllers
{
    public class StudentController : Controller
    {
        private DBContext DB;

        public StudentController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }



        public ActionResult Index()
        {
            var std = DB.Students.ToList();

            return View(std);
        }

        public ActionResult Create()
        {
            var admissionTermCodes = DB.admissionTermCodes.ToList();
            var majors = DB.Majors.ToList();
            var ModelView = new NewStudentViewModel
            {
                admissionTermCodes = admissionTermCodes,
                majors = majors
            };
            return View(ModelView);
        }
        [HttpPost]
        public ActionResult CreateNewStudent(Student student)
        {
            
                var admissionTermCodes = DB.admissionTermCodes.ToList();
                var majors = DB.Majors.ToList();
                var viewModel = new NewStudentViewModel
                {
                    admissionTermCodes = admissionTermCodes,
                    majors = majors,
                    Student = student
                };
                return View("Create", viewModel);
            
            DB.Students.Add(student);
            DB.SaveChanges();

            return RedirectToAction("Index", "Students");
        }

    }
}