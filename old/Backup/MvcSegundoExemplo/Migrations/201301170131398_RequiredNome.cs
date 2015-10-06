namespace MvcSegundoExemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredNome : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Nome", c => c.String());
        }
    }
}
