using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DibujoTriangulos.Clases
{
    class Triangulo
    {
        private Pen lapiz;
        private Graphics vector;
        private TextBox textBoxX1, textBoxX2, textBoxX3, textBoxY1, textBoxY2, textBoxY3, textBoxRotar;
        private PictureBox pictureBox;
        private double x1, x2, y1, y2;
        private int xCentro, yCentro;
        private double atan, atan1, atan2, b, b1, c, c1, d, d1, an, an1, an2, fx, fx1, fx2, fy, fy1, fy2,
            g, g1, g2, j, j1, j2, sqrt, sqrt2, z, z1, calc;

        public Triangulo(TextBox textBoxX1, TextBox textBoxX2, TextBox textBoxX3, TextBox textBoxY1, TextBox textBoxY2,
            TextBox textBoxY3, TextBox textBoxRotar, PictureBox pictureBox)
        {
            this.textBoxX1 = textBoxX1;
            this.textBoxX2 = textBoxX2;
            this.textBoxX3 = textBoxX3;
            this.textBoxY1 = textBoxY1;
            this.textBoxY2 = textBoxY2;
            this.textBoxY3 = textBoxY3;
            this.textBoxRotar = textBoxRotar;
            this.pictureBox = pictureBox;
            lapiz = new Pen(Color.Black, 2);
            xCentro = pictureBox.Width / 2;
            yCentro = pictureBox.Height / 2;
        }

        public void graficar()
        {
            if(textBoxX1.Text == "")
            {
                textBoxX1.Focus();
            }

            else
            {
                if (textBoxX2.Text == "")
                {
                    textBoxX2.Focus();
                }

                else
                {
                    if (textBoxX3.Text == "")
                    {
                        textBoxX3.Focus();
                    }

                    else
                    {
                        if (textBoxY1.Text == "")
                        {
                            textBoxY1.Focus();
                        }

                        else
                        {
                            if (textBoxY2.Text == "")
                            {
                                textBoxY2.Focus();
                            }

                            else
                            {
                                if (textBoxY3.Text == "")
                                {
                                    textBoxY3.Focus();
                                }

                                else
                                {
                                    dibujar();
                                }
                            }
                        }
                    }
                }
            }
        }

        public void dibujar()
        {
            b = Convert.ToDouble(textBoxX1.Text);
            c = Convert.ToDouble(textBoxY1.Text);
            b1 = Convert.ToDouble(textBoxX2.Text);
            c1 = Convert.ToDouble(textBoxY2.Text);
            d = Convert.ToDouble(textBoxX3.Text);
            d1 = Convert.ToDouble(textBoxY3.Text);

            x1 = (Convert.ToDouble(xCentro) + Convert.ToDouble(textBoxX1.Text));
            y1 = (Convert.ToDouble(yCentro) - Convert.ToDouble(textBoxY1.Text));
            x2 = (Convert.ToDouble(xCentro) + Convert.ToDouble(textBoxX2.Text));
            y2 = (Convert.ToDouble(yCentro) - Convert.ToDouble(textBoxY2.Text));
            z = (Convert.ToDouble(xCentro) + Convert.ToDouble(textBoxX3.Text));
            z1 = (Convert.ToDouble(yCentro) - Convert.ToDouble(textBoxY3.Text));

            vector = pictureBox.CreateGraphics();
            lapiz = new Pen(Color.OrangeRed);

            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2),
                Convert.ToInt32(y2));
            vector.DrawLine(lapiz, Convert.ToInt32(x2), Convert.ToInt32(y2), Convert.ToInt32(z),
                Convert.ToInt32(z1));
            vector.DrawLine(lapiz, Convert.ToInt32(z), Convert.ToInt32(z1), Convert.ToInt32(x1),
                Convert.ToInt32(y1));

            lapiz.Dispose();
            vector.Dispose();
        }
    }
}
