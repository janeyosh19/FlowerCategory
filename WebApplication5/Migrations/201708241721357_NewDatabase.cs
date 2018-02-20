namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flowers", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flowers", "Image");
        }
    }
}
