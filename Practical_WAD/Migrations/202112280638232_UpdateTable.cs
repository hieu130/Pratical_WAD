namespace Practical_WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "Duration", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exams", "Duration", c => c.Int(nullable: false));
        }
    }
}
