using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvisosLaPalma
{
    public partial class Publicaciones : Form
    {
        private Inicio_de_sesión formularioInicioSesion;

        public Publicaciones(Inicio_de_sesión inicioSesionForm)
        {
            InitializeComponent();
            formularioInicioSesion = inicioSesionForm;
        }
        
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-4SJDRKO\\SQLEXPRESS;Initial Catalog=AvisosLaPalma;Integrated Security=True");
        private void Publicaciones_Load(object sender, EventArgs e)
        {
            string consulta = "select * from publicaciones";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BottonRegresarMenu_Click(object sender, EventArgs e)
        {
            Menu loginSuccess = new Menu(formularioInicioSesion);
            this.Hide();
            loginSuccess.Show();
        }
    }
}
