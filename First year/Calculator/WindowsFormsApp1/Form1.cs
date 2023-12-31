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

        private bool Check(string CheckedStr)
        {
            if (CheckedStr[CheckedStr.Length - 1] < '0' || CheckedStr[CheckedStr.Length - 1] > '9') { return false; } 
            if (CheckedStr.LastIndexOf(',') - CheckedStr.IndexOf(',') > 0 || CheckedStr.LastIndexOf('-') > 0) { return false; }
            return true;
        }

        void Button_click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            if (Check(textBox1.Text) && Check(textBox2.Text))
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
                MessageBox.Show("You made a mistake somewhere. Check the entered numbers.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ',' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You can input only nubers, minus and comma!");
                return;
            }
        }
    }
}
