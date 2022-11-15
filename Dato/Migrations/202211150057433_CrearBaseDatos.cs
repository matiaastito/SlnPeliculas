namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clasificaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 3, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaEstreno = c.DateTime(nullable: false),
                        CantidadMinutos = c.Int(nullable: false),
                        Idioma = c.String(nullable: false, maxLength: 15, unicode: false),
                        Sinopsis = c.String(nullable: false, maxLength: 200, unicode: false),
                        Genero_Id = c.Int(nullable: false),
                        Clasificacion_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Generos", t => t.Genero_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clasificaciones", t => t.Clasificacion_Id, cascadeDelete: true)
                .Index(t => t.Genero_Id)
                .Index(t => t.Clasificacion_Id);
            
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Peliculas", "Clasificacion_Id", "dbo.Clasificaciones");
            DropForeignKey("dbo.Peliculas", "Genero_Id", "dbo.Generos");
            DropIndex("dbo.Peliculas", new[] { "Clasificacion_Id" });
            DropIndex("dbo.Peliculas", new[] { "Genero_Id" });
            DropTable("dbo.Generos");
            DropTable("dbo.Peliculas");
            DropTable("dbo.Clasificaciones");
        }
    }
}
