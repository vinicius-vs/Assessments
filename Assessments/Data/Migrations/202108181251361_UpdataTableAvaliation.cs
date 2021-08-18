namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdataTableAvaliation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Avaliations", "Criteria_Id", c => c.Int());
            CreateIndex("dbo.Avaliations", "Criteria_Id");
            AddForeignKey("dbo.Avaliations", "Criteria_Id", "dbo.Criteria", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avaliations", "Criteria_Id", "dbo.Criteria");
            DropIndex("dbo.Avaliations", new[] { "Criteria_Id" });
            DropColumn("dbo.Avaliations", "Criteria_Id");
        }
    }
}
