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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int i, j, c;
                int max = 0;
                string str = "Простое!";
                j = 2;
                i = 1;
               
                bool resulta = int.TryParse(textBox1.Text, out int a);
                if (resulta == true)
                {

                    bool resultb = int.TryParse(textBox2.Text, out int b);

                    if (resultb == true)
                    {
                        if (a <= 0 | b <= 0)
                        {
                            MessageBox.Show("Не корректное число!");
                            Application.Exit();

                        }

                        if (a > b)
                        {
                            c = b;
                        }
                        else
                        {
                            c = a;
                        }

                        while (i <= c)
                        {

                            if (a % i == 0 & b % i == 0)
                            {
                                max = i;
                            }
                            i += 1;
                        }

                        while (j < max)
                        {
                            if (max % j == 0)
                            {
                                str = "Сложное!!!";
                                break;
                            }

                            j += 1;
                        }

                        if (max == 1)
                        {
                            str = "Не простое и  не сложное!";
                        }

                        MessageBox.Show( "НОД: " + max + " - " + str );

                    }
                    else
                    {
                        MessageBox.Show("Не корректное число!");
                    }
                }
                else
                {
                    MessageBox.Show("Не корректное число!");

                }

            }
        }
    }
}
