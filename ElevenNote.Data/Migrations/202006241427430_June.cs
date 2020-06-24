namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class June : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Note", "CategoryID", "dbo.Category");
            DropIndex("dbo.Note", new[] { "CategoryID" });
            RenameColumn(table: "dbo.Note", name: "CategoryID", newName: "Category_CategoryID");
            AlterColumn("dbo.Note", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Note", "Category_CategoryID");
            AddForeignKey("dbo.Note", "Category_CategoryID", "dbo.Category", "CategoryID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "Category_CategoryID", "dbo.Category");
            DropIndex("dbo.Note", new[] { "Category_CategoryID" });
            AlterColumn("dbo.Note", "Category_CategoryID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Note", name: "Category_CategoryID", newName: "CategoryID");
            CreateIndex("dbo.Note", "CategoryID");
            AddForeignKey("dbo.Note", "CategoryID", "dbo.Category", "CategoryID", cascadeDelete: true);
        }
    }
}
