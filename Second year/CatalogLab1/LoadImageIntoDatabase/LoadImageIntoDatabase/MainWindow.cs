using System;
using System.Diagnostics;
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

namespace LoadImageIntoDatabase
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetImageFromDatabase(object sender, EventArgs e)
        {
            //Подключение к бд
            using (var SqlConnection = new SqlConnection("Data Source=localhost; Integrated Security=SSPI; " +
                "Initial Catalog=ListEquipmentTest; Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand("SELECT Id, Photo FROM ServicePrices", SqlConnection);
                //Поток файла
                FileStream stream;
                //Поток записи в файл
                BinaryWriter writer;

                int BufferSize = 100; //Размер буфера
                byte[] OutByte = new byte[BufferSize]; //Буфер для байтов
                long Retval; //Хранит кол-во считанных байтов
                long StartIndex = 0; //
                int Id; //Хранит id товара, который обрабатывается

                //Подключение к базе, получение reader'а для полученных данных
                SqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.SequentialAccess);

                //Пока есть данные для чтения
                while (reader.Read())
                {
                    Id = Convert.ToInt32(reader.GetInt32(0));

                    StartIndex = 0;

                    //Читаем байты в буфер и сохраняем колличество считанных, пропускаем итерацию, если пришел null
                    try
                    {
                        Retval = reader.GetBytes(1, StartIndex, OutByte, 0, BufferSize);
                    } catch (System.Data.SqlTypes.SqlNullValueException) { continue; }
                    
                    //Создаем новый поток файла и связываем с ним writer
                    stream = new FileStream("Image" + Id + ".png", FileMode.OpenOrCreate, FileAccess.Write); 
                    writer = new BinaryWriter(stream);
                    
                    //Пока колличество байтов считанных из бд равно размеру буфера (Пока файл из бд не кончился)
                    //Записываем данные в файл, увеличиваем позицию считывания на размер буфера и получаем следующую часть файла
                    while (Retval == BufferSize)
                    {
                        writer.Write(OutByte);
                        writer.Flush();
                        StartIndex += BufferSize;
                        Retval = reader.GetBytes(1, StartIndex, OutByte, 0, BufferSize);
                    }

                    //Дозаписываем последнюю часть файла, закрываем поток записи и поток файла
                    writer.Write(OutByte, 0, (int)Retval);
                    writer.Flush();

                    writer.Close();
                    stream.Close();
                    //Переходим к следующему файлу
                }

                //Все файлы считаны - закрываем считыватель из бд и соединение с бд
                //Выводим сообщение об успешном выполнении
                reader.Close();
                SqlConnection.Close();
                Console.WriteLine("Выгрузка выполнена");
                Process.Start("C:\\Users\\Leyukeli\\source\\repos\\C#\\LoadImageIntoDatabase\\LoadImageIntoDatabase\\bin\\Debug");
            }
        }

        private void InputInfoForLoadImages(object sender, EventArgs e)
        {
            //Создадим форму для ввода данных
            InfoInputWindow InputWindow = new InfoInputWindow();
            InputWindow.Owner = this;
            InputWindow.ShowDialog();
        }

        public void LoadImageToDatabase(string ServiceName = "default", string ServiceDescription = null, string Price = "0", string PathToPhoto = null)
        {
            //Подключение к бд
            using (var SqlConnection = new SqlConnection("Data Source=localhost; Integrated Security=SSPI; " +
                "Initial Catalog=ListEquipmentTest; Trusted_Connection=True;"))
            {
                //Команда вставки строки в таблицу
                SqlCommand command = new SqlCommand(
                "INSERT INTO ServicePrices (Name, Photo, " +
                "Description, Price) " +
                "Values(@Name, @Photo, @Description, " +
                "@Price)", SqlConnection);

                //Присвоение значений для вставки
                command.Parameters.Add("@Name", SqlDbType.NVarChar, 20).Value = ServiceName;
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;

                if (ServiceDescription != null)
                {
                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = ServiceDescription;
                } else
                {
                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 50).Value = DBNull.Value;
                }

                //Значение картинки
                if (PathToPhoto != null)
                {
                    byte[] image = GetPhoto(PathToPhoto);
                    command.Parameters.Add("@Photo", SqlDbType.Image, image.Length).Value = image;
                } else
                {
                    command.Parameters.Add("@Photo", SqlDbType.Image).Value = DBNull.Value;
                }


                //Открываем соединение к бд
                SqlConnection.Open();
                //Выполнение команды
                command.ExecuteNonQuery();
                //Закрываем соединение
                SqlConnection.Close();
                MessageBox.Show("Строка создана успешно:)");
            }
        }

        public static byte[] GetPhoto(string filePath)
        {
            //Открываем файловый поток
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //Создаем бинарный считыватель из потока
            BinaryReader reader = new BinaryReader(stream);

            //Читаем картинку в массив байтов
            byte[] photo = reader.ReadBytes((int)stream.Length);

            //Закрываем считыватель и поток
            reader.Close();
            stream.Close();

            //Возвращяем массив байтов картинки
            return photo;
        }
    }
}
