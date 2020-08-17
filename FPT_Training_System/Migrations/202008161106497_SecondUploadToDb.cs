namespace FPT_Training_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondUploadToDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "Age");
            DropColumn("dbo.AspNetUsers", "emailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "emailAddress", c => c.String());
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
