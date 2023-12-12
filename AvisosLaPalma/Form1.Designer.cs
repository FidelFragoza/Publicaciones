namespace AvisosLaPalma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoDeReferencia_Agregar = new System.Windows.Forms.TextBox();
            this.textCreador = new System.Windows.Forms.TextBox();
            this.richtextDescripcion = new System.Windows.Forms.RichTextBox();
            this.textCodigoDeReferencia_Eliminar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar publicación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Creador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eliminar publicación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codigo de referencia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCodigoDeReferencia_Agregar
            // 
            this.txtCodigoDeReferencia_Agregar.Location = new System.Drawing.Point(72, 148);
            this.txtCodigoDeReferencia_Agregar.MaxLength = 8;
            this.txtCodigoDeReferencia_Agregar.Name = "txtCodigoDeReferencia_Agregar";
            this.txtCodigoDeReferencia_Agregar.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeReferencia_Agregar.TabIndex = 6;
            // 
            // textCreador
            // 
            this.textCreador.Location = new System.Drawing.Point(215, 179);
            this.textCreador.MaxLength = 100;
            this.textCreador.Name = "textCreador";
            this.textCreador.Size = new System.Drawing.Size(100, 20);
            this.textCreador.TabIndex = 7;
            // 
            // richtextDescripcion
            // 
            this.richtextDescripcion.Location = new System.Drawing.Point(119, 274);
            this.richtextDescripcion.Name = "richtextDescripcion";
            this.richtextDescripcion.Size = new System.Drawing.Size(300, 89);
            this.richtextDescripcion.TabIndex = 8;
            this.richtextDescripcion.Text = "";
            // 
            // textCodigoDeReferencia_Eliminar
            // 
            this.textCodigoDeReferencia_Eliminar.Location = new System.Drawing.Point(590, 151);
            this.textCodigoDeReferencia_Eliminar.MaxLength = 8;
            this.textCodigoDeReferencia_Eliminar.Name = "textCodigoDeReferencia_Eliminar";
            this.textCodigoDeReferencia_Eliminar.Size = new System.Drawing.Size(100, 20);
            this.textCodigoDeReferencia_Eliminar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Codigo de referencia";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(352, 148);
            this.textTitulo.MaxLength = 100;
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(100, 20);
            this.textTitulo.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.Location = new System.Drawing.Point(146, 394);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEliminar.Location = new System.Drawing.Point(605, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textCodigoDeReferencia_Eliminar);
            this.Controls.Add(this.richtextDescripcion);
            this.Controls.Add(this.textCreador);
            this.Controls.Add(this.txtCodigoDeReferencia_Agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoDeReferencia_Agregar;
        private System.Windows.Forms.TextBox textCreador;
        private System.Windows.Forms.RichTextBox richtextDescripcion;
        private System.Windows.Forms.TextBox textCodigoDeReferencia_Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

