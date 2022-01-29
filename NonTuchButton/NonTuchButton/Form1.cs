using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonTuchButton
{
    public partial class Form1 : Form
    {
        Point p;
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void TouchButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Поздравляю, ты совершил невозможное";
            if (p.X < TouchButton.Location.X || p.X > (TouchButton.Location.X + TouchButton.Size.Width))
            { label1.Text = "Ввод с клавиатуры запрещён!"; }
            if (p.Y < TouchButton.Location.Y || p.Y > (TouchButton.Location.Y + TouchButton.Height))
            { label1.Text = "Ввод с клавиатуры запрещён!"; }
            label1.Location = new Point(this.Width / 2 - TouchButton.Size.Width, 10);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void TouchButton_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "";
            Random rnd = new Random();
            a = rnd.Next() % (this.Width - TouchButton.Size.Width);
            b = rnd.Next() % (this.Height - TouchButton.Size.Height * 2);
            TouchButton.Location = new Point(a, b);
        }
    }
}
