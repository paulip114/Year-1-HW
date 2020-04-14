using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {   
        //主程式
        int speed;
        int score = 0;
        PictureBox[] road = new PictureBox[8];
        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //地圖array
            speed = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //地圖移動範圍
            int x;
            for (x = 0; x <= 7; x++)
            { road[x].Top += 2;
                if (road[x].Top >= this.Height)
                    road[x].Top = -road[x].Height;
            }
                if ((car.Bounds.IntersectsWith(EnemyCar1.Bounds)) | (car.Bounds.IntersectsWith(EnemyCar2.Bounds)) | (car.Bounds.IntersectsWith(EnemyCar3.Bounds)))
                {
                gameover();
                }
               
        }

        private void gameover()
        {
            //Gameover后動作
            Replay_Button.Visible = true;
            End_Text.Visible = true;
            RoadMover.Stop();
            Enemy1_Mover.Stop();
            Enemy2_Mover.Stop();
            Enemy3_Mover.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //按鍵使移動計時器開啓
            if ( e.KeyCode == Keys.Right)
                Right_mover.Start();
            if (e.KeyCode == Keys.Left)
                Left_mover.Start();
            if (e.KeyCode == Keys.Enter)
                Replay_Button_Click(null,null);
        }

        private void Left_mover_Tick(object sender, EventArgs e)
        {
            //主車移動範圍
            if (car.Location.X > 0 )
                car.Left -= 5;
        }

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            //主車移動範圍
            if (car.Location.X <= 160)
                car.Left += 5;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //放鍵使計時器停止
            Right_mover.Stop();
            Left_mover.Stop();
        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void Enemy1_Mover_Tick(object sender, EventArgs e)
        {
            //敵車1移動範圍
            EnemyCar1.Top += 3;
            if (EnemyCar1.Top >= this.Height)
            {
                score += 1;
                Score_Text.Text = "Score " + score;
                    EnemyCar1.Top = -EnemyCar1.Height;
                    EnemyCar1.Top = -(Convert.ToInt32(rnd.Next(0, 150)) + EnemyCar1.Height);
                    EnemyCar1.Left = Convert.ToInt32(rnd.Next(0, 160)) + 0;
            }
        }

        private void Enemy2_Mover_Tick(object sender, EventArgs e)
        {
            //敵車2移動範圍
            EnemyCar2.Top += 3;
            if (EnemyCar2.Top >= this.Height)
            {
                score += 1;
                Score_Text.Text = "Score " + score;
                EnemyCar2.Top = -EnemyCar2.Height;
                EnemyCar2.Top = -(Convert.ToInt32(rnd.Next(0, 150)) + EnemyCar2.Height);
                EnemyCar2.Left = Convert.ToInt32(rnd.Next(0, 160)) + 0;

            }
            
        }

        private void Enemy3_Mover_Tick(object sender, EventArgs e)
        {
            //敵車3移動範圍
            EnemyCar3.Top += 4;
            if (EnemyCar3.Top >= this.Height)
            {
                score += 1;
                Score_Text.Text = "Score " + score;
                EnemyCar3.Top = -EnemyCar3.Height;
                EnemyCar3.Top = -(Convert.ToInt32(rnd.Next(0, 150)) + EnemyCar3.Height);
                EnemyCar3.Left = Convert.ToInt32(rnd.Next(0, 160)) + 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Replay_Button_Click(object sender, EventArgs e)
        {
            //重玩按鈕
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);

        }

        
    }
}
