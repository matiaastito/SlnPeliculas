using Datos.DBDatos;
using LibPeliculas;
using LibPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ManejoDatos
{
    public static class DacPelicula
    {
        private static DBPeliculasContext context = new DBPeliculasContext();

        public static List<Pelicula> Listar()
        {
            List<Pelicula> lisPeliculas = context.Peliculas.ToList();
            return lisPeliculas;
        }
        public static string Insertar(Pelicula pelicula) 
        {
            context.Peliculas.Add(pelicula);
            string error = "";
            try
            {
                int filasAfectadas = context.SaveChanges();
                return Convert.ToString(filasAfectadas);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        error +=("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                return error;
            }
                
                
            
            
        }
        public static int Modificar(Pelicula pelicula)
        {
            Pelicula peliculaDB = TraerUno(pelicula.Id);
            if (peliculaDB != null) 
            { 
                peliculaDB.Id = pelicula.Id;
                peliculaDB.Nombre = pelicula.Nombre;
                peliculaDB.FechaEstreno= pelicula.FechaEstreno;
                peliculaDB.CantidadMinutos = pelicula.CantidadMinutos;
                peliculaDB.Idioma = pelicula.Idioma;
                peliculaDB.Sinopsis= pelicula.Sinopsis;
                int filasAfectadas = context.SaveChanges();
                return filasAfectadas;
            }
            else
            {
                return 0;
            }
        }
        public static int Eliminar(int Id) 
        {
            context.Peliculas.Remove(TraerUno(Id));
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }
        public static Pelicula TraerUno(int Id) 
        {
            return context.Peliculas.Find(Id);
        }

        public static List <Pelicula> TraerXGenero (Genero genero)
        {
           List<Pelicula> list = context.Peliculas.ToList();
            List<Pelicula> listXGenero = new List<Pelicula>();  
            foreach (var pelicula in list)
            {
                if (pelicula.Genero == genero)
                {
                    listXGenero.Add(pelicula);
                }
            }
            return listXGenero;
        }
    }
}
