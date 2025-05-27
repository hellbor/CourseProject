namespace Game
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbl_score = new System.Windows.Forms.Label();
			this.lbl_over = new System.Windows.Forms.Label();
			this.enemy_2 = new System.Windows.Forms.PictureBox();
			this.enemy_1 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.player = new System.Windows.Forms.PictureBox();
			this.bullet_player = new System.Windows.Forms.PictureBox();
			this.bullet_enemy_1 = new System.Windows.Forms.PictureBox();
			this.bullet_enemy_2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.enemy_2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_enemy_1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_enemy_2)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbl_score
			// 
			this.lbl_score.AutoSize = true;
			this.lbl_score.BackColor = System.Drawing.Color.Black;
			this.lbl_score.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_score.ForeColor = System.Drawing.Color.Yellow;
			this.lbl_score.Location = new System.Drawing.Point(327, 4);
			this.lbl_score.Name = "lbl_score";
			this.lbl_score.Size = new System.Drawing.Size(76, 19);
			this.lbl_score.TabIndex = 20;
			this.lbl_score.Text = "Score : 0";
			// 
			// lbl_over
			// 
			this.lbl_over.AutoSize = true;
			this.lbl_over.BackColor = System.Drawing.Color.Transparent;
			this.lbl_over.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_over.ForeColor = System.Drawing.Color.Red;
			this.lbl_over.Location = new System.Drawing.Point(249, 127);
			this.lbl_over.Name = "lbl_over";
			this.lbl_over.Size = new System.Drawing.Size(279, 57);
			this.lbl_over.TabIndex = 21;
			this.lbl_over.Text = "Game-Over";
			// 
			// enemy_2
			// 
			this.enemy_2.Image = global::Game.Properties.Resources.player_2_;
			this.enemy_2.Location = new System.Drawing.Point(604, 297);
			this.enemy_2.Name = "enemy_2";
			this.enemy_2.Size = new System.Drawing.Size(60, 45);
			this.enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemy_2.TabIndex = 16;
			this.enemy_2.TabStop = false;
			this.enemy_2.Tag = "enemy";
			// 
			// enemy_1
			// 
			this.enemy_1.Image = global::Game.Properties.Resources.player_2_;
			this.enemy_1.Location = new System.Drawing.Point(604, 58);
			this.enemy_1.Name = "enemy_1";
			this.enemy_1.Size = new System.Drawing.Size(60, 45);
			this.enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.enemy_1.TabIndex = 15;
			this.enemy_1.TabStop = false;
			this.enemy_1.Tag = "enemy";
			// 
			// pictureBox14
			// 
			this.pictureBox14.BackColor = System.Drawing.Color.Black;
			this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox14.Location = new System.Drawing.Point(0, 386);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(734, 25);
			this.pictureBox14.TabIndex = 14;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.Color.Black;
			this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox13.Location = new System.Drawing.Point(0, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(734, 23);
			this.pictureBox13.TabIndex = 13;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(261, 367);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(221, 19);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox12.TabIndex = 12;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Tag = "block";
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(501, 20);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(221, 19);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 11;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Tag = "block";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(501, 367);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(221, 19);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 10;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Tag = "block";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(12, 367);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(221, 19);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Tag = "block";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(261, 20);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(221, 19);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Tag = "block";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(12, 20);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(221, 19);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 7;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Tag = "block";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(12, 308);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(58, 53);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Tag = "block";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(54, 50);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(58, 53);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "block";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(252, 127);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(58, 53);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "block";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(470, 50);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(58, 53);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "block";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(387, 297);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(58, 53);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "block";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(642, 202);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 53);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "block";
			// 
			// player
			// 
			this.player.BackColor = System.Drawing.Color.Transparent;
			this.player.Image = global::Game.Properties.Resources.player_1_;
			this.player.Location = new System.Drawing.Point(32, 209);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(58, 46);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// bullet_player
			// 
			this.bullet_player.BackColor = System.Drawing.Color.Transparent;
			this.bullet_player.Image = global::Game.Properties.Resources.bullet_player;
			this.bullet_player.Location = new System.Drawing.Point(96, 226);
			this.bullet_player.Name = "bullet_player";
			this.bullet_player.Size = new System.Drawing.Size(23, 13);
			this.bullet_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.bullet_player.TabIndex = 17;
			this.bullet_player.TabStop = false;
			// 
			// bullet_enemy_1
			// 
			this.bullet_enemy_1.BackColor = System.Drawing.Color.Transparent;
			this.bullet_enemy_1.Image = global::Game.Properties.Resources.bullet_enemy;
			this.bullet_enemy_1.Location = new System.Drawing.Point(575, 74);
			this.bullet_enemy_1.Name = "bullet_enemy_1";
			this.bullet_enemy_1.Size = new System.Drawing.Size(23, 13);
			this.bullet_enemy_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.bullet_enemy_1.TabIndex = 18;
			this.bullet_enemy_1.TabStop = false;
			// 
			// bullet_enemy_2
			// 
			this.bullet_enemy_2.BackColor = System.Drawing.Color.Transparent;
			this.bullet_enemy_2.Image = global::Game.Properties.Resources.bullet_enemy;
			this.bullet_enemy_2.Location = new System.Drawing.Point(575, 312);
			this.bullet_enemy_2.Name = "bullet_enemy_2";
			this.bullet_enemy_2.Size = new System.Drawing.Size(23, 13);
			this.bullet_enemy_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.bullet_enemy_2.TabIndex = 19;
			this.bullet_enemy_2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 411);
			this.Controls.Add(this.lbl_over);
			this.Controls.Add(this.lbl_score);
			this.Controls.Add(this.enemy_2);
			this.Controls.Add(this.enemy_1);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.player);
			this.Controls.Add(this.bullet_player);
			this.Controls.Add(this.bullet_enemy_1);
			this.Controls.Add(this.bullet_enemy_2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TankGame";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.enemy_2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_enemy_1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bullet_enemy_2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox enemy_1;
		private System.Windows.Forms.PictureBox enemy_2;
		private System.Windows.Forms.PictureBox bullet_player;
		private System.Windows.Forms.PictureBox bullet_enemy_1;
		private System.Windows.Forms.PictureBox bullet_enemy_2;
		private System.Windows.Forms.Label lbl_score;
		private System.Windows.Forms.Label lbl_over;
	}
}

