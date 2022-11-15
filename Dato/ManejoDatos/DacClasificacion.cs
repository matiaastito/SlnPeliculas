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
    public class DacClasificacion
    {
        private static DBPeliculasContext context = new DBPeliculasContext();

        public static List<Clasificacion> Listar()
        {
            return context.Clasificaciones.ToList();
        }

        public static Clasificacion TraerUno(string tClasificacion)
        {
            List<Clasificacion> listClasificaciones = Listar();

            foreach (var clasificacion in listClasificaciones)
            {
                if (string.Compare(clasificacion.Tipo.ToLower(), tClasificacion.ToLower()) == 0)
                {
                    return clasificacion;
                }
            }
            return null;
        }
    }
}
