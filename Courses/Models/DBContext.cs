using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class DBContext:DbContext
    {
        public DBContext()
        {
         }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AdmissionTermCode> admissionTermCodes { get; set; }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<enrollment> enrollments { get; set; }



    }
}