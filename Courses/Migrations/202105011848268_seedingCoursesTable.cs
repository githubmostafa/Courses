namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingCoursesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Courses ON");
            Sql("insert into Courses(CourseId,CourseName,Credits,DepartmentId) values (1,'Introduction To Java',6, 1)");
            Sql("insert into Courses(CourseId,CourseName,Credits,DepartmentId) values (2,'Special Relativity',5, 2)");
        }

        public override void Down()
        {
        }
    }
}
