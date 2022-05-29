namespace Chat.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Primer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Primer");
        }
    }
}
