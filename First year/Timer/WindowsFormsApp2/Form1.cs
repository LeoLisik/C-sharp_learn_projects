using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private int Seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ProgressBar.Step = Convert.ToInt32(ChooseBox.SelectedItem);
            if (!timer1.Enabled) { Seconds = 0; CountSeconds.Text = Convert.ToString(Seconds) + " Sec"; }
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value + ProgressBar.Step <= 100) { ProgressBar.PerformStep(); }
            else { ProgressBar.Value = 100; }
            Seconds++;
            CountSeconds.Text = Convert.ToString(Seconds) + " Sec";
        }
    }
}
