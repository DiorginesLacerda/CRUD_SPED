namespace TesteSPED.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ESTADOS_IBGE",
                c => new
                    {
                        COD_ESTADO = c.Int(nullable: false, identity: true),
                        SIGLA_ESTADO = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.COD_ESTADO);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        COD_MUNICIPIO = c.Long(nullable: false, identity: true),
                        NOME_MUNICIPIO = c.String(nullable: false),
                        COD_ESTADO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.COD_MUNICIPIO)
                .ForeignKey("dbo.ESTADOS_IBGE", t => t.COD_ESTADO, cascadeDelete: true)
                .Index(t => t.COD_ESTADO);
            
            CreateTable(
                "dbo.PAIS_IBGE",
                c => new
                    {
                        COD_PAIS = c.String(nullable: false, maxLength: 128),
                        NOME_PAIS = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.COD_PAIS);
            
            CreateTable(
                "dbo.Participante",
                c => new
                    {
                        REG = c.String(nullable: false, maxLength: 4),
                        COD_PART = c.String(nullable: false, maxLength: 60),
                        NOME = c.String(nullable: false, maxLength: 100),
                        COD_PAIS = c.String(nullable: false, maxLength: 128),
                        CNPJ = c.String(maxLength: 14),
                        CPF = c.String(maxLength: 11),
                        IE = c.String(maxLength: 14),
                        COD_MUN = c.String(maxLength: 7),
                        SUFRAMA = c.String(maxLength: 9),
                        END = c.String(nullable: false, maxLength: 60),
                        NUM = c.String(maxLength: 10),
                        COMPL = c.String(maxLength: 60),
                        BAIRRO = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.COD_PART)
                .ForeignKey("dbo.PAIS_IBGE", t => t.COD_PAIS, cascadeDelete: true)
                .Index(t => t.COD_PAIS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participante", "COD_PAIS", "dbo.PAIS_IBGE");
            DropForeignKey("dbo.Municipios", "COD_ESTADO", "dbo.ESTADOS_IBGE");
            DropIndex("dbo.Participante", new[] { "COD_PAIS" });
            DropIndex("dbo.Municipios", new[] { "COD_ESTADO" });
            DropTable("dbo.Participante");
            DropTable("dbo.PAIS_IBGE");
            DropTable("dbo.Municipios");
            DropTable("dbo.ESTADOS_IBGE");
        }
    }
}
