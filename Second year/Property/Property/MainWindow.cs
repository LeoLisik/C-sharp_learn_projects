using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property
{
    public partial class MainWindow : Form
    {
        Student man = new Student();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
            if (CheckData())
            {
                man.Name = NameInput.Text;
                man.Age = Convert.ToInt32(AgeInput.Text);
                man.MidMark = float.Parse(MidMarkInput.Text);
            }
        }

        private bool CheckData()
        {
            if (NameInput.TextLength < 1) { MessageBox.Show("Введите имя"); return false; }
            if (AgeInput.TextLength < 1) { MessageBox.Show("Ошибка в возрасте"); return false; }
            if (MidMarkInput.TextLength < 1) { MessageBox.Show("Ошибка в средней оценке"); return false; }
            return true;
        }

        private void GetData(object sender, EventArgs e)
        {
            OutputPlace.Text = $"Имя = {man.Name}\nВозраст = {man.Age}\nСредний бал = {man.MidMark}";
        }
    }
}
