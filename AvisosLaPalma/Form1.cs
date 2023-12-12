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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                //Crea Objeto conexion
                Conexion c = new Conexion();
                //Instanciar
                MessageBox.Show(c.insertarSP(txtCodigoDeReferencia_Agregar.Text, textTitulo.Text, richtextDescripcion.Text, textCreador.Text));
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (textCodigoDeReferencia_Eliminar.Text != null)
            {
                //Crea Objeto conexion
                Conexion c = new Conexion();
                //Instanciar
                MessageBox.Show(c.eliminarSp(textCodigoDeReferencia_Eliminar.Text));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoDeReferencia_Agregar.Text = null;
            textTitulo.Text = null;
            richtextDescripcion.Text = null;
            textCreador.Text = null;
        }
    }
}
