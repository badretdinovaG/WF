using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_WF
{
    public partial class Form10 : Form
    {
        Pen myPen = new Pen(Color.Black);
        Pen pen = new Pen(Color.Black);

        public Form10()
        {
            InitializeComponent();

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            trackBar4.BackColor = Color.LightBlue;
            trackBar3.BackColor = Color.LightGreen;
            trackBar2.BackColor = Color.LightPink;
            trackBar1.Value = 255;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myPen.Width = 1;
            // создание канвы для отрисовки граф объектов
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);


            g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(pen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);

            // Устанавливаем параметры пера и рисуем оси ОХ и ОУ


            myPen.Width = Convert.ToInt32(numericUpDown1.Value);

            int Interval = pictureBox1.Width;
            double xmin = 0;
            double xmax = 2 * 3.14;

            double ymax = 2;
            float xstep = (float)((xmax - xmin) / Interval);
            // определяем масштабные коэффиценты kx, ky
            float kx = (float)(pictureBox1.Width / xmax),
                  ky = (float)(pictureBox1.Height / ymax);
            float x1 = (float)xmin, y1 = x1, x2, y2;

            // отрисовка синусоиды
            for (int i = 0; i < Interval; i++)
            {
                x2 = x1 + xstep;
                y2 = (float)(0.65 * Math.Sin(x2));

                g.DrawLine(myPen, kx * x1, ky * y1 + pictureBox1.Height / 2, kx * x2, ky * y2 + pictureBox1.Height / 2);

                x1 = x2;
                y1 = y2;
            }
            comboBox1.Items.Remove(comboBox1.SelectedItem);

            g.Dispose();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: myPen.Color = Color.Blue;
                    break;
                case 1: myPen.Color = Color.Red;
                    break;
                case 2: myPen.Color = Color.Green;
                    break;
                case 3: myPen.Color = Color.Black;
                    break;

            }
        }
        private void Form10_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            this.button1_Click(sender, e);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            myPen.Color = Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);


        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            myPen.Color = Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);

        }


        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            myPen.Color = Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            myPen.Color = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value);

        }

        public void Pifagor(double x0, double y0, double a, double L, int N)
        {

            Graphics g = pictureBox1.CreateGraphics();

            const double k = 0.6;
            double x1, y1;


            if (N > 0)
            {

                x1 = x0 + L * Math.Cos(a);
                y1 = y0 - L * Math.Sin(a);
                g.DrawLine(myPen, (float)x0, (float)y0, (float)x1, (float)y1);
                Pifagor(x1, y1, a + Math.PI / 4, L * k, N - 1);
                Pifagor(x1, y1, a - Math.PI / 4, L * k, N - 1);

            }

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            myPen.Color = Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            myPen.Width = Convert.ToInt32(numericUpDown1.Value);
            pictureBox1.Refresh();
            g.Dispose();
            Pifagor(this.Width / 2, this.Height - panel1.Height, Math.PI / 2, 50, (int)numericUpDown2.Value);

        }


       

        private void button3_Click(object sender, EventArgs e)
        {
            double d, k ;
            int n , j = 1;
            double a1 ;

            a1 = Convert.ToDouble(numericUpDown3.Value);
            d = Convert.ToDouble(numericUpDown3.Value); // первый член 
            k = Convert.ToDouble(numericUpDown4.Value); // знаменатель
            n = Convert.ToInt32(numericUpDown5.Value); // количество членов прогрессии


            suma = geo_summa(n = Convert.ToInt32(numericUpDown5.Value), d = Convert.ToDouble(numericUpDown3.Value), k = Convert.ToDouble(numericUpDown4.Value));
            textBox1.Text = $"{suma}";
          


           
            Graphics g = pictureBox1.CreateGraphics();


            pictureBox1.Refresh();
            g.Dispose();
            Sum_GeomPr(pictureBox1.Width / 2, pictureBox1.Height / 2, d = Convert.ToDouble(numericUpDown3.Value), k = Convert.ToDouble(numericUpDown4.Value), n = Convert.ToInt32(numericUpDown5.Value), j);
        }
        
        private void Sum_GeomPr(double x0, double y0, double a1, double k, int n, int p)
        {
            Graphics g = pictureBox1.CreateGraphics();
            if (n > 0)
            {
                double x1;
                double y1;
                
                double yn = 0;
                int i = n, j = p;


                yn +=  geo_summa( n,  a1,  k);
                x1 = x0 + 1 * 30;
                y1 = y0 - (a1 * Math.Pow(k, (i - 1))) * 10;


                j++;
                
                g.DrawLine(pen, (float)x0, (float)y0, (float)x1, (float)y1);

                g.DrawLine(pen, (float)x1, pictureBox1.Height / 2 - 5, (float)x1, pictureBox1.Height / 2 + 5); 
                g.DrawString($"{j - 1}", this.Font, Brushes.Blue, (float)x1 - 5, pictureBox1.Height / 2 + 10);

                g.DrawLine(pen, pictureBox1.Width / 2 - 5, (float)y1, pictureBox1.Width / 2 + 5, (float)y1); 
                g.DrawString($"{yn}", this.Font, Brushes.Blue, pictureBox1.Width / 2 - 25, (float)y1 - 8);


                g.DrawLine(pen, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
                g.DrawLine(pen, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
              
                if (i != 0)
                {
                    Sum_GeomPr(x1, y1, a1,k, --i, j);
                }

            }
        }

        public double suma = 0;
        private double geo_summa(int n, double a1, double k)
        {

            if (n == 1)
            {

                return a1;
            }
            else
            {

                return a1 + geo_summa(n - 1, a1 * k, k);
            }

        }
    }
}
       
    
