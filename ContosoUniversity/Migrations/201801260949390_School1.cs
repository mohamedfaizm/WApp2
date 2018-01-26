namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class School1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Gender", c => c.String());
            AddColumn("dbo.Student", "PhoneNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "PhoneNumber");
            DropColumn("dbo.Student", "Gender");
        }
    }
}
