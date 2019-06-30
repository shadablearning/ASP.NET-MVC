namespace MusicStoreWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCustomerSubsribedToNewLetter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewLetter");
        }
    }
}
