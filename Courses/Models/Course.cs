using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Course
    {
        //Key will be added manualy while seeding
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CourseId { get; set; }

        [Required(ErrorMessage = "Field Required")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Field Required")]
        [Range(1, 4)]
        public int Credits { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department department { get; set; }
    }
}