namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatriculas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        grupoClaseId = c.Int(nullable: false),
                        cursoId = c.Int(nullable: false),
                        fechaMatricula = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.cursoId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoClases", t => t.grupoClaseId, cascadeDelete: false)
                .Index(t => t.grupoClaseId)
                .Index(t => t.cursoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "grupoClaseId", "dbo.GrupoClases");
            DropForeignKey("dbo.Matriculas", "cursoId", "dbo.Cursos");
            DropIndex("dbo.Matriculas", new[] { "cursoId" });
            DropIndex("dbo.Matriculas", new[] { "grupoClaseId" });
            DropTable("dbo.Matriculas");
        }
    }
}
