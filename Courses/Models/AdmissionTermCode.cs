using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class AdmissionTermCode
    {
        [Key]
       
        public int AdmissionCodeId { get; set; }
        [Display(Name = "Admission Semester")]
        public string Term { get; set; }
    }
}