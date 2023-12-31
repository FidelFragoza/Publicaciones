﻿using System;
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
    public partial class Agregar_y_Eliminar : Form
    {
        private Inicio_de_sesión formularioInicioSesion;

        public Agregar_y_Eliminar(Inicio_de_sesión inicioSesionForm)
        {
            InitializeComponent();
            formularioInicioSesion = inicioSesionForm;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (txtCodigoDeReferencia_Agregar.Text != null)
            {
                // Crea Objeto conexion
                Conexion c = new Conexion();

                // Obtén el nombre de usuario desde la propiedad NombreUsuario de Inicio_de_sesión
                string nombreUsuario = formularioInicioSesion.NombreUsuario;

                // Instanciar
                MessageBox.Show(c.insertarSP(txtCodigoDeReferencia_Agregar.Text, textTitulo.Text, richtextDescripcion.Text, nombreUsuario));

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (textCodigoDeReferencia_Eliminar.Text != null)
            {
                //Crea Objeto conexion
                Conexion c = new Conexion();
                // Obtén el nombre de usuario desde la propiedad NombreUsuario de Inicio_de_sesión
                string nombreUsuario = formularioInicioSesion.NombreUsuario;
                //Instanciar
                MessageBox.Show(c.eliminarSp(textCodigoDeReferencia_Eliminar.Text, nombreUsuario));

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoDeReferencia_Agregar.Text = null;
            textTitulo.Text = null;
            richtextDescripcion.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu loginSuccess = new Menu(formularioInicioSesion);
            this.Hide();
            loginSuccess.Show();
        }
    }
}
