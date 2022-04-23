namespace EFCF2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "CustID", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "CustomerID");
            AddForeignKey("dbo.Accounts", "CustID", "dbo.Customers", "CustomerID", cascadeDelete: true);
            DropColumn("dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Accounts", "CustID", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "CustomerID");
            AddForeignKey("dbo.Accounts", "CustID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
    }
}
