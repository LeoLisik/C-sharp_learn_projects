using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ServicesCatalogTest
{
    public partial class MainWindow : Form
    {
        List<ServiceCard> Cards = new List<ServiceCard>();
        Button[] ControlButtons = new Button[2];
        public MainWindow()
        {
            InitializeComponent();
            Directory.CreateDirectory("Temp");
            Application.ApplicationExit += new EventHandler(this.DeleteTempImages);
        }

        private void DeleteTempImages(object sender, EventArgs e)
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                Cards[i].RemoveCard();
            }
            Cards.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo("Temp");
            foreach (FileInfo file in dirInfo.GetFiles())
            {
                file.Delete();
            }
            Directory.Delete("Temp");
        }

        private void BuildMainPage(object sender, EventArgs e)
        {
            ChangeVisibleMainPage(true);
            for (int i = 0; i < Cards.Count; i++)
            {
                Cards[i].RemoveCard();
            }
            Cards.Clear();
            if (ControlButtons[0] != null)
            {
                foreach (Button button in ControlButtons)
                {
                    button.Visible = false;
                    this.Controls.Remove(button);
                }
            }
        }

        private void BuildCatalogPage(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            ChangeVisibleMainPage(false);
            if (button.Text[3] == ' ')
            {
                MakeAllCards();
            } else 
            {
                MakeCards(button.Text[3] - '0', 1);
                foreach (Button ControlButton in ControlButtons)
                {
                    this.Controls.Remove(ControlButton);
                }
                //Создание кнопок для перелистывания
                ControlButtons = new Button[2];
                //Кнопка влево
                ControlButtons[0] = new Button();
                ControlButtons[0].Size = new System.Drawing.Size(181, 62);
                ControlButtons[0].Location = new System.Drawing.Point(this.Size.Width / 2 - ControlButtons[0].Size.Width, this.Size.Height - ControlButtons[0].Size.Height - 50);
                ControlButtons[0].Text = "Назад";
                ControlButtons[0].Click += new System.EventHandler(SwipeCard);
                //Кнопка вправо
                ControlButtons[1] = new Button();
                ControlButtons[1].Size = new System.Drawing.Size(181, 62);
                ControlButtons[1].Location = new System.Drawing.Point(this.Size.Width / 2, this.Size.Height - ControlButtons[1].Size.Height - 50);
                ControlButtons[1].Text = "Вперед";
                ControlButtons[1].Click += new System.EventHandler(SwipeCard);
                //Добавляем на форму
                this.Controls.Add(ControlButtons[0]);
                this.Controls.Add(ControlButtons[1]);
            }
        }

        private void SwipeCard(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int page = (Cards[Cards.Count - 1]._Id / Cards.Count);
            if (button.Text[0] == 'В' && Cards[Cards.Count - 1].Visible == true)
            {
                MakeCards(Cards.Count, page + 1);
            }
            if (button.Text[0] == 'Н' && page != 1)
            {
                MakeCards(Cards.Count, page - 1);
            }
        }

        private void MakeCards(int AmountCardOnScreen, int Page)
        {
            while (Cards.Count < AmountCardOnScreen)
            {
                Cards.Add(new ServiceCard(this, "temp", "temp", 0, 10 + (145 * (Cards.Count % 4)), 40 + (259 * (Cards.Count / 4)), 135, 209));
            }
            while (Cards.Count > AmountCardOnScreen)
            {
                Cards[Cards.Count - 1].RemoveCard();
                Cards.RemoveAt(Cards.Count - 1);
            }
            if (AmountCardOnScreen == 1)
            {
                Cards[0].ChangePosition(this.Size.Width/2 - Cards[0].Width/2, Cards[0].PosY);
            } else
            {
                Cards[0].ChangePosition(10 + (145 * (Cards.Count % 4)), Cards[0].PosY);
            }
            for (int i = 0; i < Cards.Count; i++)
            {
                Cards[i].Visible = true;
            }
            using (var SqlConnection = new SqlConnection("Data Source=localhost; Integrated Security=SSPI; " +
                "Initial Catalog=ListEquipmentTest; Trusted_Connection=True;"))
            {
                int LastItemId = AmountCardOnScreen * Page;
                int FirstItemId = LastItemId - AmountCardOnScreen + 1;
                SqlCommand command = new SqlCommand("SELECT Id, Name, Photo, Description, Price FROM ServicePrices WHERE Id >= " + FirstItemId + "  AND Id <= " + LastItemId, SqlConnection);
                //Поток файла
                FileStream stream;
                //Поток записи в файл
                BinaryWriter writer;
                int BufferSize = 100;
                int AmountUpdatedCards = 0;
                string PathToImage;
                byte[] OutByte = new byte[BufferSize];
                long Retval; //Хранит кол-во считанных байтов
                long StartIndex = 0;
                //Подключение к базе, получение reader'а для полученных данных
                SqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
                for (int i = 0; i < AmountCardOnScreen && reader.Read(); i++)
                {
                    int Id = reader.GetInt32(0);
                    PathToImage = "Temp\\Image" + Id + ".png";
                    string Name = reader.GetString(1);
                    StartIndex = 0;
                    if (!File.Exists(PathToImage))
                    {
                        try
                        {
                            Retval = reader.GetBytes(2, StartIndex, OutByte, 0, BufferSize);
                            //Создаем новый поток файла и связываем с ним writer
                            stream = new FileStream(PathToImage, FileMode.OpenOrCreate, FileAccess.Write);
                            writer = new BinaryWriter(stream);
                            //Пока колличество байтов считанных из бд равно размеру буфера (Пока файл из бд не кончился)
                            //Записываем данные в файл, увеличиваем позицию считывания на размер буфера и получаем следующую часть файла
                            while (Retval == BufferSize)
                            {
                                writer.Write(OutByte);
                                writer.Flush();
                                StartIndex += BufferSize;
                                Retval = reader.GetBytes(2, StartIndex, OutByte, 0, BufferSize);
                            }
                            //Дозаписываем последнюю часть файла, закрываем поток записи и поток файла
                            writer.Write(OutByte, 0, (int)Retval);
                            writer.Flush();
                            writer.Close();
                            stream.Close();
                        }
                        catch (System.Data.SqlTypes.SqlNullValueException) { PathToImage = null; }
                    }
                    Cards[i].UpdateValues(Name, "description", (float)reader.GetDecimal(4), 10 + (145 * (i % 4)), 40 + (259 * (i / 4)), 135, 209, Id, PathToImage);
                    AmountUpdatedCards++;
                }
                reader.Close();
                SqlConnection.Close();
                if (AmountCardOnScreen != 1 && AmountUpdatedCards < AmountCardOnScreen)
                {
                    for (int i = 0; i < AmountCardOnScreen - AmountUpdatedCards; i++)
                    {
                        Cards[AmountCardOnScreen - i - 1].Visible = false;
                        Cards[AmountCardOnScreen - 1].UpdateValues("temp", "temp", 0, 10 + (145 * (Cards.Count % 4)), 40 + (259 * (Cards.Count / 4)), 135, 209, Page * AmountCardOnScreen);
                    }
                }
            }
        }

        private void MakeAllCards()
        {
            Console.WriteLine(ControlButtons.Length);
            if (ControlButtons[0] != null)
            {
                foreach (Button button in ControlButtons)
                {
                    button.Visible = false;
                    this.Controls.Remove(button);
                }
            }
            foreach (ServiceCard card in Cards)
            {
                card.RemoveCard();
            }
            Cards.Clear();
            using (var SqlConnection = new SqlConnection("Data Source=localhost; Integrated Security=SSPI; " +
                "Initial Catalog=ListEquipmentTest; Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand("SELECT Id, Name, Photo, Description, Price FROM ServicePrices", SqlConnection);
                //Поток файла
                FileStream stream;
                //Поток записи в файл
                BinaryWriter writer;
                int BufferSize = 100, Id;
                string PathToImage;
                byte[] OutByte = new byte[BufferSize];
                long Retval; //Хранит кол-во считанных байтов
                long StartIndex = 0;
                //Подключение к базе, получение reader'а для полученных данных
                SqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SequentialAccess);
                for (int i = 0; reader.Read(); i++)
                {
                    Id = reader.GetInt32(0);
                    PathToImage = "Temp\\Image" + Id + ".png";
                    string Name = reader.GetString(1);
                    StartIndex = 0;
                    if (!File.Exists(PathToImage))
                    {
                        try
                        {
                            Retval = reader.GetBytes(2, StartIndex, OutByte, 0, BufferSize);
                            //Создаем новый поток файла и связываем с ним writer
                            stream = new FileStream(PathToImage, FileMode.OpenOrCreate, FileAccess.Write);
                            writer = new BinaryWriter(stream);
                            //Пока колличество байтов считанных из бд равно размеру буфера (Пока файл из бд не кончился)
                            //Записываем данные в файл, увеличиваем позицию считывания на размер буфера и получаем следующую часть файла
                            while (Retval == BufferSize)
                            {
                                writer.Write(OutByte);
                                writer.Flush();
                                StartIndex += BufferSize;
                                Retval = reader.GetBytes(2, StartIndex, OutByte, 0, BufferSize);
                            }
                            //Дозаписываем последнюю часть файла, закрываем поток записи и поток файла
                            writer.Write(OutByte, 0, (int)Retval);
                            writer.Flush();
                            writer.Close();
                            stream.Close();
                        }
                        catch (System.Data.SqlTypes.SqlNullValueException) { PathToImage = null; }
                    }
                    Cards.Add(new ServiceCard(this, Name, "описание", (float)reader.GetDecimal(4), 10 + (145 * (i % 4)), 40 + (259 * (i / 4)), 135, 209, Id, PathToImage));
                }
                reader.Close();
                SqlConnection.Close();
            }
        }

        private void ChangeVisibleMainPage(bool Visible)
        {
            ServiceTitle.Visible = Visible;
            QuestionTitle.Visible = Visible;
            Question1.Visible = Visible;
            Question2.Visible = Visible;
            Question3.Visible = Visible;
            AnswerTitle.Visible = Visible;
            Answer1.Visible = Visible;
            Answer2.Visible = Visible;
            Answer3.Visible = Visible;
            FooterLabel.Visible = Visible;
        }
    }
}
