namespace DatabaseActivities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Weather : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Weathers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        high = c.Double(nullable: false),
                        low = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Weathers");
        }
    }
}
