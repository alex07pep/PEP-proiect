namespace MoviesACLabs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Award1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Actor", "Award_Id", c => c.Int());
            CreateIndex("dbo.Actor", "Award_Id");
            AddForeignKey("dbo.Actor", "Award_Id", "dbo.Award", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actor", "Award_Id", "dbo.Award");
            DropIndex("dbo.Actor", new[] { "Award_Id" });
            DropColumn("dbo.Actor", "Award_Id");
        }
    }
}
