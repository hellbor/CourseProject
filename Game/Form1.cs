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
		public Form1()
		{
			InitializeComponent();
		}

		bool up, down, right;
		Random rnd = new Random();
		int score;

		void Bullets()
		{
			bullet_player.Left += 20;
			if(bullet_player.Left > 400) 
			{
				bullet_player.Left = player.Left;
				bullet_player.Top = player.Top + 15;
				bullet_player.Image = Properties.Resources.bullet_player;
			}
			bullet_enemy_1.Left -= 10;
			if(bullet_enemy_1.Left < 10)
			{
				bullet_enemy_1.Image = Properties.Resources.bullet_enemy;
				bullet_enemy_1.Left = enemy_1.Left;
				bullet_enemy_1.Top = enemy_1.Top + 15;
			}
			bullet_enemy_2.Left -= 10;
			if(bullet_enemy_2.Left < 10)
			{
				bullet_enemy_2.Image = Properties.Resources.bullet_enemy;
				bullet_enemy_2.Left = enemy_2.Left;
				bullet_enemy_2.Top = enemy_2.Top + 15;
			}
		}

		void Enemies()
		{
			foreach(Control control in this.Controls) 
			{
				if (control is PictureBox && control.Tag == "enemy")
				{
					control.Left -= 6;
					if(control.Left < 10)
					{
						int i = rnd.Next(50,600);
						control.Location = new Point(800,i);
					}
					if(bullet_player.Bounds.IntersectsWith(control.Bounds)) 
					{
						score += 5;
						lbl_score.Text = "Score : " + score;
						control.Left = 800;
						bullet_player.Image = Properties.Resources.explosion;
					}
				}
			}
		}

		void Block()
		{
			foreach (Control control in this.Controls)
			{
				if (control is PictureBox && control.Tag == "block")
				{
					if (control.Left <- 150)
					{
						control.Left = 700;
					}
					if (right == true)
					{
						control.Left -= 5;
					}
				}
			}
		}

		void player_move()
		{
			if (up == true)
			{
				if (player.Top > 50)
				{
					player.Top -= 5;
				}
			}
			if (down == true)
			{
				if (player.Top < 300)
				{
					player.Top += 5;
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			player_move();
			Block();
			Enemies();
			Bullets();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up: up = true; break;
				case Keys.Down: down = true; break;
				case Keys.Right: right = true; break;
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up: up = false; break;
				case Keys.Down: down = false; break;
				case Keys.Right: right = false; break;
			}
		}
	}
}
