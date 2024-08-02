using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Travesía_por_la_jungla
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
            
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FrmAboutIt frm = new FrmAboutIt();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();          
                        
        }

        private void FrmDatos_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Exit frm = new Exit();
            DialogResult respueta = frm.ShowDialog();
            if (respueta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            btnCerrar.ImageIndex = 0;
            MostrarHora();
            MoverFondos(timerFondos);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            ComoJugar frm = new ComoJugar();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComoJugar frm = new ComoJugar();
            frm.ShowDialog();
            frm.Dispose();
        }

        
        Introducir f;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            f = new Introducir();
            this.Visible = false;           
            f.ShowDialog();
            this.Dispose();
            this.Close();
            f.Dispose();
            Application.ExitThread();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            Opciones frmOpc = new Opciones();
            frmOpc.ShowDialog();
            frmOpc.Dispose();
        }

        public void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHora();
        }
        Random r = new Random();
        int fondo;
        public void MoverFondos(Timer crono)
        {
            fondo=0;
            fondo = r.Next(0,7);
            if (fondo==0)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.CPMO;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (fondo==1)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.JUWY;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (fondo==2)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.natural_1024x768;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (fondo==3)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.Nature;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (fondo==4)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.NZNM;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            if (fondo==5)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.QCOO;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }            
            if (fondo==6)
            {
                this.BackgroundImage = global::Travesía_por_la_jungla.Properties.Resources.TAFR;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
        }

        private void timerFondos_Tick(object sender, EventArgs e)
        {
            MoverFondos(timerFondos);
        }
    }
}
