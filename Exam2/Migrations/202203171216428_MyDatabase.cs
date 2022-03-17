namespace Exam2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        SupplierId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        QuantityPerUnit = c.Int(nullable: false),
                        UnitInStock = c.Int(nullable: false),
                        UnitOnOrder = c.Int(nullable: false),
                        ReorderLevel = c.Int(nullable: false),
                        Discontinued = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
