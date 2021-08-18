﻿namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableSituations : DbMigration
    {
        public override void Up()
        {
            

            CreateTable(
                "dbo.Situations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Situations");
            DropTable("dbo.Avaliations");
        }
    }
}