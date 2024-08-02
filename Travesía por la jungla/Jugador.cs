using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JPUtil;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Travesía_por_la_jungla
{
    public class Jugador:ElementoXY
    {
      
        private Tablero tab;
       
        private string nombreJug;
        protected ElementoXY almElem;
        public ElementoXY AlmElem { get { return almElem; } set { almElem = value; } }
 

        Jugador auxjug;
        int vidas;
        bool terminoJugar;

        
        #region Propiedades
      
        public Tablero Tab
        {
            get { return tab; }
            set { tab = value; }
        }
     
        public string NombreJug
        {
            get { return nombreJug; }
            set { nombreJug = value; }
        }
        public bool TerminoJugar
        {
            get { return terminoJugar; }
            set { terminoJugar = value; }
        }
        public int Vidas
        {
            get { return vidas; }
            set { vidas = value; }
        }  
        #endregion

        public Jugador(Tablero tab, int x,int y,Image imagen, string nombreJug):base(x,y,imagen)
        {
            
            this.Tab = tab;

            this.Vidas = 2000;
            this.TerminoJugar = false;
            this.NombreJug = nombreJug;
            tab.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
        }
               

        public void Mover(Timer t,ElementoXY[,] todos,Jugador[,] matjug,int num)
        {
          
           
            Tab.Matriz.Clear(X, Y);
            if (todos[X, Y] != null)
                tab.Matriz.Add(X, Y, Color.AliceBlue, todos[X, Y].Imagen);
            if(almElem!=null)
            {
                matjug[almElem.X, AlmElem.Y] = almElem as Jugador;
                tab.Matriz.Add(X, Y, Color.AliceBlue, almElem.Imagen);
                almElem = null;
            }
           
            if (matjug[X, Y] != null && matjug[X,Y].NombreJug!=this.nombreJug)
            {
                tab.Matriz.Add(X, Y, Color.AliceBlue, matjug[X, Y].Imagen);
             
              
            }
            else if (matjug[X, Y] != null && matjug[X, Y].NombreJug == this.nombreJug)
            {
                matjug[X, Y] = null;
            }
           
            if (Y % 2 == 0)
            {
                if (X==Tab.Columnas-1)
                {
                   
                    Y++;
                    almElem = todos[X, Y];
                    Tab.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
                }
                else
                {
                    
                    X++;
                    almElem = todos[X, Y];
                    Tab.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
                }
            }
            else
            {
                if (X==0)
                {
                  
                    Y++;
                    almElem = todos[X, Y];
                    Tab.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
                }
                else
                {
                  
                    X--;
                    almElem = todos[X, Y];
                    Tab.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
                }
            }

            if (X==Tab.Columnas-1&&Y==Tab.Filas-1)
            {
                //Ganaste, hago algo.
                this.TerminoJugar = true;
                t.Stop();
                this.Vidas = Vidas + 2000;
                MessageBox.Show("Ganaste "+NombreJug + " con " + Vidas + " puntos.");
            }
        

          if (matjug[X, Y] == null)
          {
              matjug[X, Y] = new Jugador(Tab, X, Y, Imagen, NombreJug);
          }
          else
          {
              almElem = matjug[X, Y];
          }

          EjecutarObs(todos);


        }

        public int QuitarVida(int menosVida)
        {
            return Vidas = Vidas - menosVida;
        }
        public int GanarVida(int vida)
        {
            return Vidas = Vidas + vida;
        }

        public void EjecutarObs(ElementoXY[,] todos)
        {
            if (todos[X, Y] is Obstaculos)
            {
                if(todos[X,Y]is Snake)
                {
                   QuitarVida(200);
                    //MessageBox.Show("Tiene " + Vidas.ToString() + " vidas.");
                }
                else if (todos[X,Y]is Lake)
                {                    
                    QuitarVida(300);
                    //MessageBox.Show("Tiene " + Vidas.ToString() + " vidas.");
                }
                else if (todos[X,Y]is Bear)
                {
                    QuitarVida(400);
                    //MessageBox.Show("Tiene " + Vidas.ToString() + " vidas.");
                }
                else if (todos[X,Y]is Wall)
                {
                    QuitarVida(150);
                }
                else if (todos[X,Y]is Power)
                {
                    GanarVida(500);
                }
            }
        }
    }
}
