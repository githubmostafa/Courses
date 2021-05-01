namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingDepartments : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Departments ON");
            Sql("insert into Departments(DepartmentId, DepartmentName) values (1, 'Computer Science')");
            Sql("insert into Departments(DepartmentId, DepartmentName) values (2, 'Sciences')");
        }
        
        public override void Down()
        {
        }
    }
}
