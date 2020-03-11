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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDrivers f2 = new FormDrivers();
            f2.Show();


            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegionCodes f3 = new FormRegionCodes();
            f3.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistrationDate f4 = new FormRegistrationDate();
            f4.Show();

            this.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAutorization f1 = new FormAutorization();
            f1.Show();

            this.Hide();
        }
    }
}
