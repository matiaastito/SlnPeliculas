using Datos.ManejoDatos;
using LibPeliculas;
using LibPeliculas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsAppPeliculas
{
    public partial class frmPeliculas : Form
    {
        public frmPeliculas()
        {
            InitializeComponent();
            gridClasificaciones.DataSource = DacClasificacion.Listar();
            gridGeneros.DataSource = DacGenero.Listar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Genero genero = DacGenero.TraerUno(txtGenero.Text);
           while (genero == null )
            {
                MessageBox.Show("El genero ingresado no se encuentra en la lista. Por favor, ingrese otro.");
                genero = DacGenero.TraerUno(Interaction.InputBox("Genero"));

            }
            Clasificacion clasificacion = DacClasificacion.TraerUno(txtClasificacion.Text);
            while (clasificacion == null)
            {
                MessageBox.Show("El genero ingresado no se encuentra en la lista. Por favor, ingrese otro.");
                clasificacion = DacClasificacion.TraerUno(Interaction.InputBox("Clasificacion"));

            }

            MessageBox.Show(DacPelicula.Insertar(new Pelicula(txtNombre.Text, dateFechaEstreno.Value, Convert.ToInt32(txtDuracion.Text), txtIdioma.Text, txtSinopsis.Text, genero, clasificacion)));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            gridPeliculas.DataSource = DacPelicula.Listar();
        }
    }
}
