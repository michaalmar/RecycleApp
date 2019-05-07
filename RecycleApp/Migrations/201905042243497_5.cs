namespace RecycleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "firstName", c => c.String());
            AlterColumn("dbo.User", "lastName", c => c.String());
            AlterColumn("dbo.User", "userName", c => c.String());
            AlterColumn("dbo.User", "password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "password", c => c.String(nullable: false));
            AlterColumn("dbo.User", "userName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "lastName", c => c.String(nullable: false));
            AlterColumn("dbo.User", "firstName", c => c.String(nullable: false));
        }
    }
}
