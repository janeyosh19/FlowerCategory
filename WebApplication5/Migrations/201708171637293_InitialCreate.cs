namespace WebApplication5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                    })
                .PrimaryKey(t => t.CardId);
            
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        FlowerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Cost = c.Single(nullable: false),
                        Quantity = c.Int(nullable: false),
                        FlowerType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FlowerId);
            
            CreateTable(
                "dbo.Wrappings",
                c => new
                    {
                        WrappingId = c.Int(nullable: false, identity: true),
                        WrapperName = c.String(),
                    })
                .PrimaryKey(t => t.WrappingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wrappings");
            DropTable("dbo.Flowers");
            DropTable("dbo.Cards");
        }
    }
}
