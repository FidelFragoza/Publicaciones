using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisosLaPalma
{
    public partial class Menu : Form
    {

        private Inicio_de_sesión formularioInicioSesion;
        public Menu(Inicio_de_sesión inicioSesionForm)
        {
            InitializeComponent();
            formularioInicioSesion = inicioSesionForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pasar la instancia del formulario de inicio de sesión al formulario Agregar_y_Eliminar
            Agregar_y_Eliminar agregarEliminarForm = new Agregar_y_Eliminar(formularioInicioSesion);
            this.Hide();
            agregarEliminarForm.Show();
        }

        private void buttonMenuVerPublicaciones_Click(object sender, EventArgs e)
        {
            
        }
    }
}
