using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Travesía_por_la_jungla
{
    public partial class FrmStart : Form
    {
        SoundPlayer sonidoJuego = new SoundPlayer("Músik/Welcome to the Jungle.wav");
        SoundPlayer carnaval = new SoundPlayer("Músik/Carnaval.wav");
        SoundPlayer ginza = new SoundPlayer("Músik/Ginza.wav");
        SoundPlayer hastaq = new SoundPlayer("Músik/Hasta Que Se Seque El Malecon.wav");
        SoundPlayer laDura = new SoundPlayer("Músik/La dura.wav");
        SoundPlayer paraQue = new SoundPlayer("Músik/Para Que Un Dia Vuelvas.wav");
        SoundPlayer pelearnos = new SoundPlayer("Músik/Pelearnos un ratico.wav");
        SoundPlayer traidora = new SoundPlayer("Músik/Traidora.wav");
        SoundPlayer todos = new SoundPlayer("Músik/Todas.wav");

                      
        #region Propiedades
        public SoundPlayer SonidoJuego
        {
            get { return sonidoJuego; }
            set { sonidoJuego = value; }
        }
        public SoundPlayer Carnaval
        {
            get { return carnaval; }
            set { carnaval = value; }
        }
        public SoundPlayer Ginza
        {
            get { return ginza; }
            set { ginza = value; }
        }
        public SoundPlayer Hastaq
        {
            get { return hastaq; }
            set { hastaq = value; }
        }
        public SoundPlayer LaDura
        {
            get { return laDura; }
            set { laDura = value; }
        }
        public SoundPlayer ParaQue
        {
            get { return paraQue; }
            set { paraQue = value; }
        }
        public SoundPlayer Pelearnos
        {
            get { return pelearnos; }
            set { pelearnos = value; }
        }
        public SoundPlayer Traidora
        {
            get { return traidora; }
            set { traidora = value; }
        }
        public SoundPlayer Todos
        {
            get { return todos; }
            set { todos = value; }
        }
        #endregion


        Random r = new Random();
        Random idioma = new Random();
        int n;
        int id;

        public FrmStart()
        {
            InitializeComponent();
            progressBar1.PerformStep();
            sonidoJuego.Play();
        }

        FrmDatos frmDat;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < timer1.Interval)
            {
                progressBar1.PerformStep();
            }
            if (progressBar1.Value == progressBar1.Maximum)
            {
                if (frmDat == null)
                {
                    frmDat = new FrmDatos();
                    this.Visible = false;
                    frmDat.ShowDialog();
                    frmDat.Dispose();
                    this.Close();

                }
                else
                {
                    if (frmDat.IsDisposed)
                    {
                        frmDat = new FrmDatos();
                        frmDat.Show();
                        this.Close();
                    }
                    else
                    {
                        frmDat.Activate();
                    }
                }
            }
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            for (int i = progressBar1.Value; i < timer1.Interval; i++)
            {
                n = r.Next(80, 201);
                progressBar1.Step = n;
            }
            
            id = idioma.Next(1, 6);
            if (id==1)
            {                
                lblCargando.Text = "Cargando...";
                lblPorFavorEspere.Text = "Por favor espere...";
                lblPorFavorEspere.Location = new Point(480, 615);
            }
            else
            {
                if (id==2)
                {
                    lblCargando.Text = "Loading...";
                    lblPorFavorEspere.Text = "Please wait...";
                    lblPorFavorEspere.Location = new Point(490, 615);
                }
                else
                {
                    if (id==3)
                    {
                        lblCargando.Text = "Caricando...";
                        lblPorFavorEspere.Text = "Per favore spete...";
                        lblPorFavorEspere.Location = new Point(480, 615);
                    }
                    else
                    {
                        if (id==4)
                        {
                            lblCargando.Text = "Carregando...";
                            lblPorFavorEspere.Text = "Por favor espere...";
                            lblPorFavorEspere.Location = new Point(480, 615);
                        }
                        else
                        {
                            if (id==5)
                            {
                                lblCargando.Text = "Chargend...";
                                lblPorFavorEspere.Text = "Par faveur attendre...";
                                lblPorFavorEspere.Location = new Point(480, 615);
                            }
                        }
                    }
                }
            }

        }      
    }
}
