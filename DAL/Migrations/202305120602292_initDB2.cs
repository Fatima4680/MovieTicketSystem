namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SeatDetails",
                c => new
                    {
                        SeatId = c.String(nullable: false, maxLength: 128),
                        SRow = c.String(nullable: false),
                        SType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SeatId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SeatDetails");
        }
    }
}
