using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias para conectar con el servidor
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AvisosLaPalma
{
    internal class Conexion
    {
        //Crear objetos, Dentro de clase Conexión
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Conexion()
        {
            try
            {
                //Declarar la cadena (objeto) de conexión al servidor
                cn = new SqlConnection("Data Source=DESKTOP-4SJDRKO\\SQLEXPRESS;Initial Catalog=AvisosLaPalma;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó con la base de datos: " + ex.ToString());
            }
        }

        //Metodo para guardar
        public string insertarSP(string ID, string Titulo, string Descripcion, string Creador)
        {
            string salida = "Se insertó Registro";
            try
            {
                //Crear un Objeto comando
                    //Nombre del procedimiento almacenado  
                SqlCommand cmd = new SqlCommand("dbo.SP_AgregarPublicacion", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //limpian los parámetros
                cmd.Parameters.Clear();

                    //Mandar los parametros al procedimiento almacenado a paritr de las variables de la aplicación
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@Titulo", Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Creador", Creador);
                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        //Metodo para eliminar
        public string eliminarSp(string ID)
        {
            string salida = "Se eliminó Registro";
            try
            {
                //Crear un Objeto comando
                //Nombre del procedimiento almacenado  
                SqlCommand cmd = new SqlCommand("dbo.SP_EliminarPublicacion", cn);
                //Indicar que sera Store Procedure
                cmd.CommandType = CommandType.StoredProcedure;
                //limpian los parámetros
                cmd.Parameters.Clear();

                //Mandar los parametros al procedimiento almacenado a paritr de las variables de la aplicación
                cmd.Parameters.AddWithValue("@ID", ID);
                //Ejecutar la sentencia sql en el servidor
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
    }
}
