namespace Jysan.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Individuals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Patronymic = c.String(),
                        Iin = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        LegalEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LegalEntities", t => t.LegalEntity_Id)
                .Index(t => t.LegalEntity_Id);
            
            CreateTable(
                "dbo.LegalEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Iin = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Individuals", "LegalEntity_Id", "dbo.LegalEntities");
            DropIndex("dbo.Individuals", new[] { "LegalEntity_Id" });
            DropTable("dbo.LegalEntities");
            DropTable("dbo.Individuals");
        }
    }
}
