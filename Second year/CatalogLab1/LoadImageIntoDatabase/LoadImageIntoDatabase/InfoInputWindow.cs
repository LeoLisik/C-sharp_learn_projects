using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LoadImageIntoDatabase
{
    
    public partial class InfoInputWindow : Form
    {
        string PathToImage;
        OpenFileDialog FileSelect = new OpenFileDialog();
        public InfoInputWindow()
        {
            InitializeComponent();
            //Задать текст textbox с подсказкой о кол-ве символов
        }

        private bool CheckCorrectInfo()
        {
            Regex regex = new Regex(@"\D");
            if (ServiceNameText.Text.Length < 1 || ServiceNameText.Text.Length > 10) { DisplayError("Название не может быть пустым или иметь больше 10 символов");  return false; }
            if (regex.Match(PriceText.Text) != Match.Empty || PriceText.Text.Length < 1) { DisplayError("В цене могут быть только цифры и она не может быть пустой"); return false; }
            if (DescriptionText.Text.Length > 50) { DisplayError("Описание не может занимать больше 50-ти символов"); return false; }
            if (PathToImage != null && !File.Exists(PathToImage)) { DisplayError("Выбранная картинка не существует"); return false; }
            if (DescriptionText.Text.Length < 1) { DescriptionText.Text = null; }
            return true;
        }

        private void ConfirmInformation(object sender, EventArgs e)
        {
            if (CheckCorrectInfo())
            {
                MainWindow owner = (MainWindow)this.Owner;
                owner.LoadImageToDatabase(ServiceNameText.Text, DescriptionText.Text, PriceText.Text, PathToImage);
                this.Close();
            }
        }

        private void SelectImage(object sender, EventArgs e)
        {
            FileSelect.Filter = "Text files (*.png)|*.png";
            if (FileSelect.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            PathToImage = FileSelect.FileName;
            UpdatePicturebox();
        }

        private void UpdatePicturebox()
        {
            ShowImagePlace.Image = new Bitmap(PathToImage);
        }

        private void DisplayError(string Message)
        {
            MessageBox.Show("Ошибка: " + Message);
        }
    }
}
