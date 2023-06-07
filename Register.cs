using BISMILLAH.DataController;
using BISMILLAH.Validasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISMILLAH
{
    public partial class Register : Form
    {
        private AdminController AdminControll = new AdminController();
        public validasi_janc valid = new validasi_janc();

        string gender;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#004369");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            panel3.BackColor = ColorTranslator.FromHtml("#004369");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            label1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label2.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label3.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label4.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label6.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label7.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label8.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label9.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label10.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label11.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            label12.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox2.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox3.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox4.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox5.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox6.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            comboBox1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            radioButton1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            radioButton2.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            button1.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button2.BackColor = ColorTranslator.FromHtml("#E5DDC8");

            textBox1.MaxLength = 30;
            textBox2.MaxLength = 30;
            textBox3.MaxLength = 13;
            comboBox1.MaxLength = 2;
            textBox4.MaxLength = 8;
            textBox5.MaxLength = 10;
            textBox5.MaxLength = 10;

            label10.Hide();
            label9.Hide();
            label8.Hide();
            label11.Hide();
            panel3.Hide();
            textBox6.Hide();
            textBox5.Hide();
            textBox4.Hide();
            button2.Hide();

            panel4.Hide();
            panel5.Hide();
            button4.Hide();
            label13.Hide();
            button5.Hide();
            button6.Hide();

            panel5.BackColor = ColorTranslator.FromHtml("#004369");
            panel4.BackColor = ColorTranslator.FromHtml("#01949A");
            button4.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label13.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            button5.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button6.BackColor = ColorTranslator.FromHtml("#E5DDC8");


            for (int a=17; a<=99; a++)
            {
                comboBox1.Items.Add(a);
            }

            textBox1.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox2.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox3.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox4.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox5.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox6.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            comboBox1.ForeColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cek = 0;
            valid = new validasi_janc();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Data Harus Lengap!!!");
                textBox1.Focus();
                cek = 1;
            }
            if(textBox1.TextLength < 3)
            {
                MessageBox.Show("Nama Minimal 3 Digit!!!");
                textBox1.Text = "";
                textBox1.Focus();
                cek = 1;
            }
            if (textBox1.TextLength >= 3)
            {
                if (valid.valString(textBox1.Text) == 1)
                {
                    MessageBox.Show("Nama Tidak Sesuai");
                    textBox1.Text = "";
                    textBox1.Focus();
                    cek = 1;
                }
            }
            if (textBox2.TextLength < 3)
            {
                MessageBox.Show("Nama Kota Minimal 3 Digit!!!");
                textBox2.Text = "";
                textBox2.Focus();
                cek = 1;
            }
            if (textBox2.TextLength >= 3)
            {
                if (valid.valString(textBox2.Text) == 1)
                {
                    MessageBox.Show("Kota Tidak Sesuai");
                    textBox2.Text = "";
                    textBox2.Focus();
                    cek = 1;
                }
            }
            if(textBox3.TextLength < 12)
            {
                MessageBox.Show("Nomor Telepon Tidak Sesuai");
                textBox3.Text = "";
                textBox3.Focus();
                cek = 1;
            }
            if(textBox3.TextLength >= 12)
            {
                if(valid.valNotelp(textBox3.Text)== 1)
                {
                    MessageBox.Show("Nomor Telepon Tidak Sesuai");
                    textBox3.Text = "";
                    textBox3.Focus();
                    cek = 1;
                }
            }
            if(comboBox1.Text.Length < 2)
            {
                MessageBox.Show("Umur Tidak Sesuai");
                comboBox1.Text = "";
                comboBox1.Focus();
            }
            else if(cek != 1)
            {
                if (AdminControll.cek_data_admin(textBox1.Text , textBox3.Text) == 1)
                {
                    MessageBox.Show("Akun Sudah Pernah Terdaftar");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    tabel_login();
                }
            }
        }

        public void tabel_login()
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            label10.Show();
            label9.Show();
            label8.Show();
            label11.Show();
            panel3.Show();
            textBox6.Show();
            textBox5.Show();
            textBox4.Show();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cek2 = 0;
            if(textBox4.Text == "" || textBox5.Text =="" || textBox6.Text == "")
            {
                MessageBox.Show("Data Harus Lengkap!!!");
                cek2 = 1;
            }
            if(textBox4.TextLength < 3)
            {
                MessageBox.Show("Username Minimal 3 Digit");
                textBox4.Text = "";
                textBox4.Focus();
                cek2 = 1;
            }
            if(textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Password Tidak Sesuai!!!");
                textBox5.Text = "";
                textBox6.Text = "";
                textBox5.Focus();
                cek2 = 1;
            }
            if(textBox5.TextLength < 8 || textBox6.TextLength < 8)
            {
                MessageBox.Show("Password Minimal 8 Digit");
                textBox5.Text = "";
                textBox6.Text = "";
                textBox5.Focus();
                cek2 = 1;
            }
            if(cek2 != 1)
            {
                if(AdminControll.cek_akun_admin(textBox4.Text) == 1)
                {
                    MessageBox.Show("Username Telah Terdaftar");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else
                {
                    panel4.Show();
                    panel5.Show();
                    button4.Show();
                    label13.Show();
                    button5.Show();
                    button6.Show();
                }
            }
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button5.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button6.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button6.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            button4.Hide();
            label13.Hide();
            button5.Hide();
            button6.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            frm1.Show(); 
            this.Hide();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                gender = "pria";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                gender = "wanita";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminControll.insert_akun_admin(textBox4.Text,textBox5.Text);
            AdminControll.insert_data_admin(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, gender , textBox4.Text , textBox5.Text);
            gender = "";
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }
    }
}
