namespace Travesía_por_la_jungla
{
    partial class FrmAboutIt
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblFechaCreación = new System.Windows.Forms.Label();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(14, 25);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(522, 25);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Proyecto Final de Curso de la Carrera de Informática 1er año";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(62, 112);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(353, 72);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Producto realizado por:\r\n- Arián Castellanos\r\n\r\nAlumno del grupo de informática. " +
                "Curso 2015-2016.";
            // 
            // lblFechaCreación
            // 
            this.lblFechaCreación.AutoSize = true;
            this.lblFechaCreación.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreación.Location = new System.Drawing.Point(31, 294);
            this.lblFechaCreación.Name = "lblFechaCreación";
            this.lblFechaCreación.Size = new System.Drawing.Size(469, 22);
            this.lblFechaCreación.TabIndex = 2;
            this.lblFechaCreación.Text = "Producto creado el 5/7/2016. Todos los derechos reservados.";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(434, 63);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(102, 24);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Detalles >>";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(434, 350);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(102, 24);
            this.btnOcultar.TabIndex = 4;
            this.btnOcultar.Text = "Ocultar <<";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // FrmAboutIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 392);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.lblFechaCreación);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTítulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAboutIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.FrmAcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblFechaCreación;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnOcultar;
    }
}