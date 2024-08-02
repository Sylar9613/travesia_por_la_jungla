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
    public class Bear:Obstaculos ,IObsMoviles
    {
      
       
       
        
        private bool esUtilizado = false;        

        #region Propiedades
    
        public bool EsUtilizado
        {
            get { return esUtilizado; }
            set { esUtilizado = value; }
        }
        #endregion
        Timer t; 
        public Bear(Image imagen, Tablero tablero, int x, int y,bool esUtilizado):base(imagen,tablero,x,y)
        {
           
          
            this.EsUtilizado = esUtilizado;
            Tablero.Matriz.Add(X, Y, Color.AliceBlue, Imagen); 
        }
        Random r = new Random();              
        public void MoverseX(Timer t)
        {            
            Tablero.Matriz.Clear(X, Y);
            X = r.Next(1, Tablero.Columnas - 1);
            Y = r.Next(1, Tablero.Filas - 1);            
            Tablero.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
        }   
                
    }
}
