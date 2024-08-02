namespace Travesía_por_la_jungla
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerOne = new System.Windows.Forms.Timer(this.components);
            this.btnStopMusic = new System.Windows.Forms.Button();
            this.btnReanudarMusic = new System.Windows.Forms.Button();
            this.lblDado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblJug1 = new System.Windows.Forms.Label();
            this.lblJug2 = new System.Windows.Forms.Label();
            this.lblJug3 = new System.Windows.Forms.Label();
            this.lblJug4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDado = new System.Windows.Forms.Button();
            this.junglaVisual = new JPUtil.ColorTable();
            this.timerTwo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerOne
            // 
            this.timerOne.Enabled = true;
            this.timerOne.Tick += new System.EventHandler(this.timerOne_Tick);
            // 
            // btnStopMusic
            // 
            this.btnStopMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopMusic.Location = new System.Drawing.Point(851, 80);
            this.btnStopMusic.Name = "btnStopMusic";
            this.btnStopMusic.Size = new System.Drawing.Size(100, 23);
            this.btnStopMusic.TabIndex = 1;
            this.btnStopMusic.Text = "Parar música";
            this.btnStopMusic.UseVisualStyleBackColor = true;
            this.btnStopMusic.Click += new System.EventHandler(this.btnStopMusic_Click);
            // 
            // btnReanudarMusic
            // 
            this.btnReanudarMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReanudarMusic.Location = new System.Drawing.Point(851, 48);
            this.btnReanudarMusic.Name = "btnReanudarMusic";
            this.btnReanudarMusic.Size = new System.Drawing.Size(100, 26);
            this.btnReanudarMusic.TabIndex = 2;
            this.btnReanudarMusic.Text = "Reanudar música";
            this.btnReanudarMusic.UseVisualStyleBackColor = true;
            this.btnReanudarMusic.Click += new System.EventHandler(this.btnReanudarMusic_Click);
            // 
            // lblDado
            // 
            this.lblDado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDado.AutoSize = true;
            this.lblDado.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado.Location = new System.Drawing.Point(879, 133);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(0, 49);
            this.lblDado.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(851, 571);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoBack.Location = new System.Drawing.Point(851, 210);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(100, 23);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "Volver a jugar";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblJug1
            // 
            this.lblJug1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJug1.AutoSize = true;
            this.lblJug1.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug1.Location = new System.Drawing.Point(834, 428);
            this.lblJug1.Name = "lblJug1";
            this.lblJug1.Size = new System.Drawing.Size(78, 20);
            this.lblJug1.TabIndex = 7;
            this.lblJug1.Text = "Jugador 1";
            // 
            // lblJug2
            // 
            this.lblJug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJug2.AutoSize = true;
            this.lblJug2.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug2.Location = new System.Drawing.Point(834, 458);
            this.lblJug2.Name = "lblJug2";
            this.lblJug2.Size = new System.Drawing.Size(78, 20);
            this.lblJug2.TabIndex = 8;
            this.lblJug2.Text = "Jugador 2";
            // 
            // lblJug3
            // 
            this.lblJug3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJug3.AutoSize = true;
            this.lblJug3.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug3.Location = new System.Drawing.Point(834, 488);
            this.lblJug3.Name = "lblJug3";
            this.lblJug3.Size = new System.Drawing.Size(78, 20);
            this.lblJug3.TabIndex = 9;
            this.lblJug3.Text = "Jugador 3";
            this.lblJug3.Visible = false;
            // 
            // lblJug4
            // 
            this.lblJug4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJug4.AutoSize = true;
            this.lblJug4.Font = new System.Drawing.Font("Monotype Corsiva", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug4.Location = new System.Drawing.Point(834, 518);
            this.lblJug4.Name = "lblJug4";
            this.lblJug4.Size = new System.Drawing.Size(78, 20);
            this.lblJug4.TabIndex = 10;
            this.lblJug4.Text = "Jugador 4";
            this.lblJug4.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Picture1.gif");
            this.imageList1.Images.SetKeyName(1, "Picture2.gif");
            // 
            // btnDado
            // 
            this.btnDado.BackColor = System.Drawing.SystemColors.Control;
            this.btnDado.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.Picture21;
            this.btnDado.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDado.ForeColor = System.Drawing.Color.White;
            this.btnDado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDado.ImageIndex = 1;
            this.btnDado.Location = new System.Drawing.Point(851, 252);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(110, 148);
            this.btnDado.TabIndex = 3;
            this.btnDado.Text = "&Tirar dado";
            this.btnDado.UseVisualStyleBackColor = false;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click);
            // 
            // junglaVisual
            // 
            this.junglaVisual.AutoScroll = true;
            this.junglaVisual.AutoScrollMinSize = new System.Drawing.Size(676, 586);
            this.junglaVisual.BackColor = System.Drawing.Color.Transparent;
            this.junglaVisual.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.SBZT;
            this.junglaVisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.junglaVisual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.junglaVisual.CellSize = 45;
            this.junglaVisual.CirclesLineColor = System.Drawing.Color.DarkRed;
            this.junglaVisual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.junglaVisual.GridLineColor = System.Drawing.Color.Black;
            this.junglaVisual.ImageCellSize = 24;
            this.junglaVisual.Location = new System.Drawing.Point(0, 0);
            this.junglaVisual.Name = "junglaVisual";
            this.junglaVisual.Size = new System.Drawing.Size(684, 594);
            this.junglaVisual.TabIndex = 0;
            this.junglaVisual.TableHeight = 13;
            this.junglaVisual.TableWidth = 15;
            this.junglaVisual.TabStop = true;
            // 
            // timerTwo
            // 
            this.timerTwo.Enabled = true;
            this.timerTwo.Interval = 2000;
            this.timerTwo.Tick += new System.EventHandler(this.timerTwo_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(929, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(930, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "1";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1026, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJug4);
            this.Controls.Add(this.lblJug3);
            this.Controls.Add(this.lblJug2);
            this.Controls.Add(this.lblJug1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDado);
            this.Controls.Add(this.btnDado);
            this.Controls.Add(this.btnReanudarMusic);
            this.Controls.Add(this.btnStopMusic);
            this.Controls.Add(this.junglaVisual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timerOne;
        private System.Windows.Forms.Button btnStopMusic;
        private System.Windows.Forms.Button btnReanudarMusic;
        private System.Windows.Forms.Button btnDado;
        private System.Windows.Forms.Label lblDado;
        internal JPUtil.ColorTable junglaVisual;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblJug1;
        private System.Windows.Forms.Label lblJug2;
        private System.Windows.Forms.Label lblJug3;
        private System.Windows.Forms.Label lblJug4;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Timer timerTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}