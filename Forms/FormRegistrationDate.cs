using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FormRegistrationDate : Form
    {
        public FormRegistrationDate()
        {
            InitializeComponent();
        }

        private void registration_dateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registration_dateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demoEgDataSet);

        }

        private void FormRegistrationDate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEgDataSet.Registration_date". При необходимости она может быть перемещена или удалена.
            this.registration_dateTableAdapter.Fill(this.demoEgDataSet.Registration_date);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu f2 = new FormMenu();
            f2.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration_dateDataGridView.Rows.RemoveAt(registration_dateDataGridView.CurrentCell.RowIndex); // удаление записи
            MessageBox.Show("Запись удалена из базы данных");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.coefficientBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.Automation_of_payroll_calculationsDataSet);
            registration_dateTableAdapter.Update(demoEgDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");

        }
    }
}
