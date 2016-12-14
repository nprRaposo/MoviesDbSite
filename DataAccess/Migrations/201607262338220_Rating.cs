namespace MoviesDBSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Director", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Director");
        }
    }
}
