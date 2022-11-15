
using LibPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DBDatos
{
    public class DBPeliculasContext : DbContext
    {
        public DBPeliculasContext() : base ("KeyDbPeliculas") { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Clasificacion> Clasificaciones { get;set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            //Asignacion nombre de tablas
            modelBuilder.Entity<Pelicula>().ToTable("Peliculas");
            modelBuilder.Entity<Genero>().ToTable("Generos");
            modelBuilder.Entity<Clasificacion>().ToTable("Clasificaciones");

            //Modelacion de las propiedades

            modelBuilder.Entity<Pelicula>().HasKey(e => e.Id);
            modelBuilder.Entity<Pelicula>().Property(e => e.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(e => e.FechaEstreno).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(e => e.Idioma).HasColumnType("varchar").HasMaxLength(15).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(e => e.Sinopsis).HasColumnType("varchar").HasMaxLength(200).IsRequired();


            modelBuilder.Entity<Genero>().HasKey(e => e.Id);
            modelBuilder.Entity<Genero>().Property(e => e.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Genero>().HasMany(c => c.PeliculaList).WithRequired(e => e.Genero);

            modelBuilder.Entity<Clasificacion>().HasKey(e => e.Id);
            modelBuilder.Entity<Clasificacion>().Property(e => e.Descripcion).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Clasificacion>().Property(e => e.Tipo).HasColumnType("varchar").HasMaxLength(3).IsRequired();
            modelBuilder.Entity<Clasificacion>().HasMany(c => c.PeliculaList).WithRequired(e => e.Clasificacion);

        }

    }
}
