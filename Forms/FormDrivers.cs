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
using System.Data.Odbc;


namespace Demo
{
    public partial class FormDrivers : Form
    {
        public FormDrivers()
        {
            InitializeComponent();
        }

        private void driversBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driversBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demoEgDataSet);

        }

        private void FormDrivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEgDataSet.Drivers". При необходимости она может быть перемещена или удалена.
            this.driversTableAdapter.Fill(this.demoEgDataSet.Drivers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu f3 = new FormMenu();
            f3.Show();

            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            driversDataGridView.Rows.RemoveAt(driversDataGridView.CurrentCell.RowIndex); // удаление записи
            MessageBox.Show("Запись удалена из базы данных");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.coefficientBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.Automation_of_payroll_calculationsDataSet);
            driversTableAdapter.Update(demoEgDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");


        }
    }
}
