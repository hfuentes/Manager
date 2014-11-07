namespace Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tienda", "AdministradorId", "dbo.AspNetUsers");
            DropIndex("dbo.Tienda", new[] { "AdministradorId" });
            AlterColumn("dbo.Tienda", "AdministradorId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tienda", "AdministradorId");
            AddForeignKey("dbo.Tienda", "AdministradorId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tienda", "AdministradorId", "dbo.AspNetUsers");
            DropIndex("dbo.Tienda", new[] { "AdministradorId" });
            AlterColumn("dbo.Tienda", "AdministradorId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Tienda", "AdministradorId");
            AddForeignKey("dbo.Tienda", "AdministradorId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
