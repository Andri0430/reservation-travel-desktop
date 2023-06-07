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
    public partial class ControlNextHotel : Form
    {
        validasi_janc validasi = new validasi_janc();
        ControllAdmin controll = new ControllAdmin();

        string koneksi = "server=localhost;user=root;database=indo_travel";
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection kon;
        public MySqlDataReader dr;

        public ControlNextHotel()
        {
            InitializeComponent();
        }

        private void ControlNextHotel_Load(object sender, EventArgs e)
        {
            panel16.Hide();
            panel18.Hide();
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel8.BackColor = ColorTranslator.FromHtml("#DB1F48");
            dataGridView1.ForeColor = ColorTranslator.FromHtml("#175873");
            button1.BackColor = ColorTranslator.FromHtml("#175873");
            button2.BackColor = ColorTranslator.FromHtml("#175873");
            button4.BackColor = ColorTranslator.FromHtml("#175873");
            panel10.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel15.BackColor = ColorTranslator.FromHtml("#004369");
            panel11.BackColor = ColorTranslator.FromHtml("#175873");
            panel12.BackColor = ColorTranslator.FromHtml("#004369");
            panel16.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel19.BackColor = ColorTranslator.FromHtml("#004369");
            panel18.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel10.Hide();
            panel11.Hide();
            textBox1.Hide();
            button8.Hide();
            listKota();
            reloadTable();

            for(int a = 1; a<=100; a++)
            {
                comboBox3.Items.Add(a);
            }
        }

        private void listKota()
        {
            try
            {
                kon = new MySqlConnection(koneksi);
                kon.Open();
                cmd = new MySqlCommand("select * from daerah_hotel", kon);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#175873");
        }
        public void reloadTable()
        {
            HotelController hotel = new HotelController();
            dataGridView1.DataSource = hotel.tampilHotel();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }
        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            MenuControllAdmin control = new MenuControllAdmin();
            this.Hide();
            control.Show();
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
            label24.Text = "UPDATE";
            button6.Text = "UPDATE DATA";
            button6.Text = "UPDATE DATA";
            label21.Text = "Update Berhasil";

            textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox3.SelectedItem = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
            panel10.Hide();
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Data Tidak Boleh Kosong");
                textBox1.Focus();
            }
            if (textBox1.Text.Length < 2)
            {
                MessageBox.Show("Minimal 2 Karakter");
                textBox1.Focus();
            }
            else
            {
                if (validasi.valString(textBox1.Text) == 1)
                {
                    MessageBox.Show("Data Tidak Sesuai");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    textBox3.Focus();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Tambah Kota")
            {
                textBox1.Show();
                button8.Show();
                textBox1.Focus();
            }
            else
            {
                textBox1.Hide();
                button8.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControllAdmin cont = new ControllAdmin();
            int cek = 0, cek2 = 0;
            if(button6.Text == "INSERT DATA")
            {
                if (comboBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("Data Tidak Lengkap");
                    cek = 1;
                }
                if (textBox3.Text.Length < 3)
                {
                    MessageBox.Show("Nama Hotel Minimal 3 Karakter");
                    textBox3.Focus();
                    cek = 1;
                }
                else
                {
                    if (validasi.valString(textBox3.Text) == 1)
                    {
                        MessageBox.Show("Data Tidak Sesuai");
                        textBox3.Text = "";
                        textBox3.Focus();
                        cek = 1;
                    }
                    else
                    {
                        textBox5.Focus();
                    }
                }
                if (textBox5.Text.Length < 4)
                {
                    MessageBox.Show("Harga Minimal 4 Digit");
                    textBox5.Text = "";
                    textBox5.Focus();
                    cek = 1;
                }
                else
                {
                    if (validasi.valHarga(textBox5.Text) == 1)
                    {
                        MessageBox.Show("Data Tidak Sesuai");
                        textBox5.Text = "";
                        textBox5.Focus();
                        cek = 1;
                    }
                    else
                    {
                        comboBox3.Focus();
                    }
                }
                if (comboBox3.Text == "")
                {
                    MessageBox.Show("Masukan Jumlah Kamar");
                    cek = 1;
                }
                else if (cek != 1)
                {
                    if (comboBox2.Text == "Tambah Kota")
                    {
                        ControlAdmin.getNamaKota = textBox1.Text;
                        cont.insertKota(ControlAdmin.getNamaKota);
                        controll.insertHotel(textBox3.Text , ControlAdmin.getNamaKota , textBox5.Text , comboBox3.Text);
                    }
                    else
                    {
                        ControlAdmin.getNamaKota = comboBox2.Text;
                        controll.insertHotel(textBox3.Text, ControlAdmin.getNamaKota, textBox5.Text, comboBox3.Text);
                    }
                    panel11.Show();
                }
            }

            else if(button6.Text == "UPDATE DATA")
            {
                if (comboBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || comboBox3.Text == "")
                {
                    MessageBox.Show("Data Tidak Lengkap");
                    cek2 = 1;
                }
                if (textBox3.Text.Length < 3)
                {
                    MessageBox.Show("Nama Hotel Minimal 3 Karakter");
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
                if (textBox5.Text.Length < 4)
                {
                    MessageBox.Show("Minimal 4 Karakter");
                    textBox5.Focus();
                    cek2 = 1;
                }
                else
                {
                    if (validasi.valHarga(textBox5.Text) == 1)
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
                    MessageBox.Show("Masukan Stok Tiket");
                    cek2 = 1;
                }
                else if(cek2 != 1)
                {
                    if (comboBox2.Text == "Tambah Kota")
                    {
                        ControlAdmin.getNamaKota = textBox1.Text;
                        cont.insertKota(ControlAdmin.getNamaKota);
                        controll.UpdateHotel(textBox3.Text, textBox5.Text, comboBox3.Text, this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    }
                    else
                    {
                        ControlAdmin.getNamaKota = comboBox2.Text;
                        controll.UpdateHotel(textBox3.Text, textBox5.Text, comboBox3.Text, this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    }
                    panel11.Show();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuControllAdmin controlAdmin = new MenuControllAdmin();
            this.Hide();
            controlAdmin.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel10.Hide();
            panel18.Hide();
            panel11.Hide();
            reloadTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            panel18.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            controll.hapusHotel(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            panel18.Hide();
            reloadTable();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel18.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel18.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTransaksi transaksi = new MenuTransaksi();
            this.Hide();
            transaksi.Show();
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
} 