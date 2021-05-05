namespace siparisTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        storeId = c.Int(nullable: false),
                        Adress = c.String(nullable: false, maxLength: 50),
                        count = c.Int(nullable: false),
                        product_id = c.Int(nullable: false),
                        status_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.product_id, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.status_id, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.storeId)
                .Index(t => t.storeId)
                .Index(t => t.product_id)
                .Index(t => t.status_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        price = c.Double(nullable: false),
                        categoryId = c.Int(nullable: false),
                        subCategoryId = c.Int(nullable: false),
                        storeId = c.Int(nullable: false),
                        totalCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Stores", t => t.storeId)
                .Index(t => t.storeId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 30),
                        userOwner_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userOwner_id, cascadeDelete: true)
                .Index(t => t.userOwner_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                        surname = c.String(nullable: false, maxLength: 30),
                        phonenumber = c.String(nullable: false, maxLength: 10),
                        email = c.String(nullable: false, maxLength: 30),
                        address = c.String(nullable: false, maxLength: 50),
                        userGroup_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserGroups", t => t.userGroup_id)
                .Index(t => t.userGroup_id);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 20),
                        category_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .Index(t => t.category_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubCategories", "category_id", "dbo.Categories");
            DropForeignKey("dbo.Stores", "userOwner_id", "dbo.Users");
            DropForeignKey("dbo.Users", "userGroup_id", "dbo.UserGroups");
            DropForeignKey("dbo.Products", "storeId", "dbo.Stores");
            DropForeignKey("dbo.Orders", "storeId", "dbo.Stores");
            DropForeignKey("dbo.Orders", "status_id", "dbo.Status");
            DropForeignKey("dbo.Orders", "product_id", "dbo.Products");
            DropIndex("dbo.SubCategories", new[] { "category_id" });
            DropIndex("dbo.Users", new[] { "userGroup_id" });
            DropIndex("dbo.Stores", new[] { "userOwner_id" });
            DropIndex("dbo.Products", new[] { "storeId" });
            DropIndex("dbo.Orders", new[] { "status_id" });
            DropIndex("dbo.Orders", new[] { "product_id" });
            DropIndex("dbo.Orders", new[] { "storeId" });
            DropTable("dbo.SubCategories");
            DropTable("dbo.UserGroups");
            DropTable("dbo.Users");
            DropTable("dbo.Stores");
            DropTable("dbo.Status");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Categories");
        }
    }
}
