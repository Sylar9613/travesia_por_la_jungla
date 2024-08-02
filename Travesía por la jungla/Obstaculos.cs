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
    public abstract class Obstaculos:ElementoXY
    {
        private Image imagen;
        private Tablero tablero;
       
        
        #region Propiedades
     

        public Tablero Tablero
        {
            get { return tablero; }
            set { tablero = value; }
        }
               
        
        #endregion

        public Obstaculos(Image imagen, Tablero tablero, int x, int y):base(x,y,imagen)
        {
            this.Imagen = imagen;
            this.Tablero = tablero;        
           
        }
                
    }
}
