using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ServicesCatalogTest
{
    class ServiceCard
    {
        bool _Visible;
        public int _Id { get; private set; }
        public int PosX { get; private set; } 
        public int PosY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public bool Visible { get { return _Visible; } set { ChangeVisible(value); _Visible = value; } }
        Form parent;
        Label Name = new Label();
        string Description;
        Label Price = new Label();
        PictureBox image = new PictureBox();
        public ServiceCard(Form form, string Name, string Description, float Price, int PosX, int PosY, int Width = 169, int Height = 209, int Id = -1, string PathToImage = "C:\\Users\\trufe\\Downloads\\Test.png")
        {
            //Задание значений полям
            this._Id = Id;
            this.Description = Description;
            this.PosX = PosX;
            this.PosY = PosY;
            this.Width = Width;
            this.Height = Height;
            this._Visible = true;
            parent = form;
            //Картинка
            if (PathToImage != null && File.Exists(PathToImage))
            {
                image.Image = new Bitmap(PathToImage); ;
            }
            else
            {
                image.Image = new Bitmap("C:\\Users\\Leyukeli\\Downloads\\Test.png");
            }
            image.Size = new Size(Width, Height);
            image.Location = new Point(PosX, PosY);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            //Название
            this.Name.Location = new Point(image.Location.X, image.Location.Y + image.Height);
            this.Name.BackColor = Color.Transparent;
            this.Name.Size = new Size(image.Width, 20);
            this.Name.Text = Name;
            this.Name.Font = new Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.ForeColor = Color.Red;
            //Цена
            this.Price.Location = new Point(this.Name.Location.X, this.Name.Location.Y + this.Name.Height);
            this.Price.BackColor = Color.Transparent;
            this.Price.Size = this.Name.Size;
            this.Price.Text = Price.ToString() + "Руб.";
            this.Price.Font = new Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = Color.Red;
            //Добавляем на форму
            form.Controls.Add(image);
            form.Controls.Add(this.Name);
            form.Controls.Add(this.Price);
        }

        public void RemoveCard()
        {
            Visible = false;
            parent.Controls.Remove(image);
            parent.Controls.Remove(Name);
            parent.Controls.Remove(Price);
        }

        public void UpdateValues(string Name, string Description, float Price, int PosX, int PosY, int Width, int Height, int Id, string PathToImage = "C:\\Users\\Leyukeli\\Downloads\\Test.png")
        {
            this.Name.Text = Name;
            this.Description = Description;
            this.PosX = PosX;
            this.PosY = PosY;
            this.Width = Width;
            this.Height = Height;
            this.Price.Text = Price.ToString() + "Руб.";
            _Id = Id;
            if (PathToImage != null && File.Exists(PathToImage))
            {
                image.Image = new Bitmap(PathToImage); ;
            }
            else
            {
                image.Image = new Bitmap("C:\\Users\\Leyukeli\\Downloads\\Test.png");
            }
        }

        public bool ChangePosition(int x, int y) //Вернет true, если позиция успешно изменена
        {
            if (x < 0 || y < 0) { return false; }
            this.PosX = x;
            this.PosY = y;
            image.Location = new Point(PosX, PosY);
            this.Name.Location = new Point(image.Location.X, image.Location.Y + image.Height);
            this.Price.Location = new Point(this.Name.Location.X, this.Name.Location.Y + this.Name.Height);
            return true;
        }

        public void ChangeVisible(bool visible)
        {
            this.Name.Visible = visible;
            this.image.Visible = visible;
            this.Price.Visible = visible;
        }
    }
}
