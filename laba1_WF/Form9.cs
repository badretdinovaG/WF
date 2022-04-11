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
    public partial class Form9 : Form
    {
        public int t = 0;

        public Form9(Form1 newform)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (checkBox1.Checked)
            {
                timer1.Start();
                timer1.Interval = 2000;
            }


            Form1 main = this.Owner as Form1;
            int i;
            int n = Convert.ToInt32(numericUpDown1.Value);
            dataGridView1.TopLeftHeaderCell.Value = "Индекс: ";
            int count = 0;

            if (radioButton1.Checked)
            {

                try
                {

                    int[] P = new int[n];
                    int[] M = new int[n + 1];
                    dataGridView1.RowCount = 2;
                    dataGridView1.ColumnCount = n;

                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[0].HeaderCell.Value = Convert.ToString("P");
                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[1].HeaderCell.Value = Convert.ToString("M");
                    for (i = 0; i < n; i++)
                        dataGridView1.Columns[i].HeaderText = Convert.ToString(i);


                    Random rand = new Random();
                    int tmp = 1;

                    while (count < n)
                    {

                        for (i = 0; i < P.Length; i++)
                        {
                            dataGridView1.Columns[i].Name = count.ToString();

                            dataGridView1.Rows[0].Cells[i].ReadOnly = true;

                            P[i] = rand.Next(-100, 100);
                            dataGridView1.Rows[0].Cells[count].Value = P[i].ToString();
                            count++;


                        }
                        count = 0;
                        for (i = 0; i < M.Length; i++)
                        {

                            dataGridView1.Rows[1].Cells[i].ReadOnly = true;

                            M[i] = P[i];
                            if (i % 2 != 0)
                            {
                                M[i] = (-1) * P[i];
                            }

                            if (i % 2 == 0)
                            {
                                M[i] = i * P[i];
                            }
                            if (M[i] % 3 == 0)
                            {
                                M[i] = M[i] * P[3];
                            }
                            if (M[i] < 0 && tmp > 0)
                            {
                                M[i] = 0;
                                tmp--;
                            }

                            dataGridView1.Rows[1].Cells[count].Value = M[i].ToString();
                            count++;
                        }
                    }
                }
                catch ( IndexOutOfRangeException exk)
                {

                    if (n < 4)
                    {
                        timer1.Stop();
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();

                        main.textBox1.Text += exk.Message + " Дата: " + date + "  Время: " + time + "  Метод, в котором, вызвано исключение:  "+ exk.Source + exk.TargetSite + Environment.NewLine;

                        MessageBox.Show("Вы выбрали  количество элементов массива для некорректной работы программы!!!");
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        radioButton1.Checked = false;

                    }
                }

                catch (Exception exk)
                {
                    if (textBox1.Text != "") // СЛУЧАЙНЫЙ
                    {
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();
                        main.textBox1.Text +="Произошел ввод частоты" + " Дата: " + date + "  Время: " + time + "  Метод, в котором, вызвано исключение:  "  + exk.TargetSite + Environment.NewLine;
                        textBox1.Clear();
                        MessageBox.Show("Частота не нужна!");
                    }
                }                
            }

            else if (radioButton2.Checked) // РУЧНОЙ
            {
                try
                {

 
                    int tmp = 1;
                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[0].HeaderCell.Value = Convert.ToString("P");
                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[1].HeaderCell.Value = Convert.ToString("M");



                    int[] P = new int[n];
                    int[] M = new int[n];
                    dataGridView1.RowCount = 2;
                    dataGridView1.ColumnCount = n;

                    while (i < P.Length)
                    {
                        P[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
                        i++;
                    }
                    for (i = 0; i < n; i++)
                        dataGridView1.Columns[i].HeaderText = Convert.ToString(i);

                    for (i = 0; i < M.Length; i++)
                        P[i] = Convert.ToInt32(dataGridView1[i, 0].Value);


                    Random random = new Random();
                    while (count < n)
                    {
                        for (i = 0; i < M.Length; i++)
                        {

                            M[i] = P[i];
                            if (i % 2 != 0)
                            {
                                M[i] = (-1) * P[i];
                            }

                            if (i % 2 == 0)
                            {
                                M[i] = i * P[i];
                            }
                            if (M[i] % 3 == 0)
                            {
                                M[i] = M[i] * P[3];
                            }
                            if (M[i] < 0 && tmp > 0)
                            {
                                M[i] = 0;
                                tmp--;
                            }


                            dataGridView1.Rows[1].Cells[count].Value = M[i].ToString();
                            count++;
                        }

                    }
                }

                catch (IndexOutOfRangeException exk)
                {

                    if (n < 4)
                    {
                        timer1.Stop();
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();

                        main.textBox1.Text += exk.Message + " Дата: " + date + "  Время: " + time + "  Метод, в котором, вызвано исключение:  " + exk.TargetSite + Environment.NewLine;

                        MessageBox.Show("Вы выбрали  количество элементов массива для некорректной работы программы!!!");
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        radioButton1.Checked = false;

                    }
                }

                  if (textBox1.Text != "") 
                    {
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();
                        main.textBox1.Text += "Произошел ввод частоты" + " Дата: " + date + "  Время: " + time  + Environment.NewLine;
                        textBox1.Clear();
                        MessageBox.Show("Частота не нужна!");
                    }

                    if (checkBox1.Checked)
                    {
                         textBox1.Clear();
                         MessageBox.Show("Таймер не нужен");
                         string date = DateTime.Now.ToLongDateString();
                         string time = DateTime.Now.ToLongTimeString();
                         main.textBox1.Text += "Включение таймера " + " Дата: " + date + "  Время: " + time  + Environment.NewLine;
                         timer1.Stop();
                         checkBox1.Checked = false;
                    }
                
            }

           else if (radioButton3.Checked) //СЛУЧАЙНЫЙ С ЧАСТОТОЙ
            {
               

                try
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    int[] P = new int[n];
                    int[] M = new int[n];
                    int k;
                    int.TryParse(textBox1.Text, out k);
                    dataGridView1.RowCount = 2;
                    dataGridView1.ColumnCount = n;

                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[0].HeaderCell.Value = Convert.ToString("P");
                    for (i = 0; i < n; i++)
                        dataGridView1.Rows[1].HeaderCell.Value = Convert.ToString("M");
                    for (i = 0; i < n; i++)
                        dataGridView1.Columns[i].HeaderText = Convert.ToString(i);

                    Random rand = new Random();
                    int tmp = 1;

                    while (count < n)
                    {

                        for (i = 0; i < P.Length; i++)
                        {
                            dataGridView1.Columns[i].Name = count.ToString();

                            dataGridView1.Rows[0].Cells[i].ReadOnly = true;

                            P[0] = rand.Next(-100, 100);
                            if (i > 1)
                            {

                                P[i] = P[i - 1] + k;
                            }
                            else if (i == 0)
                            {
                                P[1] = P[0] + k;
                            }
                            dataGridView1.Rows[0].Cells[count].Value = P[i].ToString();
                            count++;

                        }
                        count = 0;
                        for (i = 0; i < M.Length; i++)
                        {

                            dataGridView1.Rows[1].Cells[i].ReadOnly = true;

                            M[i] = P[i];
                            if (i % 2 != 0)
                            {
                                M[i] = (-1) * P[i];
                            }

                            if (i % 2 == 0)
                            {
                                M[i] = i * P[i];
                            }
                            if (M[i] % 3 == 0)
                            {
                                M[i] = M[i] * P[3];
                            }
                            if (M[i] < 0 && tmp > 0)
                            {
                                M[i] = 0;
                                tmp--;
                            }

                            dataGridView1.Rows[1].Cells[count].Value = M[i].ToString();
                            count++;
                        }
                    }
                }
                catch (IndexOutOfRangeException exk)
                {

                    if (n < 4)
                    {
                        timer1.Stop();
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();

                        main.textBox1.Text += exk.Message + " Дата: " + date + "  Время: " + time  + exk.TargetSite + Environment.NewLine;

                        MessageBox.Show("Вы выбрали  количество элементов массива для некорректной работы программы!!!");
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        radioButton1.Checked = false;

                    }
                }
                
                
               
                    if (textBox1.Text == "") // Ввести частоту
                    {
                        string date = DateTime.Now.ToLongDateString();
                        string time = DateTime.Now.ToLongTimeString();
                        main.textBox1.Text +=  "Ввод частоты не был воспроизведен " + " Дата: " + date + "  Время: " + time + Environment.NewLine;
                        textBox1.Clear();
                        MessageBox.Show("А кто частоту введет?");
                    }

                
           }
           
            else
            {
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();

                main.textBox1.Text += "Не выбран способ ввода массива - " + " Дата: " + date + "  Время: " + time  + Environment.NewLine;
                MessageBox.Show("Вы не выбрали способ ввода массива!!!");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 30;
            dataGridView1.RowCount = 2;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.RemoveAt(0);

        }

      

        private void timer1_Tick(object sender, EventArgs e) //ТАЙМЕР
        {            
            button1_Click ( sender,  e); // вызов метода   
        } 

            private void button3_Click(object sender, EventArgs e)
            {
                timer1.Stop();
            }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)

        {
            int k = 0;
            
            
               
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '-')))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        k++;
                    }
                }
            
           
           
            
                if (k > 0)
                {
                    Form1 main = this.Owner as Form1;

                    string date = DateTime.Now.ToLongDateString();
                    string time = DateTime.Now.ToLongTimeString();

                    main.textBox1.Text += "Была попытка ввода строкй информации-  " + " Дата: " + date + "  Время: " + time + Environment.NewLine;
                    MessageBox.Show("Нет возможности ввода строковой информации");
                }
            
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
            }
        }

        private void dataGridView1_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
} 