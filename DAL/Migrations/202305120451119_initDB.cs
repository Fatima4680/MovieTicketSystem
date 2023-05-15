namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ManagerId = c.String(nullable: false, maxLength: 128),
                        MName = c.String(nullable: false),
                        MEmail = c.String(nullable: false),
                        MPhone = c.Int(nullable: false),
                        MGender = c.String(nullable: false),
                        MPassword = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ManagerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Managers");
        }
    }
}
