namespace MVCProjetoEmpresa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmpresa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        dtFundacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
