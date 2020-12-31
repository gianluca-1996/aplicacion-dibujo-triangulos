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
            g, g1, g2, j, j1, j2, sqrt, sqrt1, sqrt2, z, z1, calc;

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
            lapiz = new Pen(Color.OrangeRed, 2);
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

            x1 = (Convert.ToDouble(xCentro) + 5 * Convert.ToDouble(textBoxX1.Text));
            y1 = (Convert.ToDouble(yCentro) - 5 * Convert.ToDouble(textBoxY1.Text));
            x2 = (Convert.ToDouble(xCentro) + 5 * Convert.ToDouble(textBoxX2.Text));
            y2 = (Convert.ToDouble(yCentro) - 5 * Convert.ToDouble(textBoxY2.Text));
            z = (Convert.ToDouble(xCentro) + 5 * Convert.ToDouble(textBoxX3.Text));
            z1 = (Convert.ToDouble(yCentro) - 5 * Convert.ToDouble(textBoxY3.Text));

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

        private void trigonometria(int valor)
        {
            atan = Math.Atan((c) / (b));
            an = (atan * 180) / Math.PI;
            sqrt = Math.Sqrt((Math.Pow((b), 2)) + (Math.Pow((c), 2)));

            if (valor == 1)
                g = an + Convert.ToDouble(textBoxRotar.Text);

            else
                g = an + calc;

            j = Math.PI * g / 180;
            fx = (sqrt) * (Math.Cos(j));
            fy = (sqrt) * (Math.Sin(j));


            atan1 = Math.Atan((c1) / (b1));
            an1 = (atan1 * 180) / Math.PI;
            sqrt1 = Math.Sqrt((Math.Pow((b1), 2)) + (Math.Pow((c1), 2)));

            if (valor == 1)
                g1 = an1 + Convert.ToDouble(textBoxRotar.Text);

            else
                g1 = an1 + calc;

            j1 = Math.PI * g1 / 180;
            fx1 = (sqrt1) * (Math.Cos(j1));
            fy1 = (sqrt1) * (Math.Sin(j1));


            atan2 = Math.Atan((d1) / (d));
            an2 = (atan2 * 180) / Math.PI;
            sqrt2 = Math.Sqrt((Math.Pow((d), 2)) + (Math.Pow((d1), 2)));

            if (valor == 1)
                g2 = an2 + Convert.ToDouble(textBoxRotar.Text);

            else
                g2 = an2 + calc;

            j2 = Math.PI * g2 / 180;
            fx2 = (sqrt2) * (Math.Cos(j2));
            fy2 = (sqrt2) * (Math.Sin(j2));
        }

        public void girarTriangulo()
        {
            calc = calc + 5;
            trigonometria(2);
        }
    }
}
