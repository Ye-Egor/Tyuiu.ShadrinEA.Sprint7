using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.ShadrinEA.Sprint7.Project.V10
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonClose_SEA_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonBack_SEA_Click(object sender, EventArgs e)
        {
            FormBasket newForm = new FormBasket();
            newForm.Show();
            this.Hide();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonShow_SEA_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var randomBetween10And20 = rnd.Next(1000,9999);
            labelNumber0_SEA.Text = rnd.Next().ToString();
            labelData0_SEA.Text = "4 рабочих дня";


            string filePath = $@"{Directory.GetCurrentDirectory()}\Basket.csv";

            try
            {
                // проверка наличия файла
                if (File.Exists(filePath))
                {
                    DataTable dataTable = ReadCsvFile(filePath);

                    dataGridViewBsket_SEA.DataSource = dataTable;

                    // изменение ширины столбцов
                    dataGridViewBsket_SEA.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
                else
                {
                    MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private DataTable ReadCsvFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            // создание заголовков столбцов
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                string[] headers = lines[0].Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header.Trim());
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    DataRow row = dataTable.NewRow();

                    for (int j = 0; j < headers.Length && j < data.Length; j++)
                    {
                        row[j] = data[j].Trim();
                    }

                    dataTable.Rows.Add(row);
                }
            }

            return dataTable;

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_SEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowFile_SEA_Click(object sender, EventArgs e)
        {
            string number = labelNumber0_SEA.Text;
            string data = labelData0_SEA.Text;
            string q = labelQ0_SEA.Text;
            string surname = textBoxSurname_SEA.Text;
            string name = textBoxName_SEA.Text;
            string patronym = textBoxPatronyc_SEA.Text;
            string num = textBoxNum_SEA.Text;
            string address = textBoxAddress_SEA.Text;
            string tel = textBoxTel_SEA.Text;

            // Составление строки данных в формате CSV с заголовками
            string csvData = "Номер заказа;Дата исполнения;Стоимость заказа;Фамилия;Имя;Отчество;Номер счета;Адрес;Номер телефона\n";
            csvData += $"{number};{data};{q};{surname};{name};{patronym};{num};{address};{tel}\n";

            string outputFilePath = $@"{Directory.GetCurrentDirectory()}\OutputFile.csv";

            string inputFilePath = $@"{Directory.GetCurrentDirectory()}\Basket.csv";

            try
            {
                File.AppendAllText(outputFilePath, csvData);

                if (File.Exists(inputFilePath))
                {
                    string basketData = File.ReadAllText(inputFilePath);
                    File.AppendAllText(outputFilePath, basketData);
                }

                MessageBox.Show("Данные успешно добавлены в файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при добавлении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
