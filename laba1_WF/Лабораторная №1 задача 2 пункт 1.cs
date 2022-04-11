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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = int.TryParse(textBox1.Text, out var num);
            var count = 0;
            var tmpNum = num;
            string itog;
            itog = "";
            if (result == true && num > 0)
            {
                bool resulta = float.TryParse(textBox2.Text, out var a);

                if (resulta == true)
                {

                    bool resultb = float.TryParse(textBox3.Text, out var b);


                    if (resultb == true)
                    {
                        while (tmpNum > 0)
                        {
                            if (tmpNum % 10 > a)
                            {
                                count = count + 1;
                            }
                            tmpNum = tmpNum / 10;
                        }
                       
                        itog += "Количество цифр в числе больших " + a + " - " + count + "\n";
                       // itog += "Номер символа фамилии " + x + "; номер символа имени " + y + "; поразрядная сумма = " + sum + "\n";
                        

                        if (num > a && num < b && num % 3 == 0 && num % 4 == 0 && num % 5 == 0)
                        {
                            itog += "\nВерно: кратно и принадлежит отрезку от А до В";
                        }
                        else
                        {
                           
                            itog += "Неверно, не принадлежит отрезку от А до В или некратно";
                        }
                    }
                    else
                    {
                        
                        itog += "Не корректное число B!";
                        
                    }

                }
                else
                {
                    
                    
                    itog += "Не корректное число A!";
                }
            }
            else
            {
    
                itog += "Не корректное число!";
            }

            MessageBox.Show(itog);

        }
        }
    }
