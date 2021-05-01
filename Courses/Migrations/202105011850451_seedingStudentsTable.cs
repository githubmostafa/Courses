namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingStudentsTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Students ON");
            Sql("insert into Students(Id, FirstName, LastName, AdmissionCodeId, DateOfBirth, MajorId) " +
                "values (1, 'Mostafa', 'Khraizat', 201910,'8/3/1999', 1)");
            Sql("insert into Students(Id, FirstName, LastName, AdmissionCodeId, DateOfBirth, MajorId) " +
                "values (2, 'Hussein', 'Hijazi', 201910,'4/4/2000', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
