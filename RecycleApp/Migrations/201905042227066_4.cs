namespace RecycleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Trash", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.User", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "userName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "password", c => c.String());
            AlterColumn("dbo.User", "userName", c => c.String());
            AlterColumn("dbo.User", "lastName", c => c.String());
            AlterColumn("dbo.User", "firstName", c => c.String());
            AlterColumn("dbo.Trash", "Name", c => c.String());
            AlterColumn("dbo.Category", "Name", c => c.String());
        }
    }
}
