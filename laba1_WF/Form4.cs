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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                float sum = 0;

                bool resulta = int.TryParse(textBox1.Text, out var a);

                if (resulta == true)
                {


                    
                    bool resultb = float.TryParse(textBox2.Text, out var b);

                    if (resultb == true)
                    {

                        for (float num = a; num < b; num++)
                        {
                            if (num % 13 == 0 && num % 5 == 0)
                            {
                                sum = sum + num;
                            }

                        }
                        MessageBox.Show("Сумма равна: " + sum);

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
