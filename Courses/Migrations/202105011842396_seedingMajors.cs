namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingMajors : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Majors ON");
            Sql("insert into Majors(MajorId, Name) values (1, 'Programming')");
            Sql("insert into Majors(MajorId, Name) values (2, 'Networking')");
        }
        
        public override void Down()
        {
        }
    }
}
