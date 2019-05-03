namespace RecycleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "Name", c => c.String());
            DropColumn("dbo.Category", "ImgPath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "ImgPath", c => c.String());
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false));
        }
    }
}
