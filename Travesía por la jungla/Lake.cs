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
    public class Lake:Obstaculos,IObsFijos
    {    
        public Lake(Image imagen, Tablero tablero, int x, int y)
            : base(imagen, tablero, x, y)
        {                               
            Tablero.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
        }
                
    }
}
