namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student546 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Status", c => c.String());
            DropColumn("dbo.Student", "Gender");
            DropColumn("dbo.Student", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "Gender", c => c.String());
            DropColumn("dbo.Student", "Status");
        }
    }
}
