namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCourse : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            CreateIndex("dbo.Courses", "Categoryid");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "Categoryid" });
            CreateIndex("dbo.Courses", "CategoryId");
        }
    }
}
