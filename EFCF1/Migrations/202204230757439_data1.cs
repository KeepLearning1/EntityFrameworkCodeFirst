namespace EFCF1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        EmployeeJoinDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeRole = c.String(),
                        EmployeeSalary = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Companies", new[] { "EmployeeID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
        }
    }
}
