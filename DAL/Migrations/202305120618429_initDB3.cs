namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        DiscountId = c.String(nullable: false, maxLength: 128),
                        DCode = c.String(nullable: false),
                        Percentage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DiscountId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Discounts");
        }
    }
}
