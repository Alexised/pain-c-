using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; //Requerido para hacer dibujos 2D
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Class1
    {
        private static Color colorPrimario, colorSecundario;
        private static int grosorLinea;
        private static Point puntoInicial, puntoFinal;

        private static Pen lapiz;
        private static Brush pincel;
        private static Bitmap lienzo;
        private static Graphics areaDibujo;
        private static bool x;


        public Graphics areadib
        {
            set { areaDibujo = value; }
            get { return areaDibujo; }
        }
        public Bitmap lien
        {
            set { lienzo = value; }
            get { return lienzo; }
        }
        public Brush pinc
        {
            set { pincel = value; }
            get { return pincel; }
        }

        public Pen lap
        {
            set { lapiz = value; }
            get { return lapiz; }
        }
        public int grosor
        {
            set { grosorLinea = value; }
            get { return grosorLinea; }
        }

        public Color colorpri
        {
            set { colorPrimario = value; }
            get { return colorPrimario; }
        }
        public Color colorseg
        {
            set { colorSecundario = value; }
            get { return colorSecundario; }
        }


        public Point punini
        {
            set { puntoInicial = value; }
            get { return puntoInicial; }
        }
        public Point punfin
        {
            set { puntoFinal = value; }
            get { return puntoFinal; }
        }




       

        public Boolean relleno
        {
            set { x = value; }
            get { return x; }
        }


        public void DibujarElipse()
        {
            int ancho, alto;
            Point origen = new Point();

            //Aqui encontramos el alto y el ancho a partir de los puntos
            ancho = Math.Abs(puntoFinal.X - puntoInicial.X);
            alto = Math.Abs(puntoFinal.Y - puntoInicial.Y);

            //Aqui hallamos las coordenadas del punto del origen
            //A partir de los puntos
            if (puntoInicial.X < puntoFinal.X)
                origen.X = puntoInicial.X;
            else
                origen.X = puntoFinal.X;

            //O, también se puede utilizar la función Min
            origen.Y = Math.Min(puntoFinal.Y, puntoInicial.Y);

            //Aqui hacemos el rectangulo
            Rectangle elRectangulo = new Rectangle(origen.X,
                origen.Y, ancho, alto);

            //Si está en falso, se quiere rectángulo delineado
            if (x == false)
            {
                lapiz = new Pen(colorPrimario, grosorLinea);
                areaDibujo.DrawEllipse(lapiz, elRectangulo);
            }
            //De lo contrario, se hace relleno
            else
            {
                pincel = new SolidBrush(colorSecundario);
                areaDibujo.FillEllipse(pincel, elRectangulo);
            }

            //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado

           //cuadroImagen.Image = lienzo;
        }

        //Este método dibuja un rectanculo con los puntos y los
        //colores seleccionaodos.
        public void DibujarRectangulo()
        {
            int ancho, alto;
            Point origen = new Point();

            //Aqui encontramos el alto y el ancho a partir de los puntos
            ancho = Math.Abs(puntoFinal.X - puntoInicial.X);
            alto = Math.Abs(puntoFinal.Y - puntoInicial.Y);

            //Aqui hallamos las coordenadas del punto del origen
            //A partir de los puntos
            if (puntoInicial.X < puntoFinal.X)
                origen.X = puntoInicial.X;
            else
                origen.X = puntoFinal.X;

            //O, también se puede utilizar la función Min
            origen.Y = Math.Min(puntoFinal.Y, puntoInicial.Y);

            //Aqui hacemos el rectangulo
            Rectangle elRectangulo = new Rectangle(origen.X,
                origen.Y, ancho, alto);

            //Si está en falso, se quiere rectángulo delineado
            if (x == false)
            {
                lapiz = new Pen(colorPrimario, grosorLinea);
                areaDibujo.DrawRectangle(lapiz, elRectangulo);
            }
            //De lo contrario, se hace relleno
            else
            {
                pincel = new SolidBrush(colorSecundario);
                areaDibujo.FillRectangle(pincel, elRectangulo);
            }

            //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
            //cuadroImagen.Image = lienzo;
        }

        //Este metodo dibuja una linea con los puntos, el color
        //y el grosor seleccionados
        public void DibujarLinea()
        {
            lapiz = new Pen(colorPrimario, grosorLinea);
            areaDibujo.DrawLine(lapiz, puntoInicial, puntoFinal);

            //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
            //cuadroImagen.Image = lienzo;
        }



    }
}
