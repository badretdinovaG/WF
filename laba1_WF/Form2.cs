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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }
    }
}
