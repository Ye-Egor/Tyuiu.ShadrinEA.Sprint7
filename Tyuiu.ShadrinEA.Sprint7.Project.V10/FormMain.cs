using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ShadrinEA.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonEnter_SEA_Click(object sender, EventArgs e)
        {
            FormCatalog newForm = new FormCatalog();
            newForm.Show();
            this.Hide();
        }
    }
}
