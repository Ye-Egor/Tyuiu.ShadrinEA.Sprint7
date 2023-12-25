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
    public partial class FormBasket : Form
    {
        public FormBasket()
        {
            InitializeComponent();
        }

        private void richTextBox_SEA_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void buttonShowFile_SEA_Click_1(object sender, EventArgs e)
        {
            // Определение пути к файлу CSV
            string filePath = $@"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint7.Var10\Basket.csv";

            // Используйте try-catch для обработки исключений при чтении файла
            try
            {
                // Проверка наличия файла перед чтением
                if (File.Exists(filePath))
                {
                    // Чтение содержимого файла
                    string fileContents = File.ReadAllText(filePath);

                    // Установка моноширинного шрифта для RichTextBox
                    richTextBox_SEA.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular);

                    // Отображение содержимого в RichTextBox с добавлением расстояния между столбцами и нумерацией строк
                    richTextBox_SEA.Text = FormatCsvData(fileContents);

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

        private string FormatCsvData(string csvData)
        {
            // Разделение строк CSV на массив строк
            string[] lines = csvData.Split('\n');

            // Обработка каждой строки, добавление нумерации и расстояния между столбцами
            for (int i = 0; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');

                // Добавление нумерации строки, исключая первую строку
                lines[i] = i == 0 ? string.Join("   ", columns) : $"{i}. " + string.Join("   ", columns);
            }

            // Сборка обработанных строк обратно в одну строку
            return string.Join("\n", lines);
        }






        private void buttonClose_SEA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_SEA_Click(object sender, EventArgs e)
        {
            FormCatalog newForm = new FormCatalog();
            newForm.Show();
            this.Hide();
        }

        private void buttonChange_SEA_Click(object sender, EventArgs e)
        {
            // Получение номера строки из textBoxNumber_SEA
            int lineNumber;
            if (int.TryParse(textBoxNumber_SEA.Text, out lineNumber))
            {
                // Проверка на номер строки
                if (lineNumber >= 1 && lineNumber <= 10)
                {
                    // Получение нового значения
                    int newQuantity;
                    if (int.TryParse(textBoxQuantity_SEA.Text, out newQuantity))
                    {
                        // Обновление значения в соответствующей строке
                        Control[] controls = Controls.Find($"labelKol{lineNumber}_SEA", true);
                        if (controls.Length > 0)
                        {
                            Label labelQuantity = (Label)controls[0];
                            labelQuantity.Text = newQuantity.ToString();

                            MessageBox.Show($"Значение quantity в строке {lineNumber} успешно изменено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Строка {lineNumber} не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректное значение для quantity.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректный номер строки (от 1 до 10).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректный номер строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonArrange_SEA_Click(object sender, EventArgs e)
        {
            FormOrder newForm = new FormOrder();
            newForm.Show();
            this.Hide();
        }
    }
}

