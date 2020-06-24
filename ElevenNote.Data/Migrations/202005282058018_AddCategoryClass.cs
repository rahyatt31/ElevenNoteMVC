namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        OwnerID = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CreatedUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            AddColumn("dbo.Note", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Note", "CategoryID");
            AddForeignKey("dbo.Note", "CategoryID", "dbo.Category", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "CategoryID", "dbo.Category");
            DropIndex("dbo.Note", new[] { "CategoryID" });
            DropColumn("dbo.Note", "CategoryID");
            DropTable("dbo.Category");
        }
    }
}
