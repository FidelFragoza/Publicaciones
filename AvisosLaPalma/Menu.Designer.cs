namespace AvisosLaPalma
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMenuAgregaryEliminar = new System.Windows.Forms.Button();
            this.buttonMenuVerPublicaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMenuAgregaryEliminar
            // 
            this.buttonMenuAgregaryEliminar.Location = new System.Drawing.Point(156, 168);
            this.buttonMenuAgregaryEliminar.Name = "buttonMenuAgregaryEliminar";
            this.buttonMenuAgregaryEliminar.Size = new System.Drawing.Size(182, 102);
            this.buttonMenuAgregaryEliminar.TabIndex = 0;
            this.buttonMenuAgregaryEliminar.Text = "Agregar y eliminar";
            this.buttonMenuAgregaryEliminar.UseVisualStyleBackColor = true;
            this.buttonMenuAgregaryEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMenuVerPublicaciones
            // 
            this.buttonMenuVerPublicaciones.Location = new System.Drawing.Point(433, 168);
            this.buttonMenuVerPublicaciones.Name = "buttonMenuVerPublicaciones";
            this.buttonMenuVerPublicaciones.Size = new System.Drawing.Size(181, 102);
            this.buttonMenuVerPublicaciones.TabIndex = 1;
            this.buttonMenuVerPublicaciones.Text = "Ver reportes";
            this.buttonMenuVerPublicaciones.UseVisualStyleBackColor = true;
            this.buttonMenuVerPublicaciones.Click += new System.EventHandler(this.buttonMenuVerPublicaciones_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenuVerPublicaciones);
            this.Controls.Add(this.buttonMenuAgregaryEliminar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenuAgregaryEliminar;
        private System.Windows.Forms.Button buttonMenuVerPublicaciones;
    }
}