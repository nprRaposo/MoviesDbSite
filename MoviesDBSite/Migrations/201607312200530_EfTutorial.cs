namespace MoviesDBSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EfTutorial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Movies", newName: "Movie");
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Character",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        ActorId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actor", t => t.ActorId, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.ActorId);
            
            AddColumn("dbo.Movie", "DirectorId", c => c.Int(nullable: false));
            DropColumn("dbo.Movie", "Director");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Director", c => c.String(nullable: false, maxLength: 60));
            DropForeignKey("dbo.Character", "MovieId", "dbo.Movie");
            DropForeignKey("dbo.Character", "ActorId", "dbo.Actor");
            DropIndex("dbo.Character", new[] { "ActorId" });
            DropIndex("dbo.Character", new[] { "MovieId" });
            DropColumn("dbo.Movie", "DirectorId");
            DropTable("dbo.Character");
            DropTable("dbo.Actor");
            RenameTable(name: "dbo.Movie", newName: "Movies");
        }
    }
}
