using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 手機撥號畫面
{
    public partial class Form2 : Form
    {
        int x, y;
        string[,] contact ;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact[0, 1] = textBox1.Text;
            contact[0, 2] = textBox2.Text;
            contact[0, 3] = textBox3.Text;
            contact[0, 4] = textBox5.Text;
            contact[0, 5] = textBox4.Text;
            label6.Text=contact[0, 1];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
