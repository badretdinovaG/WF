using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void лаб1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            группа newForm = new группа();
            newForm.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filText = System.IO.File.ReadAllText(filename);

            
            MessageBox.Show("Файл открыт");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void лаб2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9(this);
            newForm.Owner = this;
            newForm.Show();
        }

        private void защитаРСToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void лаб3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void часть1ToolStripMenuItem_Click(object sender, EventArgs e)
        { 

            Process.Start(@"C:\Users\DroWez\source\repos\laba3\laba3\bin\Debug\laba3.exe");
        
        }

        private void часть2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
           
            newForm.Show();
        }

        // private void лаб2ToolStripMenuItem_Click(object sender, EventArgs e)
        // {
        //    Process.Start(@"C:\Users\DroWez\source\repos\lab2 c#\lab2 winf\bin\Debug\lab2 winf.exe");
        // }
    }
}
