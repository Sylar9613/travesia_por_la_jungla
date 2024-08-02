using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JPUtil;
using System.Media;
using System.Collections;

namespace Travesía_por_la_jungla
{
    public partial class Form1 : Form
    {
        Image premio = new Bitmap("Imagénes/premio.GIF");



        int XPrevoso;
        int YPrevoso;

        int XPrevserp;
        int YPrevserp;

        int XPrevpoder;
        int YPrevpoder;

        Tablero tablero;        
        Bear oso;
        Snake serpiente;
        Lake lago;
        Wall montaña;
        Power rafiki;
        ElementoXY[,] elem;
        Jugador[,] matrizjug;
       
        ElementoXY[] aux;
        
        Random r = new Random();
        Obstaculos[] obs;

        public Obstaculos[] Obs
        {
            get { return obs; }
            set { obs = value; }
        }
        int num;
        private int jug;

        public int Jug
        {
            get { return jug; }
            set { jug = value; }
        }

        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        bool termino = false;
        bool esUtz = false;

        Image a = new Bitmap("Imagénes/lk15.GIF");
        Image b = new Bitmap("Imagénes/Tarzan.GIF");
        Image e = new Bitmap("Imagénes/kerchak.GIF");
        Image d = new Bitmap("Imagénes/herc1.GIF");

        Image imgoso = new Bitmap("Imagénes/001.GIF");
        Image imgSnake = new Bitmap("Imagénes/006.GIF");
        Image imgLake = new Bitmap("Imagénes/lago.GIF");
        Image imgStone = new Bitmap("Imagénes/montaña.GIF");

        Image poder = new Bitmap("Imagénes/rafiki04a.GIF");

        Jugador[] gamer;


        public Form1(int x, int y, Jugador[]gam, int cantObs, string name1, string name2)
        {
            InitializeComponent();
           
            timerOne.Stop();
            this.X = x;
            this. Y = y;
            elem = new ElementoXY[X,Y];
            matrizjug = new Jugador[X, Y];


            aux = new ElementoXY[2];//le da length 2  es la cant jug
            this.junglaVisual.TableWidth = X;
            this.junglaVisual.TableHeight = Y;
            
            if (X == 10)
            {
                this.junglaVisual.CellSize = 100;
            }
            else if (X == 16)
            {
                this.junglaVisual.CellSize = 60;
            }
            else if (X == 20)
            {
                this.junglaVisual.CellSize = 48;
            }
            Lup();
            tablero = new Tablero(junglaVisual);
            tablero.Matriz.Add(new Point(tablero.Columnas - 1, tablero.Filas - 1), Color.AliceBlue, premio);

            gamer = new Jugador[gam.Length];
            gam.CopyTo(gamer, 0);
            if (gamer.Length == 2)
            {
                Random fijos = new Random();
                Random moviles = new Random();
                int f = fijos.Next(1, (tablero.Columnas - 1)/2);
                int c = fijos.Next(1, (tablero.Filas - 1)/2);
                int z = moviles.Next(1, tablero.Columnas - 1);
                int m = moviles.Next(1, tablero.Filas - 1); 
                gamer[0] = new Jugador(tablero, 0,0, a,name1);
                gamer[1] = new Jugador(tablero, 0, 0, b,name2);

                matrizjug[gamer[0].X, gamer[0].Y] = gamer[0];
                matrizjug[gamer[1].X, gamer[1].Y] = gamer[1];
               

                oso = new Bear(imgoso, tablero, f, c,esUtz);                
                serpiente = new Snake(imgSnake, tablero, z, m);
                lago = new Lake(imgLake, tablero, 9, 0);
                montaña = new Wall(imgStone, tablero, 0, 7);
                rafiki = new Power(poder, tablero, 9, 4);
                                
                if ((f == m && c == (z - 1) )||( f == z && c == m))
                {
                    montaña = new Wall(imgStone, tablero, 0, 7);
                    oso = new Bear(imgoso, tablero, f, c,esUtz);
                    serpiente = new Snake(imgSnake, tablero, m-1, z-1);
                    rafiki = new Power(poder, tablero, 9, 4);
                }



                if (XPrevoso!=0&&YPrevoso!=0)
                {
                    
                    XPrevoso = oso.X;
                    YPrevoso = oso.Y;
                }
                if (XPrevserp != 0 && YPrevserp != 0)
                {
                    
                    XPrevserp = serpiente.X;
                    YPrevserp = serpiente.Y;
                }
                if (XPrevpoder!=0&&YPrevpoder!=0)
                {
                    XPrevpoder = rafiki.X;
                    YPrevpoder = rafiki.Y;
                }
                elem[oso.X, oso.Y] = oso;
                elem[serpiente.X, serpiente.Y] = serpiente;
                elem[montaña.X, montaña.Y] = montaña;
                elem[lago.X, lago.Y] = lago;
                elem[rafiki.X, rafiki.Y] = rafiki;                     
                                              
            }
                      
            this.lblJug1.Text = name1;
            this.lblJug2.Text = name2;

                                
        }

        public Form1(int x, int y, Jugador[]gam, int cantObs, string name1, string name2, string name3)
        {
            InitializeComponent();

            timerOne.Stop();
            X = x;
            Y = y;

            elem = new ElementoXY[X, Y];
            matrizjug = new Jugador[X, Y];


            aux = new ElementoXY[3];//le da length 3  es la cant jug

            this.junglaVisual.TableWidth = X;
            this.junglaVisual.TableHeight = Y;
            
            if (X == 10)
            {
                this.junglaVisual.CellSize = 100;
            }
            else if (X == 16)
            {
                this.junglaVisual.CellSize = 60;
            }
            else if (X == 20)
            {
                this.junglaVisual.CellSize = 48;
            }
            Lup();
            tablero = new Tablero(junglaVisual);
            tablero.Matriz.Add(new Point(tablero.Columnas - 1, tablero.Filas - 1), Color.AliceBlue, premio);

            gamer = new Jugador[gam.Length];
            gam.CopyTo(gamer, 0);
            
            if (gamer.Length == 3)
            {
                gamer[0] = new Jugador(tablero, 0, 0, a, name1);
                gamer[1] = new Jugador(tablero, 0, 0, b, name2);
                gamer[2] = new Jugador(tablero, 0, 0, e, name3);

                Random fijos = new Random();
                Random moviles = new Random();
                int f = fijos.Next(1, (tablero.Columnas - 1) / 2);
                int c = fijos.Next(1, (tablero.Filas - 1) / 2);
                int z = moviles.Next(1, tablero.Columnas - 1);
                int m = moviles.Next(1, tablero.Filas - 1);
                

                matrizjug[gamer[0].X, gamer[0].Y] = gamer[0];
                matrizjug[gamer[1].X, gamer[1].Y] = gamer[1];


                oso = new Bear(imgoso, tablero, f, c, esUtz);
                serpiente = new Snake(imgSnake, tablero, z, m);
                lago = new Lake(imgLake, tablero, 9, 0);
                montaña = new Wall(imgStone, tablero, 0, 7);
                rafiki = new Power(poder, tablero, 9, 4);

                if ((f == m && c == (z - 1)) || (f == z && c == m))
                {
                    montaña = new Wall(imgStone, tablero, 0, 7);
                    oso = new Bear(imgoso, tablero, f, c, esUtz);
                    serpiente = new Snake(imgSnake, tablero, m - 1, z - 1);
                    rafiki = new Power(poder, tablero, 9, 4);
                }



                if (XPrevoso != 0 && YPrevoso != 0)
                {

                    XPrevoso = oso.X;
                    YPrevoso = oso.Y;
                }
                if (XPrevserp != 0 && YPrevserp != 0)
                {

                    XPrevserp = serpiente.X;
                    YPrevserp = serpiente.Y;
                }
                if (XPrevpoder != 0 && YPrevpoder != 0)
                {
                    XPrevpoder = rafiki.X;
                    YPrevpoder = rafiki.Y;
                }
                elem[oso.X, oso.Y] = oso;
                elem[serpiente.X, serpiente.Y] = serpiente;
                elem[montaña.X, montaña.Y] = montaña;
                elem[lago.X, lago.Y] = lago;
                elem[rafiki.X, rafiki.Y] = rafiki;                     
                     
            }
                                    
            this.lblJug1.Text = name1;
            this.lblJug2.Text = name2;
            this.lblJug3.Visible = true;
            this.lblJug3.Text = name3;
            this.label3.Visible = true;
                       
        }

        public Form1(int x, int y, Jugador[]gam, int cantObs, string name1, string name2, string name3, string name4)
        {
            InitializeComponent();
            timerOne.Stop();
            X = x;
            Y = y;
            elem = new ElementoXY[X, Y];
            matrizjug = new Jugador[X, Y];


            aux = new ElementoXY[4];//le da length 4  es la cant jug
            this.junglaVisual.TableWidth = X;
            this.junglaVisual.TableHeight = Y;
            
            if (X == 10)
            {
                this.junglaVisual.CellSize = 100;
            }
            else if (X == 16)
            {
                this.junglaVisual.CellSize = 60;
            }
            else if (X == 20)
            {
                this.junglaVisual.CellSize = 48;
            }

            Lup();
            tablero = new Tablero(junglaVisual);
            tablero.Matriz.Add(new Point(tablero.Columnas - 1, tablero.Filas - 1), Color.AliceBlue, premio);

            gamer = new Jugador[gam.Length];
            gam.CopyTo(gamer, 0);
            
            if (gamer.Length == 4)
            {
                gamer[0] = new Jugador(tablero, 0, 0, a,name1);
                gamer[1] = new Jugador(tablero, 0, 0, b,name2);
                gamer[2] = new Jugador(tablero, 0, 0, e ,name3);
                gamer[3] = new Jugador(tablero, 0, 0, d,name4);

                Random fijos = new Random();
                Random moviles = new Random();
                int f = fijos.Next(1, (tablero.Columnas - 1) / 2);
                int c = fijos.Next(1, (tablero.Filas - 1) / 2);
                int z = moviles.Next(1, tablero.Columnas - 1);
                int m = moviles.Next(1, tablero.Filas - 1);


                matrizjug[gamer[0].X, gamer[0].Y] = gamer[0];
                matrizjug[gamer[1].X, gamer[1].Y] = gamer[1];


                oso = new Bear(imgoso, tablero, f, c, esUtz);
                serpiente = new Snake(imgSnake, tablero, z, m);
                lago = new Lake(imgLake, tablero, 9, 0);
                montaña = new Wall(imgStone, tablero, 0, 7);
                rafiki = new Power(poder, tablero, 9, 4);

                if ((f == m && c == (z - 1)) || (f == z && c == m))
                {
                    montaña = new Wall(imgStone, tablero, 0, 7);
                    oso = new Bear(imgoso, tablero, f, c, esUtz);
                    serpiente = new Snake(imgSnake, tablero, m - 1, z - 1);
                    rafiki = new Power(poder, tablero, 9, 4);
                }

                
                if (XPrevoso != 0 && YPrevoso != 0)
                {

                    XPrevoso = oso.X;
                    YPrevoso = oso.Y;
                }
                if (XPrevserp != 0 && YPrevserp != 0)
                {

                    XPrevserp = serpiente.X;
                    YPrevserp = serpiente.Y;
                }
                if (XPrevpoder != 0 && YPrevpoder != 0)
                {
                    XPrevpoder = rafiki.X;
                    YPrevpoder = rafiki.Y;
                }
                elem[oso.X, oso.Y] = oso;
                elem[serpiente.X, serpiente.Y] = serpiente;
                elem[montaña.X, montaña.Y] = montaña;
                elem[lago.X, lago.Y] = lago;
                elem[rafiki.X, rafiki.Y] = rafiki;  
            }
            
            
            this.lblJug1.Text = name1;
            this.lblJug2.Text = name2;
            this.lblJug3.Visible = true;
            this.lblJug3.Text = name3;
            this.lblJug4.Visible = true;
            this.lblJug4.Text = name4;
            this.label3.Visible = true;
            this.label4.Visible = true;
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            
        }

        public void Lup()
        {
            this.junglaVisual.Size = new Size(1005, 950);            
            btnDado.Location = new Point(1100, 252);
            this.label1.Text = string.Empty;
            this.label2.Text = string.Empty;
            this.label3.Text = string.Empty;
            this.label4.Text = string.Empty;
        }
        public void VerificaSiCambiaAux()
        {   
            for (int i = 0; i < gamer.Length; i++)
            {
                if (aux[i] != null && i!= actjug)
                {
                    if (gamer[actjug].X == aux[i].X && gamer[actjug].Y == aux[i].Y)//me pone el animal q va,y me vacia el auxAnimal
                    {

                        aux[actjug] = gamer[i];
                        aux[i] = null;
                        gamer[actjug].AlmElem = gamer[i];
                        gamer[i].AlmElem = null;

                    }
                }

            }




        }
        private void timerOne_Tick(object sender, EventArgs e)
        {
          //  int xaux=gamer[actjug].X;
            //int yaux = gamer[actjug].Y;
            VerificaSiCambiaAux();

            if (gamer.Length==2)
            {
                gamer[actjug].Mover(timerOne,elem,matrizjug,num);
               
                num--;
                DetenerDado(num);
                label1.Text = gamer[0].Vidas.ToString();
                label2.Text = gamer[1].Vidas.ToString();
            }
            if (gamer.Length==3)
            {
                gamer[actjug].Mover(timerOne, elem, matrizjug, num);
            
                num--;
                DetenerDado(num);
                label1.Text = gamer[0].Vidas.ToString();
                label2.Text = gamer[1].Vidas.ToString();
                label3.Text = gamer[2].Vidas.ToString();
            }
            if (gamer.Length==4)
            {
                gamer[actjug].Mover(timerOne, elem, matrizjug, num);
             
                num--;
                DetenerDado(num);
                label1.Text = gamer[0].Vidas.ToString();
                label2.Text = gamer[1].Vidas.ToString();
                label3.Text = gamer[2].Vidas.ToString();
                label4.Text = gamer[3].Vidas.ToString();
            }
            aux[actjug] = gamer[actjug].AlmElem;
            //elem[xaux, yaux] = null;
           // if (elem[gamer[actjug].X, gamer[actjug].Y]==null)
        //    elem[gamer[actjug].X,gamer[actjug].Y] = gamer[actjug];      
        }

        private void btnStopMusic_Click(object sender, EventArgs e)
        {
            FrmStart h=new FrmStart();
            h.SonidoJuego.Stop();
            h.Dispose();
        }
                
        private void btnReanudarMusic_Click(object sender, EventArgs e)
        {
            FrmStart g = new FrmStart();                        
            g.SonidoJuego.Play();
            g.Dispose();
        }
         

        public void DetenerDado(int n) 
        {
            if (n==0)
            {                
                timerOne.Stop();
                termino = true;
                btnDado.Enabled = true;
            }
        }

        int actjug = 0;
        private void btnDado_Click(object sender, EventArgs e)
        {
            
            timerOne.Start();
            num = r.Next(1, 13);
            lblDado.Text = num.ToString();            
            actjug++;
            if (actjug==gamer.Length)
            {
                actjug = 0;
            }            
            btnDado.Enabled = false;            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit frm = new Exit();
            DialogResult respueta = frm.ShowDialog();
            if (respueta == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }



        
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            FrmDatos f = new FrmDatos();
            this.Visible=false;
            this.Dispose();
            this.Close();
           
            if (this.IsDisposed)
            {
                f.ShowDialog();
                f.Dispose();
                Application.ExitThread();
            }          
        }

        private void timerTwo_Tick(object sender, EventArgs e)
        {           
           oso.MoverseX(timerTwo);
           elem[XPrevoso, YPrevoso] = null;
           XPrevoso = oso.X;
           YPrevoso = oso.Y;
           elem[oso.X, oso.Y] = oso;
           serpiente.MoverseX(timerTwo);
           elem[XPrevserp, YPrevserp] = null;
           XPrevserp = serpiente.X;
           YPrevserp = serpiente.Y;
           elem[serpiente.X, serpiente.Y] = serpiente;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                
    }
}
