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
    public class Snake:Obstaculos,IObsMoviles
    {
        public Snake(Image imagen, Tablero tablero, int x, int y)
            : base(imagen, tablero, x, y)
        {
           
            Tablero.Matriz.Add(X, Y, Color.AliceBlue, Imagen); 
        }
             
        public void MoverseX(Timer t)
        {
            Random r = new Random();
            Tablero.Matriz.Clear(X, Y);
            X = r.Next(1, Tablero.Columnas - 1);
            Y = r.Next(1, Tablero.Filas - 1);            
            Tablero.Matriz.Add(X, Y, Color.AliceBlue, Imagen);
        }                 
    }
}
