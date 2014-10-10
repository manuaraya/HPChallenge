namespace RPSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tournament",
                c => new
                    {
                        playerName = c.String(nullable: false, maxLength: 128),
                        points = c.Int(),
                    })
                .PrimaryKey(t => t.playerName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tournament");
        }
    }
}
