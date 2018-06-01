namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGrupoClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoClases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        asigDocenteId = c.Int(nullable: false),
                        aula = c.String(),
                        maxAlum = c.Int(nullable: false),
                        minAlum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AsignacionDocentes", t => t.asigDocenteId, cascadeDelete: true)
                .Index(t => t.asigDocenteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GrupoClases", "asigDocenteId", "dbo.AsignacionDocentes");
            DropIndex("dbo.GrupoClases", new[] { "asigDocenteId" });
            DropTable("dbo.GrupoClases");
        }
    }
}
