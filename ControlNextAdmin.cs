using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BISMILLAH.DataController;
using MySqlConnector;
using BISMILLAH.Data_Tampungan;
using BISMILLAH.Validasi;

namespace BISMILLAH
{
    public partial class ControlNextAdmin : Form
    {
        string gender;
        validasi_janc validasi = new validasi_janc();
        ControllAdmin controll = new ControllAdmin();
        AdminController adm = new AdminController();

        public ControlNextAdmin()
        {
            InitializeComponent();
        }

        private void ControlNextAdmin_Load(object sender, EventArgs e)
        {
            panel16.Hide();
            reloadTable();
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel8.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button2.BackColor = ColorTranslator.FromHtml("#175873");
            button4.BackColor = ColorTranslator.FromHtml("#175873");
            panel10.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel15.BackColor = ColorTranslator.FromHtml("#004369");
            panel17.BackColor = ColorTranslator.FromHtml("#004369");
            panel16.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel10.Hide();

            for (int a = 17; a <= 99; a++)
            {
                comboBox3.Items.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }
        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#175873");
        }
        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }
        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        public void reloadTable()
        {

            dataGridView1.DataSource = adm.tampilDataAkun();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MenuTiket tik = new MenuTiket();
            this.Hide();
            tik.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            MenuBookingHotel hotel = new MenuBookingHotel();
            this.Hide();
            hotel.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel10.Show();

            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox3.SelectedItem = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            panel10.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControllAdmin cont = new ControllAdmin();
            int cek2 = 0;

            if(button6.Text == "UPDATE DATA")
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox3.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false) 
                {
                    MessageBox.Show("Data Tidak Lengkap");
                    cek2 = 1;
                }
                if (textBox2.Text.Length < 3)
                {
                    MessageBox.Show("Nama Minimal 3 Karakter");
                    textBox2.Focus();
                    cek2 = 1;
                }
                else
                {
                    if (validasi.valString(textBox2.Text) == 1)
                    {
                        MessageBox.Show("Data Tidak Sesuai");
                        textBox2.Text = "";
                        textBox2.Focus();
                        cek2 = 1;
                    }
                    else
                    {
                        textBox3.Focus();
                    }
                }
                if (textBox3.Text.Length < 3)
                {
                    MessageBox.Show("Alamat Minimal 3 Karakter");
                    textBox3.Focus();
                    cek2 = 1;
                }
                else
                {
                    if (validasi.valString(textBox3.Text) == 1)
                    {
                        MessageBox.Show("Data Tidak Sesuai");
                        textBox3.Text = "";
                        textBox3.Focus();
                        cek2 = 1;
                    }
                    else
                    {
                        textBox5.Focus();
                    }
                }
                if (textBox5.Text.Length < 12)
                {
                    MessageBox.Show("Minimal 12 Karakter");
                    textBox5.Focus();
                    cek2 = 1;
                }
                else
                {
                    if (validasi.valNotelp(textBox5.Text) == 1)
                    {
                        MessageBox.Show("Data Tidak Sesuai");
                        textBox5.Text = "";
                        textBox5.Focus();
                        cek2 = 1;
                    }
                    else
                    {
                        textBox5.Focus();
                    }
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("Masukan Usia");
                    cek2 = 1;
                }
                else if(cek2 != 1)
                {
                    ControllAdmin adm = new ControllAdmin();
                    adm.updateDataAdmin(textBox2.Text, textBox3.Text, textBox5.Text, comboBox3.Text, gender,this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    panel10.Hide();
                    MenuControllAdmin m = new MenuControllAdmin();
                    this.Hide();
                    m.Show();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel10.Hide();
            reloadTable();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTransaksi transaksi = new MenuTransaksi();
            this.Hide();
            transaksi.Show();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            MenuControllAdmin control = new MenuControllAdmin();
            this.Hide();
            control.Show();
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gender = radioButton1.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel16.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuControllAdmin m = new MenuControllAdmin();
            this.Hide();
            m.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAPUS DATA BERHASIL");
            ControllAdmin adm = new ControllAdmin();
            adm.hapusDataAdmin(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            panel16.Hide();
            MenuControllAdmin a = new MenuControllAdmin();
            this.Hide();
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MenuControllAdmin c = new MenuControllAdmin();
            this.Hide();
            c.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel16.Hide();
        }

        private void ControlNextAdmin_Load_1(object sender, EventArgs e)
        {

        }
    }
} 