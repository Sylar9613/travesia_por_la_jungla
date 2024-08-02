using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Travesía_por_la_jungla
{
    public class ElementoXY
    {
        protected Image i;
        
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Image Imagen { get { return i; } set { i = value; } }

        public  ElementoXY(int x,int y,Image i)
        {
            this.x = x;
            this.y = y;
            this.i = i;
        }
    }
}
