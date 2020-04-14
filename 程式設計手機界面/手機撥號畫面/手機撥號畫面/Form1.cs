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
    public partial class Form1 : Form
    {
        public object ListBox11 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "#";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button16.Visible = true;
            label4.Visible = false;
            tabPage3.BackColor = Color.FromName("Aquamarine");
            textBox1.BackColor = Color.FromName("Aquamarine");
            textBox1.ForeColor = Color.FromName("Black");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
   

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button16.Visible = false;
            label4.Visible = true;
            tabPage3.BackColor = Color.FromName("Navy");
            textBox1.BackColor = Color.FromName("Navy");
            textBox1.ForeColor = Color.FromName("White");
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox11_MouseClick(object sender, MouseEventArgs e)
        {
           //textBox1 = listBox11_MouseClick;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
        }
        private void listBox11_MouseUp(object sender, MouseEventArgs e)
        {
            //點擊listbox 其中一項item時，將資料複製到textbox1,將tapcontrol 切換到鍵盤版面
            // textBox1.Text = listBox11.Text.StartsWith(listBox11.Text.Length - 9);
            
        }

        
    }
}
