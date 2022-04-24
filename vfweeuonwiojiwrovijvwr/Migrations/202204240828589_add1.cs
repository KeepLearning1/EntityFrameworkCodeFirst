namespace vfweeuonwiojiwrovijvwr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonalDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        StreetName = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        StaffID = c.Int(),
                        StaffName = c.String(),
                        StudentID = c.Int(),
                        StudentName = c.String(),                     
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.StaffID, unique: true, name: "INDEX_STAFFID")
                .Index(t => t.StudentID, unique: true, name: "INDEX_STUDENTID");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.PersonalDetails", "INDEX_STUDENTID");
            DropIndex("dbo.PersonalDetails", "INDEX_STAFFID");
            DropTable("dbo.PersonalDetails");
        }
    }
}
