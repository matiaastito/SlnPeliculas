
using Datos.DBDatos;
using LibPeliculas;
using LibPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ManejoDatos
{
    public static class DacGenero 
    {
        private static DBPeliculasContext context = new DBPeliculasContext();

        public static List<Genero> Listar()
        {
            return context.Generos.ToList();
        }
        public static void Insertar() { }
        public static void Modificar() { }
        public static void Eliminar() { }
        public static Genero TraerUno(string nGenero) 
        {
            List<Genero> listGeneros = Listar();

            foreach (var genero in listGeneros)
            {
                if (string.Compare(genero.Nombre.ToLower(), nGenero.ToLower()) == 0)
                {
                    return genero;
                }
            }
            return null;
        }
    }
}
