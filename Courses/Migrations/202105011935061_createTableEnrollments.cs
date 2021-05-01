namespace Courses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableEnrollments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.enrollments",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        AdmissionCodeId = c.Int(nullable: false),
                        MajorId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        EnrolledIndicator = c.Boolean(nullable: false),
                        PaymentIndicator = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdmissionTermCodes", t => t.AdmissionCodeId, cascadeDelete: true)
                .ForeignKey("dbo.Majors", t => t.MajorId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.AdmissionCodeId)
                .Index(t => t.MajorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.enrollments", "Id", "dbo.Students");
            DropForeignKey("dbo.enrollments", "MajorId", "dbo.Majors");
            DropForeignKey("dbo.enrollments", "AdmissionCodeId", "dbo.AdmissionTermCodes");
            DropIndex("dbo.enrollments", new[] { "MajorId" });
            DropIndex("dbo.enrollments", new[] { "AdmissionCodeId" });
            DropIndex("dbo.enrollments", new[] { "Id" });
            DropTable("dbo.enrollments");
        }
    }
}
