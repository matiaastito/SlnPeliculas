using LibPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPeliculas
{
    public class Pelicula
    {
        #region const
        public Pelicula(string nombre, DateTime fechaEstreno, int cantidadMinutos, string idioma, string sinopsis, Genero genero, Clasificacion clasificacion)
        {
          
            Nombre = nombre;
            FechaEstreno = fechaEstreno;
            CantidadMinutos = cantidadMinutos;
            Idioma = idioma;
            Sinopsis = sinopsis;
            Genero = genero;
            Clasificacion = clasificacion;
        }
        #endregion



        #region props
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public int CantidadMinutos { get; set; }
        public string Idioma { get; set; }
        public string Sinopsis { get; set; }

        

        #endregion

        #region Props nav
        public Genero Genero { get; set; }
        public Clasificacion Clasificacion { get; set; }
        #endregion


    }
}
