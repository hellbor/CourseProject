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
