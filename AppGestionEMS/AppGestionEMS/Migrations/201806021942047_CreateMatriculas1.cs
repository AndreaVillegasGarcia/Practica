namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatriculas1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "userId", c => c.Int(nullable: false));
            AddColumn("dbo.Matriculas", "applicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Matriculas", "applicationUser_Id");
            AddForeignKey("dbo.Matriculas", "applicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "applicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Matriculas", new[] { "applicationUser_Id" });
            DropColumn("dbo.Matriculas", "applicationUser_Id");
            DropColumn("dbo.Matriculas", "userId");
        }
    }
}
