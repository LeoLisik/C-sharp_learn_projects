using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private bool Check()
        {
            int p = 0;
            string a=textBox1.Text, b=textBox2.Text;
            if (a.Length == 0 || b.Length == 0) { return false; }
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] <= 47 || a[i] >= 58) && (a[i] != 44 && a[i] != 45)) { return false; }
                if (a[i] == 44) { p++; if (p > 1) { return false; } }
                if (a[i] == 45 && i != 0) { return false; }
                if ((a[i] > 47 || a[i] < 58) && (i + 1 == a.Length)) { return false; }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if ((b[i] <= 47 || b[i] >= 58) && (b[i] != 45 && b[i] != 44)) { return false; }
                if (b[i] == 44) { p++; if (p > 1) { return false; } }
                if (b[i] == 45 && i != 0) { return false; }
                if ((b[i] > 47 || b[i] < 58) && (i + 1 == b.Length)) { return false; }
            }
            return true;
        }

        void Button_click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            if (Check())
            {
                switch (button1.Text[0])
                {
                    case 'A':
                        {
                            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
                            break;
                        }
                    case 'S':
                        {
                            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
                            break;
                        }
                    case 'M':
                        {
                            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
                            break;
                        }
                    case 'D':
                        {
                            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                            break;
                        }
                }
            } else {
                textBox3.Text = "ERROR";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
