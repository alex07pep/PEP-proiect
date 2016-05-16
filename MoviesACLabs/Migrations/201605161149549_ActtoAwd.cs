namespace MoviesACLabs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActtoAwd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Actor", "Award_Id", "dbo.Award");
            DropIndex("dbo.Actor", new[] { "Award_Id" });
            CreateTable(
                "dbo.AwardActor",
                c => new
                    {
                        Award_Id = c.Int(nullable: false),
                        Actor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Award_Id, t.Actor_Id })
                .ForeignKey("dbo.Award", t => t.Award_Id, cascadeDelete: true)
                .ForeignKey("dbo.Actor", t => t.Actor_Id, cascadeDelete: true)
                .Index(t => t.Award_Id)
                .Index(t => t.Actor_Id);
            
            DropColumn("dbo.Actor", "Award_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Actor", "Award_Id", c => c.Int());
            DropForeignKey("dbo.AwardActor", "Actor_Id", "dbo.Actor");
            DropForeignKey("dbo.AwardActor", "Award_Id", "dbo.Award");
            DropIndex("dbo.AwardActor", new[] { "Actor_Id" });
            DropIndex("dbo.AwardActor", new[] { "Award_Id" });
            DropTable("dbo.AwardActor");
            CreateIndex("dbo.Actor", "Award_Id");
            AddForeignKey("dbo.Actor", "Award_Id", "dbo.Award", "Id");
        }
    }
}
