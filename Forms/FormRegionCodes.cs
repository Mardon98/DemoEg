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
    public partial class FormRegionCodes : Form
    {
        public FormRegionCodes()
        {
            InitializeComponent();
        }

        private void region_CodesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.region_CodesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.demoEgDataSet);

        }

        private void FormRegionCodes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoEgDataSet.Region_Codes". При необходимости она может быть перемещена или удалена.
            this.region_CodesTableAdapter.Fill(this.demoEgDataSet.Region_Codes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu f2 = new FormMenu();
            f2.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.coefficientBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.Automation_of_payroll_calculationsDataSet);
            region_CodesTableAdapter.Update(demoEgDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            region_CodesDataGridView.Rows.RemoveAt(region_CodesDataGridView.CurrentCell.RowIndex); // удаление записи
            MessageBox.Show("Запись удалена из базы данных");

        }
    }
}
