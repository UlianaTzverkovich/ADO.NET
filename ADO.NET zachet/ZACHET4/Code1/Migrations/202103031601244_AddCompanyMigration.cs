namespace Code1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VipOrders", "OrderId", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            DropIndex("dbo.VipOrders", new[] { "OrderId" });
            AddColumn("dbo.Orders", "OrderName", c => c.String());
            AddColumn("dbo.Orders", "Size", c => c.Double(nullable: false));
            AddColumn("dbo.Orders", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "email", c => c.String());
            CreateIndex("dbo.Orders", "Customer_CustomerID");
            DropColumn("dbo.Customers", "Age");
            DropColumn("dbo.Customers", "Photo");
            DropColumn("dbo.Orders", "ProductName");
            DropColumn("dbo.Orders", "Description");
            DropColumn("dbo.Orders", "Quantity");
            DropColumn("dbo.Orders", "PurchaseDate");
            DropTable("dbo.VipOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VipOrders",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
            AddColumn("dbo.Orders", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "Description", c => c.String());
            AddColumn("dbo.Orders", "ProductName", c => c.String());
            AddColumn("dbo.Customers", "Photo", c => c.Binary(storeType: "image"));
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
            DropIndex("dbo.Orders", new[] { "Customer_CustomerID" });
            AlterColumn("dbo.Customers", "email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Orders", "Price");
            DropColumn("dbo.Orders", "Size");
            DropColumn("dbo.Orders", "OrderName");
            CreateIndex("dbo.VipOrders", "OrderId");
            CreateIndex("dbo.Orders", "Customer_CustomerId");
            AddForeignKey("dbo.VipOrders", "OrderId", "dbo.Orders", "OrderId");
        }
    }
}
