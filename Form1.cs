using DibujoTriangulos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujoTriangulos
{
    public partial class Form1 : Form
    {
        Triangulo miTriangulo;
        public Form1()
        {
            InitializeComponent();
            miTriangulo = new Triangulo(X1TextBox, X2TextBox, X3TextBox, Y1TextBox, Y2TextBox, Y3TextBox,
                rotarTextBox1, pictureBox1);
        }

        private void X1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void X2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void X3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Y1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Y2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Y3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rotarTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int incremento = 5;
            int xCentro = pictureBox1.Width / 2;
            int yCentro = pictureBox1.Height / 2;
            Pen lapiz = new Pen(Color.Black, 1);
            e.Graphics.TranslateTransform(xCentro, yCentro);
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.DrawLine(lapiz, xCentro * -1, 0, xCentro * 2, 0);
            e.Graphics.DrawLine(lapiz, 0, yCentro, 0, yCentro * -1);

            for (int i = -xCentro; i < xCentro; i += 5)
            {
                e.Graphics.DrawLine(lapiz, -5, -incremento, 5, -incremento);    //eje y positivo
                e.Graphics.DrawLine(lapiz, -5, incremento, 5, incremento);      //eje y negativo
                e.Graphics.DrawLine(lapiz, -incremento, 5, -incremento, -5);    //eje x negativo
                e.Graphics.DrawLine(lapiz, incremento, -5, incremento, 5);    //eje x positivo
                incremento += 5;
            }
        }

        private void dibujarButton_Click(object sender, EventArgs e)
        {
            miTriangulo.graficar();
        }
    }
}
