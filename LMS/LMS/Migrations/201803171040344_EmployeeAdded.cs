namespace LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        RetypeEmail = c.String(nullable: false),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        Cnic = c.String(nullable: false),
                        City = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
