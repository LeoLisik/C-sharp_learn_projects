using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProgressGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Win(int PlayerNumber) 
        {
            MessageBox.Show("Player " + Convert.ToString(PlayerNumber) + " is winner!");
            Player1Progress.Value = 0;
            Player2Progress.Value = 0;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D: 
                    {
                        if (Player1Progress.Value + 3 >= 100) { Player1Progress.Value = 100;  Win(1); }
                        else { Player1Progress.Value += 3; }
                        break; 
                    }
                case Keys.A: 
                    {
                        if (Player2Progress.Value > 0) { Player2Progress.Value -= 1; }
                        break; 
                    }
                case Keys.Right: 
                    {
                        if (Player2Progress.Value + 3 >= 100) { Player2Progress.Value = 100; Win(2); }
                        else { Player2Progress.Value += 3; }
                        break; 
                    }
                case Keys.Left:
                    {
                        if (Player1Progress.Value > 0) { Player1Progress.Value -= 1; }
                        break; 
                    }
                case Keys.H:
                    {
                        MessageBox.Show("Player 1: D - to win, A - to interfere player 2\nPlayer 2: Right arrow - to win, Left arrow - to interfere player 1");
                        break;
                    }
            }
        }
    }
}
