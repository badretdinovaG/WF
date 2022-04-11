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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int i, j, x, y, sum, minlen, maxlen;
                string str_surname, str_name, sum_string, itog, tail_string;
                bool a = false;
                char[] sum_char = new char[35];
                char[] tail_char = new char[18];

                str_surname =  textBox1.Text;
                
                str_name = textBox2.Text;
                
                char[] surname_char = str_surname.ToCharArray();
                char[] name_char = str_name.ToCharArray();
                int surname_len = surname_char.Length;
                int name_len = name_char.Length;

                if (surname_len < name_len)
                {
                    minlen = surname_len;
                }
                else
                {
                    minlen = name_len;
                }
                i = 0;
                j = 0;
                itog = "";

                while (i != minlen)
                {
                    x = surname_char[i];
                    y = name_char[i];
                    sum = x | y;
                    //MessageBox.Show("Номер символа фамилии " + x + "; номер символа имени " + y + "; поразрядная сумма = " + sum);
                    itog += "Номер символа фамилии " + x + "; номер символа имени " + y + "; поразрядная сумма = " + sum  + "\n" ;
                    sum_char[i] = (char)sum;
                    i++;
                }
                sum_string = "";
                for (int k = 0; k < minlen; k++)
                {
                    sum_string += sum_char[k];
                }
                itog += "\nРезультат: " + sum_string;
                
               


                if (surname_len < name_len)
                {
                    maxlen = name_len;
                    while (i != maxlen)
                    {
                        tail_char[j] = name_char[i];
                        j++;
                        i++;
                    }

                   
                }

                else if (name_len < surname_len)
                {
                    maxlen = surname_len;
                    while (i != maxlen)
                    {
                        tail_char[j] = surname_char[i];
                        j++;
                        i++;
                    }

                }
                else
                {
                    a = true;
                    maxlen = 1;
                }
              

                tail_string = "";
                for (int k = 0; k < maxlen; k++)
                {
                    tail_string += tail_char[k];
                }

                if (a == true)
                {
                    itog += "\nХвоста нет";
                }
                else
                {
                    itog += "\nХвост = " + tail_string;                 
                }

                 MessageBox.Show(itog);
            }
        }
    }
}
