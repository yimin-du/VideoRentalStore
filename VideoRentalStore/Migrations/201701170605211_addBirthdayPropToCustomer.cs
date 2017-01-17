namespace VideoRentalStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthdayPropToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthday");
        }
    }
}
