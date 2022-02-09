namespace EcommerceBase.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreField_ParentId_To_Category : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ParentId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ParentId");
        }
    }
}
