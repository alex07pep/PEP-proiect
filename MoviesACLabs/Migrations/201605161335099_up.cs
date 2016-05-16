namespace MoviesACLabs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Award", "ActorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Award", "ActorName");
        }
    }
}
