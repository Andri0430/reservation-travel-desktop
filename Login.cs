using BISMILLAH.DataController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH
{
    public partial class Login : Form
    {
        private AdminController AdminControll = new AdminController();

        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            label1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label2.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox2.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            label3.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label4.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#004369");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button2.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox1.MaxLength = 25;
            textBox2.MaxLength = 20;

            this.textBox1.AutoSize = false;
            this.textBox2.AutoSize = false;
            this.textBox1.Height = 30;
            this.textBox2.Height = 30;

            textBox1.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox2.ForeColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button1.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button2.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button2.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("DATA TIDAK BOLEH KOSONG!!!");
                textBox1.Focus();
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Username Tidak Di isi !");
                textBox1.Focus();
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Password Tidak Di isi !");
                textBox2.Focus();
            }
            if (AdminControll.login_admin(textBox1.Text, textBox2.Text) != 1)
            {
                MessageBox.Show("AKUN TIDAK TERDAFTAR");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            if(AdminControll.login_admin(textBox1.Text, textBox2.Text) == 1)
            {
               if(textBox1.Text == DataAdmin.username && textBox2.Text == DataAdmin.password)
                {
                    MessageBox.Show("LOGIN BERHASIL");
                    DataAdmin.namaAdmin = textBox1.Text;
                    this.Hide();
                    MenuBookingHotel h = new MenuBookingHotel();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("AKUN TIDAK DIKETAHUI");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regis = new Register();
            regis.Show();
        }
    }
}
