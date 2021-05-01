using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Courses.Models;
namespace Courses.ViewModels
{
    public class NewStudentViewModel
    {
        public IEnumerable<AdmissionTermCode> admissionTermCodes { get; set; }

        public IEnumerable<Major> majors { get; set; }

        public Student Student { get; set; }
    }
}