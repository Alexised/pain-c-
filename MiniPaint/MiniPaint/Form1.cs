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
    public partial class Form1 : Form
    {

        private Class1 objx = new Class1();
        //Estos son los atributos 
    
            
        Class1 paint = new Class1();

        public Form1()
        {
           
               InitializeComponent();

            //Aqui inicializamos nuestros atributos
            objx.punini = new Point(0, 0);
            objx.punfin = new Point(0, 0);
           

            cuadroPuntoInicial.Text = "(" + objx.punini.X + "," + objx.punini.Y + ")";
            cuadroPuntoFinal.Text = "(" + objx.punfin.X + "," + objx.punfin.Y + ")";

            objx.grosor = 1;
            nudGrosorLinea.Value = objx.grosor;

            objx.colorpri = Color.Black;
            objx.colorseg = Color.White;

            //Aqui inicializamos los cuadros de imagen y de los colores
            cuadroImagen.BackColor = objx.colorseg;

            cuadroColorPrimario.BackColor = objx.colorpri;
            cuadroColorSecundario.BackColor = objx.colorseg;

            //Aqui inicializamos los atributos de los elementos gráficos
            objx.lap = new Pen(objx.colorpri);
            objx.pinc = new SolidBrush(objx.colorpri);
            objx.lien = new Bitmap(cuadroImagen.Width, cuadroImagen.Height);
            objx.areadib = Graphics.FromImage(objx.lien);
        }

        //Este método borra el lienzo, rellenandolo con un rectangulo blanco
        private void InicializaLienzo()
        {
            objx.pinc = new SolidBrush(objx.colorseg);
            Rectangle miRectangulo = new Rectangle(0, 0,
                objx.lien.Width, objx.lien.Height);
            objx.areadib.FillRectangle(objx.pinc, miRectangulo);

            //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
            cuadroImagen.Image = objx.lien;
        }

        private void cuadroColorPrimario_Click(object sender, EventArgs e)
        {
            ColorDialog miDialogo = new ColorDialog();

            //Cuando se muestra el dialogo, si el usuario presiona OK
            if (miDialogo.ShowDialog() == DialogResult.OK)
            {
                objx.colorpri = miDialogo.Color;
                cuadroColorPrimario.BackColor = objx.colorpri;
            }
        }

        private void cuadroColorSecundario_Click(object sender, EventArgs e)
        {
            ColorDialog miDialogo = new ColorDialog();

            //Cuando se muestra el dialogo, si el usuario presiona OK
            if (miDialogo.ShowDialog() == DialogResult.OK)
            {
                objx.colorseg = miDialogo.Color;
                cuadroColorSecundario.BackColor = objx.colorseg;
            }
        }

        //Aqui capturamos la coordenada donde se presionó el mouse
        private void cuadroImagen_MouseDown(object sender, MouseEventArgs e)
        {
            //El argumento e contiene la información del punto en X,Y
            objx.punini = new Point(e.X, e.Y);
            cuadroPuntoInicial.Text = "(" + objx.punini.X + "," + objx.punini.Y + ")";
        }

        private void cuadroImagen_MouseUp(object sender, MouseEventArgs e)
        {
            //El argumento e contiene la información del punto en X,Y
            objx.punfin = new Point(e.X, e.Y);
            cuadroPuntoFinal.Text = "(" + objx.punfin.X + "," + objx.punfin.Y + ")";

            //Aqui identificamos que figura vamos a dibujar
            if (radioLinea.Checked == true)
            {
                paint.DibujarLinea();
                cuadroImagen.Image = objx.lien;

            }

            if (radioRectangulo.Checked == true)
            {
                paint.DibujarRectangulo();
                cuadroImagen.Image = objx.lien;
            }

            if (radioElipse.Checked == true)
            {
                paint.DibujarElipse();
                cuadroImagen.Image = objx.lien;
            }
        }

        //private void DibujarElipse()
        //{
        //    int ancho, alto;
        //    Point origen = new Point();

        //    //Aqui encontramos el alto y el ancho a partir de los puntos
        //    ancho = Math.Abs(puntoFinal.X - puntoInicial.X);
        //    alto = Math.Abs(puntoFinal.Y - puntoInicial.Y);

        //    //Aqui hallamos las coordenadas del punto del origen
        //    //A partir de los puntos
        //    if (puntoInicial.X < puntoFinal.X)
        //        origen.X = puntoInicial.X;
        //    else
        //        origen.X = puntoFinal.X;

        //    //O, también se puede utilizar la función Min
        //    origen.Y = Math.Min(puntoFinal.Y, puntoInicial.Y);

        //    //Aqui hacemos el rectangulo
        //    Rectangle elRectangulo = new Rectangle(origen.X,
        //        origen.Y, ancho, alto);

        //    //Si está en falso, se quiere rectángulo delineado
        //    if (checkRelleno.Checked == false)
        //    {
        //        lapiz = new Pen(colorPrimario, grosorLinea);
        //        areaDibujo.DrawEllipse(lapiz, elRectangulo);
        //    }
        //    //De lo contrario, se hace relleno
        //    else
        //    {
        //        pincel = new SolidBrush(colorSecundario);
        //        areaDibujo.FillEllipse(pincel, elRectangulo);
        //    }

        //    //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
        //    cuadroImagen.Image = lienzo;
        //}

        ////Este método dibuja un rectanculo con los puntos y los
        ////colores seleccionaodos.
        //private void DibujarRectangulo()
        //{
        //    int ancho, alto;
        //    Point origen = new Point();

        //    //Aqui encontramos el alto y el ancho a partir de los puntos
        //    ancho = Math.Abs(puntoFinal.X - puntoInicial.X);
        //    alto = Math.Abs(puntoFinal.Y - puntoInicial.Y);

        //    //Aqui hallamos las coordenadas del punto del origen
        //    //A partir de los puntos
        //    if (puntoInicial.X < puntoFinal.X)
        //        origen.X = puntoInicial.X;
        //    else
        //        origen.X = puntoFinal.X;

        //    //O, también se puede utilizar la función Min
        //    origen.Y = Math.Min(puntoFinal.Y, puntoInicial.Y);

        //    //Aqui hacemos el rectangulo
        //    Rectangle elRectangulo = new Rectangle(origen.X,
        //        origen.Y, ancho, alto);

        //    //Si está en falso, se quiere rectángulo delineado
        //    if (checkRelleno.Checked == false)
        //    {
        //        lapiz = new Pen(colorPrimario, grosorLinea);
        //        areaDibujo.DrawRectangle(lapiz, elRectangulo);
        //    }
        //    //De lo contrario, se hace relleno
        //    else
        //    {
        //        pincel = new SolidBrush(colorSecundario);
        //        areaDibujo.FillRectangle(pincel, elRectangulo);
        //    }

        //    //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
        //    cuadroImagen.Image = lienzo;
        //}

        ////Este metodo dibuja una linea con los puntos, el color
        ////y el grosor seleccionados
        //private void DibujarLinea()
        //{
        //    lapiz = new Pen(colorPrimario, grosorLinea);
        //    areaDibujo.DrawLine(lapiz,puntoInicial,puntoFinal);

        //    //Siempre se invoca esta linea para visualizar en el cuadroImagen, el lienzo modificado
        //    cuadroImagen.Image = lienzo;
        //}

        private void itemMenuNuevo_Click(object sender, EventArgs e)
        {
            InicializaLienzo();
        }

        private void grupoFiguras_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioRectangulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Este evento causa que el valor del grosor de linea cambie
        private void nudGrosorLinea_ValueChanged(object sender, EventArgs e)
        {
            objx.grosor = (int)nudGrosorLinea.Value;
        }

        private void itemMenuSalir_Click(object sender, EventArgs e)
        {
            //Cuando se seleccione esta opción, se cierra la aplicación
            Application.Exit();
        }

        private void checkRelleno_CheckedChanged(object sender, EventArgs e)
        {
            objx.relleno = checkRelleno.Checked;
        }

        private void radioLinea_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
