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
    public partial class FormCatalog : Form
    {
        public FormCatalog()
        {
            InitializeComponent();
        }

        private void buttonAdd1_SEA_Click(object sender, EventArgs e)
        {
            labelKol1_SEA.Text = (Convert.ToInt32(labelKol1_SEA.Text)+ 1).ToString();
        }

        private void buttonAdd2_SEA_Click(object sender, EventArgs e)
        {
            labelKol2_SEA.Text = (Convert.ToInt32(labelKol2_SEA.Text) + 1).ToString();
        }

        private void buttonAdd3_SEA_Click(object sender, EventArgs e)
        {
            labelKol3_SEA.Text = (Convert.ToInt32(labelKol3_SEA.Text) + 1).ToString();
        }

        private void buttonAdd4_SEA_Click(object sender, EventArgs e)
        {
            labelKol4_SEA.Text = (Convert.ToInt32(labelKol4_SEA.Text) + 1).ToString();
        }

        private void buttonAdd5_SEA_Click(object sender, EventArgs e)
        {
            labelKol5_SEA.Text = (Convert.ToInt32(labelKol5_SEA.Text) + 1).ToString();
        }

        private void buttonAdd6_SEA_Click(object sender, EventArgs e)
        {
            labelKol6_SEA.Text = (Convert.ToInt32(labelKol6_SEA.Text) + 1).ToString();
        }

        private void buttonAdd7_SEA_Click(object sender, EventArgs e)
        {
            labelKol7_SEA.Text = (Convert.ToInt32(labelKol7_SEA.Text) + 1).ToString();
        }

        private void buttonAdd8_SEA_Click(object sender, EventArgs e)
        {
            labelKol8_SEA.Text = (Convert.ToInt32(labelKol8_SEA.Text) + 1).ToString();
        }

        private void buttonAdd9_SEA_Click(object sender, EventArgs e)
        {
            labelKol9_SEA.Text = (Convert.ToInt32(labelKol9_SEA.Text) + 1).ToString();
        }

        private void buttonAdd10_SEA_Click(object sender, EventArgs e)
        {
            labelKol10_SEA.Text = (Convert.ToInt32(labelKol10_SEA.Text) + 1).ToString();
        }

        private void buttonBasket_SEA_Click(object sender, EventArgs e)
        {
            // Определение пути к файлу CSV
            string filePath = $@"{Directory.GetCurrentDirectory()}\Basket.csv";

            // Используйте try-catch для обработки исключений при записи в файл
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine("Название,Цена,Количество,Итог");

                    // Запись данных из ячеек в CSV
                    for (int i = 1; i <= 10; i++)
                    {
                        string name = Controls.Find($"labelName{i}_SEA", true)[0].Text;
                        string price = Controls.Find($"labelPrice{i}_SEA", true)[0].Text;
                        string quantity = Controls.Find($"labelKol{i}_SEA", true)[0].Text;

                        if (Convert.ToInt32(quantity) == 0)
                            continue;

                        // Вычисление итога
                        decimal totalPrice = Convert.ToDecimal(price) * Convert.ToInt32(quantity);

                        writer.WriteLine($"{name},{price},{quantity},{totalPrice}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            FormBasket newForm = new FormBasket();

            // Показываем новую форму
            newForm.Show();

            // Скрываем текущую форму
            this.Hide();
        }

        private void buttonClose_SEA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_SEA_Click(object sender, EventArgs e)
        {
            FormMain newForm = new FormMain();
            newForm.Show();
            this.Hide();
        }




        private void buttonMinus1_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol1_SEA.Text)>0)
            {  labelKol1_SEA.Text = (Convert.ToInt32(labelKol1_SEA.Text) - 1).ToString();  }
        }

        private void buttonMinus2_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol2_SEA.Text) > 0)
            { labelKol2_SEA.Text = (Convert.ToInt32(labelKol2_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus3_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol3_SEA.Text) > 0)
            { labelKol3_SEA.Text = (Convert.ToInt32(labelKol3_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus4_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol4_SEA.Text) > 0)
            { labelKol4_SEA.Text = (Convert.ToInt32(labelKol4_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus5_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol5_SEA.Text) > 0)
            { labelKol5_SEA.Text = (Convert.ToInt32(labelKol5_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus6_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol6_SEA.Text) > 0)
            { labelKol6_SEA.Text = (Convert.ToInt32(labelKol6_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus7_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol7_SEA.Text) > 0)
            { labelKol7_SEA.Text = (Convert.ToInt32(labelKol7_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus8_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol8_SEA.Text) > 0)
            { labelKol8_SEA.Text = (Convert.ToInt32(labelKol8_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus9_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol9_SEA.Text) > 0)
            { labelKol9_SEA.Text = (Convert.ToInt32(labelKol9_SEA.Text) - 1).ToString(); }
        }

        private void buttonMinus10_SEA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelKol10_SEA.Text) > 0)
            { labelKol10_SEA.Text = (Convert.ToInt32(labelKol10_SEA.Text) - 1).ToString(); }
        }
    }
}
