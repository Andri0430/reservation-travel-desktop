using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using BISMILLAH.DataController;
using BISMILLAH.Validasi;
using BISMILLAH.Data_Tampungan;
namespace BISMILLAH
{
    public partial class NextBookingHotel: Form
    {
        public string gender;
        string koneksi = "server=localhost;user=root;database=indo_travel";
        public MySqlConnection kon;
        public MySqlDataReader dr;
        public MySqlCommand cmd;


        private validasi_janc validasi = new validasi_janc();
        public NextBookingHotel()
        {
            InitializeComponent();
        }

        public void reloadTable()
        {
            HotelController hotel = new HotelController();
            dataGridView1.DataSource = hotel.tampilTipeClass();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NextBookingHotel_Load(object sender, EventArgs e)
        {
            label1.Text = DataAdmin.namaAdmin;
            reloadTable();
            panel13.Hide();
            panel11.Hide();
            comboBox1.SelectedText = "Reguler";
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";

            textBox5.Text = "0";
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label10.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            label11.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel10.BackColor = ColorTranslator.FromHtml("#004369");
            panel11.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel15.BackColor = ColorTranslator.FromHtml("#DB1F48");
            panel12.BackColor = ColorTranslator.FromHtml("#004369");
            panel13.BackColor = ColorTranslator.FromHtml("#2B7C85");
            button7.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            label12.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label21.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label14.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label18.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label16.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label13.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label15.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label17.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            comboBox1.Items.Add("Eksekutif");
            comboBox1.Items.Add("Busines");
            comboBox1.Items.Add("Reguler");

            for(int a = 1; a<=30; a++)
            {
                comboBox2.Items.Add(a);
            }

            for (int a = 17; a <= 99; a++)
            {
                comboBox3.Items.Add(a);
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

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#175873");

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = ColorTranslator.FromHtml("#2B7C85");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data;
            kon = new MySqlConnection(koneksi);
            kon.Open();
            cmd = new MySqlCommand("select * from booking_hotel where id_hotel ='" +DataHotel.getIdHotel+"'", kon);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                data = dr[4].ToString();
                if (comboBox1.Text == "Eksekutif")
                {
                    textBox4.Text = ((Convert.ToInt32(data) * 0.3) + Convert.ToInt32(data)).ToString();
                }
                if (comboBox1.Text == "Reguler")
                {
                    textBox4.Text = data;
                }
                if(comboBox1.Text == "Busines")
                {
                    textBox4.Text = ((Convert.ToInt32(data) * 0.2) + Convert.ToInt32(data)).ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToDouble(textBox4.Text) * Convert.ToDouble(comboBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            if(textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Data Tidak Lengkap!!!");
                x = 1;
            }
            if(textBox1.Text == "")
            {
                MessageBox.Show("Nama Tidak Boleh Kosong");
                textBox1.Focus();
                x = 1;
            }
            if(textBox1.Text != "")
            {
                if(textBox1.Text.Length < 3)
                {
                    MessageBox.Show("Nama Minimal Harus 3 Digit");
                    textBox1.Text = "";
                    textBox1.Focus();
                    x = 1;
                }
                if(validasi.valString(textBox1.Text)== 1)
                {
                    MessageBox.Show("Nama Tidak Sesuai!");
                    textBox1.Text = "";
                    textBox1.Focus();
                    x = 1;
                }
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Nomor HP Tidak Boleh Kosong");
                textBox2.Focus();
                x = 1;
            }
            if (textBox2.Text.Length < 12)
            {
                MessageBox.Show("Nomor HP MinimaL 12 Digit");
                textBox2.Text = "";
                textBox2.Focus();
                x = 1;
            }
            if(textBox2.Text.Length >= 12)
            {
                if (validasi.valNotelp(textBox2.Text) == 1)
                {
                    MessageBox.Show("Nomor HP Tidak Sesuai!");
                    textBox2.Text = "";
                    textBox2.Focus();
                    x = 1;
                }
            }
            if(comboBox3.Text == "")
            {
                MessageBox.Show("Masukan Usia");
                comboBox3.Focus();
                x = 1;
            }
            if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Pilih Jenis Kelamin");
                x = 1;
            }
            if(comboBox2.Text == "")
            {
                MessageBox.Show("Masukan Jumlah Kamar");
                comboBox2.Focus();
                x = 1;
            }
            if (validasi.validasijumlahKamar(comboBox2.Text) == 1)
            {
                MessageBox.Show("Kamar Tidak Tersedia");
                comboBox2.Focus();
                x = 1;
            }
            if (x != 1)
            {
                panel11.Show();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTiket tik = new MenuTiket();
            tik.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel11.Hide();
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

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#2B7C85");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HotelController hotel = new HotelController();
            if(hotel.updateKurangJumlahKamar(comboBox2.Text) == 1)
            {
                PembeliController Pembeli = new PembeliController();
                PembeliController Buy = new PembeliController();
                if(Pembeli.cekPembeli(textBox2.Text) == 1)
                {
                    Buy.insertDetailTransaksi(DataPembeli.getIdPembeli, textBox1.Text,dateTimePicker1.Text, comboBox1.Text, comboBox2.Text, textBox5.Text);
                }
                else
                {
                    Pembeli.insertPembeli(textBox1.Text, textBox2.Text, gender, comboBox3.Text);
                    if (Pembeli.cekPembeli(textBox2.Text) == 1)
                    {
                        Buy.insertDetailTransaksi(DataPembeli.getIdPembeli, textBox1.Text,dateTimePicker1.Text, comboBox1.Text, comboBox2.Text, textBox5.Text);
                    }
                }
                panel11.Hide();
                panel13.Show();
            }
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = ColorTranslator.FromHtml("#DB1F48");
            button7.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            button7.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBookingHotel hotel = new MenuBookingHotel();
            hotel.Show();
        }

        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            NextTiket t2 = new NextTiket();
            this.Hide();
            t2.Show();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBookingHotel hotel = new MenuBookingHotel();
            hotel.Show();
        }

        private void panel15_Click(object sender, EventArgs e)
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

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTiket tiket = new MenuTiket();
            tiket.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPembelian beli = new MenuPembelian();
            beli.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuControllAdmin controlAdmin = new MenuControllAdmin();
            controlAdmin.Show();
        }
    }
}
