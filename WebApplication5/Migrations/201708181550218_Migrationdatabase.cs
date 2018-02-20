namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrationdatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Flowers", "Cost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Flowers", "Cost", c => c.Single(nullable: false));
        }
    }
}
