namespace LapBigSchool_ThaiAnhTu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Place", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "Pace");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Pace", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Courses", "Place");
        }
    }
}
