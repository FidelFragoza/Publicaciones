using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AvisosLaPalma
{
    public partial class Inicio_de_sesión : Form
    {
        public Inicio_de_sesión()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection c = new SqlConnection("Data Source=DESKTOP-4SJDRKO\\SQLEXPRESS;Initial Catalog=AvisosLaPalma;Integrated Security=True");
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            c.Open();
            string consulta = "select * from USUARIOS WHERE UserName='"+textBoxUserName.Text+"' AND Password='"+textBoxPassword.Text+"'";
            SqlCommand comando = new SqlCommand(consulta, c);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido usuario");
                Menu LoginSuccess = new Menu();
                this.Hide();
                LoginSuccess.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            c.Close();
        }

        private void Inicio_de_sesión_Load(object sender, EventArgs e)
        {

        }
    }
}
