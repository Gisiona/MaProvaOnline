namespace MaProvaOnline.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AltercaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pergunta",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DescricaoPergunta = c.String(nullable: false, maxLength: 100),
                        HashGuid = c.Guid(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        IsAtivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Resposta",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        HashGuid = c.Guid(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        IsAtivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Resposta");
            DropTable("dbo.Pergunta");
        }
    }
}
