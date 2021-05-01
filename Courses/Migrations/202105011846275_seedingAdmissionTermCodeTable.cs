namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingAdmissionTermCodeTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT AdmissionTermCodes ON");
            Sql("insert into AdmissionTermCodes(AdmissionCodeId, Term) values (201910, 'Fall of 2019')");
            Sql("insert into AdmissionTermCodes(AdmissionCodeId, Term) values (201920, 'Spring of 2019')");
        }
        
        public override void Down()
        {
        }
    }
}
