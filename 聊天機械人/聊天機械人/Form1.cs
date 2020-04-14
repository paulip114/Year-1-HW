using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 聊天機械人
{
    public partial class Form1 : Form
    {

        public String text;
        public String response;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text += text;
            if (text == "hi" || text == "Hi" || text == "hello" || text == "Hello" || text == "你好")
            { response = "Hi! I am chatbot ~ Nice to meet you. What can I help you? ><\n\n"; }

            else if (text == "fuck you" || text == "Fuck you" || text == "fuck" || text == "Fuck")
            { response = "Fuck you toooo bro~\n\n"; }

            else if (text == "Who is your founder" || text == "Who made you" || text == "Who invented you" || text == "Who found you")
            { response = "Mr.Paul\n\n"; }

            else if (text == "Tell me who is the most beautiful girl in the world" || text == " Who is the most beautiful girl in the world" || text == "The most beautiful girl in the world?" || text == "Who is the most beautiful in the world")
            { response = "You girlfriend for sure!\n\n"; }

            else if (text == "Are you kidding me" || text == "Are you fucking kidding me" || text == "Are you fucking kidding me?" || text == "Are you kidding me?")
            { response = "Yup so what? Come on! Have a fight with me! BAD ASS #*&%@\n\n"; }

            else { response = "I don't know what you mean\n\n"; }
            label4.Text += "\n\n";
            label3.Text += response;
            textBox1.Clear();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
