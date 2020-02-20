namespace customerproducttask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        MobileNo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        PName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Customer_Cid = c.Int(),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.Customers", t => t.Customer_Cid)
                .Index(t => t.Customer_Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_Cid", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "Customer_Cid" });
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
