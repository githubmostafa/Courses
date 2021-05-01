namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableAdmissionTermCodes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdmissionTermCodes",
                c => new
                    {
                        AdmissionCodeId = c.Int(nullable: false, identity: true),
                        Term = c.String(),
                    })
                .PrimaryKey(t => t.AdmissionCodeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdmissionTermCodes");
        }
    }
}
