using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JPUtil;

namespace Travesía_por_la_jungla
{
    public class Tablero
    {
        private ColorTable matriz;        
        private int filas;        
        private int columnas;
                
        #region Propiedades
        public ColorTable Matriz
        {
            get { return matriz; }
            set { matriz = value; }
        }
        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }
        public int Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }
        #endregion

        public Tablero(ColorTable matriz)
        {
            this.Matriz = matriz;
            this.Filas = matriz.TableHeight;   // las y
            this.Columnas = matriz.TableWidth;  // las x
        }
    }
}
