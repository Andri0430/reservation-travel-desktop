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
using BISMILLAH.Data_Tampungan;
using BISMILLAH.Validasi;

namespace BISMILLAH
{
    public partial class NextPembelian : Form
    {
        validasi_janc validasi = new validasi_janc();   
        private PembeliController Pembeli = new PembeliController();
        MenuPembelian dataPem = new MenuPembelian();
        public NextPembelian()
        {
            InitializeComponent();
        }

        private void NextPembelian_Load(object sender, EventArgs e)
        {
            reloadTable();

            textBox2.Enabled = false;
            panel13.Hide();
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            panel5.BackColor = ColorTranslator.FromHtml("#DB1F48");
            panel10.BackColor = ColorTranslator.FromHtml("#004369");
            label12.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            textBox1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox1.BackColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#DB1F48");
            panel12.BackColor = ColorTranslator.FromHtml("#004369");
            panel11.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel15.BackColor = ColorTranslator.FromHtml("#004369");
            panel13.BackColor = ColorTranslator.FromHtml("#2B7C85");

            label1.Text = DataAdmin.namaAdmin;
            panel11.Hide();

            comboBox1.Items.Add("Pria");
            comboBox1.Items.Add("Wanita");
            for (int a = 17; a <= 99; a++)
            {
                comboBox2.Items.Add(a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }
        public void reloadTable()
        {
            dataGridView1.DataSource = Pembeli.tabelPembeli(DataPembeli.fiturPembelian);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PembeliController pembeli = new PembeliController();
            dataGridView1.DataSource = pembeli.searchPembeli(textBox1.Text);
        }
        private void panel14_Click(object sender, EventArgs e)
        {
            MenuPembelian buyData = new MenuPembelian();
            this.Hide();
            buyData.Show();
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            MenuTiket tik = new MenuTiket();
            this.Hide();
            tik.Show();
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

        private void button1_Click(object sender, EventArgs e)
        { 
            panel11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPembelian DataBuy = new MenuPembelian();
            this.Hide();
            DataBuy.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PembeliController Pembeli = new PembeliController();
            if(Pembeli.hapusPembeli(DataPembeli.fiturPembelian, this.dataGridView1.CurrentRow.Cells[0].Value.ToString()) == 1)
            {
                panel11.Hide();
                this.Hide();
                MenuPembelian buyyer = new MenuPembelian();
                buyyer.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 0;
            if(textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Data Harus Lengkap!!!");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                textBox3.Focus();
                x = 1;
            }
            if (textBox3.Text != "")
            {
                if (textBox3.Text.Length < 3)
                {
                    MessageBox.Show("Nama Minimal Harus 3 Digit");
                    textBox3.Text = "";
                    textBox3.Focus();
                    x = 1;
                }
                if (validasi.valString(textBox3.Text) == 1)
                {
                    MessageBox.Show("Nama Tidak Sesuai!");
                    textBox3.Text = "";
                    textBox3.Focus();
                    x = 1;
                }
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Nomor HP Tidak Boleh Kosong");
                textBox4.Focus();
                x = 1;
            }
            if (textBox4.Text.Length < 12)
            {
                MessageBox.Show("Nomor HP MinimaL 12 Digit");
                textBox4.Text = "";
                textBox4.Focus();
                x = 1;
            }
            if (textBox4.Text.Length >= 12)
            {
                if (validasi.valNotelp(textBox4.Text) == 1)
                {
                    MessageBox.Show("Nomor HP Tidak Sesuai!");
                    textBox4.Text = "";
                    textBox4.Focus();
                    x = 1;
                }
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Masukan Usia");
                comboBox2.Focus();
                x = 1;
            }
            if (x != 1)
            {
                PembeliController Pembeli = new PembeliController();
                Pembeli.updatePembeli(textBox2.Text, textBox3.Text, textBox4.Text , comboBox1.Text , comboBox2.Text);
                Pembeli.updatePembeliDetail(textBox2.Text, textBox3.Text);
                panel13.Hide();
                NextPembelian p = new NextPembelian();
                this.Hide();
                p.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel13.Show();
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel13.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            //Menu Booking
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            panel16.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel16.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTransaksi transaksi = new MenuTransaksi();
            this.Hide();
            transaksi.Show();
        }

        private void panel6_MouseEnter_1(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel6_MouseLeave_1(object sender, EventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void panel16_MouseClick(object sender, MouseEventArgs e)
        {
            MenuBookingHotel hotel = new MenuBookingHotel();
            this.Hide();
            hotel.Show();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            MenuControllAdmin c = new MenuControllAdmin();
            this.Hide();
            c.Show();
        }

        private void panel8_MouseEnter_1(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel8_MouseLeave_1(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            MenuTiket tik = new MenuTiket();
            this.Hide();
            tik.Show();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            MenuPembelian p = new MenuPembelian();
            this.Hide();
            p.Show();
        }
    }
}
