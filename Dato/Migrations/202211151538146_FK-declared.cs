namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKdeclared : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Peliculas", name: "Clasificacion_Id", newName: "ClasificacionId");
            RenameColumn(table: "dbo.Peliculas", name: "Genero_Id", newName: "GeneroId");
            RenameIndex(table: "dbo.Peliculas", name: "IX_Genero_Id", newName: "IX_GeneroId");
            RenameIndex(table: "dbo.Peliculas", name: "IX_Clasificacion_Id", newName: "IX_ClasificacionId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Peliculas", name: "IX_ClasificacionId", newName: "IX_Clasificacion_Id");
            RenameIndex(table: "dbo.Peliculas", name: "IX_GeneroId", newName: "IX_Genero_Id");
            RenameColumn(table: "dbo.Peliculas", name: "GeneroId", newName: "Genero_Id");
            RenameColumn(table: "dbo.Peliculas", name: "ClasificacionId", newName: "Clasificacion_Id");
        }
    }
}
