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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            FrmStart g = new FrmStart();
            g.SonidoJuego.Play();
            g.Dispose();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            FrmStart h = new FrmStart();
            h.SonidoJuego.Stop();
            h.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            
        }

        FrmStart h;
        private void lstMultimedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(lstMultimedia.SelectedIndex)
            {
                case 0:
                    h = new FrmStart();
                    h.SonidoJuego.Play();
                    h.Dispose();                                                    
                    break;
                case 1:
                    FrmStart i = new FrmStart();
                    i.SonidoJuego.Stop();
                    i.Carnaval.Play();
                    i.Dispose();
                    break;
                case 2:
                    FrmStart q = new FrmStart();
                    q.SonidoJuego.Stop();
                    q.Ginza.Play();
                    q.Dispose();
                    break;
                case 3:
                    FrmStart w = new FrmStart();
                    w.SonidoJuego.Stop();
                    w.Hastaq.Play();
                    w.Dispose();
                    break;
                case 4:
                    FrmStart z = new FrmStart();
                    z.SonidoJuego.Stop();
                    z.LaDura.Play();
                    z.Dispose();
                    break;
                case 5:
                    FrmStart t = new FrmStart();
                    t.SonidoJuego.Stop();
                    t.ParaQue.Play();
                    t.Dispose();
                    break;
                case 6:
                    FrmStart o = new FrmStart();
                    o.SonidoJuego.Stop();
                    o.Pelearnos.Play();
                    o.Dispose();
                    break;
                case 7:
                    FrmStart p = new FrmStart();
                    p.SonidoJuego.Stop();
                    p.Traidora.Play();
                    p.Dispose();
                    break; 
                case 8:
                    FrmStart r = new FrmStart();
                    r.SonidoJuego.Stop();
                    r.Todos.Play();
                    r.Dispose();
                    break;                 
            }
        }
    }
}
