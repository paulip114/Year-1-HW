namespace Game
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.Left_mover = new System.Windows.Forms.Timer(this.components);
            this.Right_mover = new System.Windows.Forms.Timer(this.components);
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.EnemyCar2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar3 = new System.Windows.Forms.PictureBox();
            this.Enemy1_Mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy2_Mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy3_Mover = new System.Windows.Forms.Timer(this.components);
            this.Score_Text = new System.Windows.Forms.Label();
            this.End_Text = new System.Windows.Forms.Label();
            this.Replay_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(72, -47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(173, -47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 109);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(72, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 109);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(173, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(12, 109);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Location = new System.Drawing.Point(72, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(12, 109);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox6.Location = new System.Drawing.Point(173, 226);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(12, 109);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Location = new System.Drawing.Point(72, 365);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(12, 109);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox8.Location = new System.Drawing.Point(173, 365);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(12, 109);
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(109, 320);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(41, 81);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            this.car.Click += new System.EventHandler(this.car_Click);
            // 
            // Left_mover
            // 
            this.Left_mover.Interval = 10;
            this.Left_mover.Tick += new System.EventHandler(this.Left_mover_Tick);
            // 
            // Right_mover
            // 
            this.Right_mover.Interval = 10;
            this.Right_mover.Tick += new System.EventHandler(this.Right_mover_Tick);
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(12, -15);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(41, 66);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 9;
            this.EnemyCar1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar2.Image")));
            this.EnemyCar2.Location = new System.Drawing.Point(110, -25);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(40, 66);
            this.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar2.TabIndex = 10;
            this.EnemyCar2.TabStop = false;
            // 
            // EnemyCar3
            // 
            this.EnemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar3.Image")));
            this.EnemyCar3.Location = new System.Drawing.Point(205, -15);
            this.EnemyCar3.Name = "EnemyCar3";
            this.EnemyCar3.Size = new System.Drawing.Size(41, 66);
            this.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar3.TabIndex = 11;
            this.EnemyCar3.TabStop = false;
            // 
            // Enemy1_Mover
            // 
            this.Enemy1_Mover.Enabled = true;
            this.Enemy1_Mover.Interval = 10;
            this.Enemy1_Mover.Tick += new System.EventHandler(this.Enemy1_Mover_Tick);
            // 
            // Enemy2_Mover
            // 
            this.Enemy2_Mover.Enabled = true;
            this.Enemy2_Mover.Interval = 10;
            this.Enemy2_Mover.Tick += new System.EventHandler(this.Enemy2_Mover_Tick);
            // 
            // Enemy3_Mover
            // 
            this.Enemy3_Mover.Enabled = true;
            this.Enemy3_Mover.Interval = 10;
            this.Enemy3_Mover.Tick += new System.EventHandler(this.Enemy3_Mover_Tick);
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Text.Location = new System.Drawing.Point(3, 9);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(63, 17);
            this.Score_Text.TabIndex = 12;
            this.Score_Text.Text = "Score 0";
            this.Score_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // End_Text
            // 
            this.End_Text.AutoSize = true;
            this.End_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.End_Text.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Text.ForeColor = System.Drawing.Color.Red;
            this.End_Text.Location = new System.Drawing.Point(3, 110);
            this.End_Text.Name = "End_Text";
            this.End_Text.Size = new System.Drawing.Size(254, 53);
            this.End_Text.TabIndex = 13;
            this.End_Text.Text = "Game Over";
            this.End_Text.Visible = false;
            // 
            // Replay_Button
            // 
            this.Replay_Button.BackColor = System.Drawing.Color.Yellow;
            this.Replay_Button.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button.Location = new System.Drawing.Point(53, 194);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.Size = new System.Drawing.Size(152, 62);
            this.Replay_Button.TabIndex = 14;
            this.Replay_Button.Text = "Retry";
            this.Replay_Button.UseVisualStyleBackColor = false;
            this.Replay_Button.Visible = false;
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(258, 403);
            this.Controls.Add(this.Replay_Button);
            this.Controls.Add(this.End_Text);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.EnemyCar3);
            this.Controls.Add(this.EnemyCar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(240, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer Left_mover;
        private System.Windows.Forms.Timer Right_mover;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnemyCar2;
        private System.Windows.Forms.PictureBox EnemyCar3;
        private System.Windows.Forms.Timer Enemy1_Mover;
        private System.Windows.Forms.Timer Enemy2_Mover;
        private System.Windows.Forms.Timer Enemy3_Mover;
        private System.Windows.Forms.Label Score_Text;
        private System.Windows.Forms.Label End_Text;
        private System.Windows.Forms.Button Replay_Button;
    }
}

