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
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        int a = 0, b = 30, s = 0, d = 5;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "muxtar" && textBox2.Text == "1234")

            {
                FormMenu f2 = new FormMenu();
                f2.Show();

                this.Hide();

            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Неправильный логин или пароль");

                a++;
                if (a == 3)
                {
                    a = 0;
                    timer1.Enabled = true;
                    button1.Enabled = false;
                    label4.Visible = true;
                    button2.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                }
            

                }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label4.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    label4.Visible = false;
                    button2.Enabled = true;
                    label4.Text = "";
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                }
            }
            s++;
        }
    }
}


      

