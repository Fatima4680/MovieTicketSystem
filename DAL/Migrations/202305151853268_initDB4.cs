namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tokens", newName: "ManagerTokens");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ManagerTokens", newName: "Tokens");
        }
    }
}
