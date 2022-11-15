using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPeliculas.Models
{
    public class Clasificacion
    {
        #region props
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        #endregion

        #region props nav
        public List <Pelicula> PeliculaList { get; set;}
        #endregion
    }
}
