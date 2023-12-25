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
            // проверка наличия данных
            if (dataGridViewBsket_SEA.Rows.Count > 0)
            {
                int lastColumnIndex = dataGridViewBsket_SEA.Columns.Count - 1;
                double sum = 0;

                // суммирование значений
                foreach (DataGridViewRow row in dataGridViewBsket_SEA.Rows)
                {
                    sum += Convert.ToDouble(row.Cells[lastColumnIndex].Value);
                }

                // вывод суммы
                dataGridViewBsket_SEA.Rows[dataGridViewBsket_SEA.Rows.Count - 1].Cells[lastColumnIndex].Value = sum;
            }
            else
            {
                MessageBox.Show("Нет данных для подсчета суммы.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void buttonArrange_SEA_Click(object sender, EventArgs e)
        {
            // Определение пути к файлу, в который будут сохранены данные
            string filePath = $@"{Directory.GetCurrentDirectory()}\Basket.csv";

            // Используйте try-catch для обработки исключений при записи в файл
            try
            {
                if (dataGridViewBsket_SEA.Rows.Count > 0)
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Запись заголовков 
                        for (int i = 0; i < dataGridViewBsket_SEA.Columns.Count; i++)
                        {
                            writer.Write(dataGridViewBsket_SEA.Columns[i].HeaderText);
                            if (i < dataGridViewBsket_SEA.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Запись данных
                        foreach (DataGridViewRow row in dataGridViewBsket_SEA.Rows)
                        {
                            for (int i = 0; i < dataGridViewBsket_SEA.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < dataGridViewBsket_SEA.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormOrder newForm = new FormOrder();
            newForm.Show();
            this.Hide();
        }





        private void buttonChange_SEA_Click(object sender, EventArgs e)
        {

            if (dataGridViewBsket_SEA.Rows.Count > 0)
            {
                // Проверка корректности
                if (int.TryParse(textBoxNumber_SEA.Text, out int rowIndex) && rowIndex > 0 && rowIndex <= dataGridViewBsket_SEA.Rows.Count)
                {
                    // Проверка корректности
                    if (double.TryParse(textBoxQuantity_SEA.Text, out double newQuantity))
                    {
                        int columnIndex = 2;

                        dataGridViewBsket_SEA.Rows[rowIndex - 1].Cells[columnIndex].Value = newQuantity;

                        textBoxNumber_SEA.Text = "";
                        textBoxQuantity_SEA.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение в ячейке количество.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректное значение в ячейке номер товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Нет данных для изменения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            
            
        }
       

    }
}

