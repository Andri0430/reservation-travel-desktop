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

namespace BISMILLAH
{
    public partial class MenuBookingHotel : Form
    {
        string koneksi = "server=localhost;user=root;database=indo_travel";
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection kon;
        public MySqlDataReader dr;

        private HotelController hotel = new HotelController();
        public MenuBookingHotel()
        {
            InitializeComponent();
        }

        private void MenuBookingHotel_Load(object sender, EventArgs e)
        {
            label1.Text = DataAdmin.namaAdmin;
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel14.BackColor = ColorTranslator.FromHtml("#DB1F48");
            dataGridView1.ForeColor = ColorTranslator.FromHtml("#175873");
            button1.BackColor = ColorTranslator.FromHtml("#175873");
            label10.ForeColor = ColorTranslator.FromHtml("#004369");
            comboBox1.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            listKota();
            reloadTable();
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
            dataGridView1.DataSource = hotel.tampilHotel();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHotel.getIdHotel = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DataHotel.getNamaHotel = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DataHotel.getKota = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DataHotel.getHargaHotel = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

            NextBookingHotel booking = new NextBookingHotel();
            this.Hide();
            booking.Show();

            booking.textBox7.Text = DataHotel.getNamaHotel;
            booking.textBox3.Text = DataHotel.getKota;
            booking.textBox4.Text = DataHotel.getHargaHotel;
        }
        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBookingHotel hotel = new MenuBookingHotel();
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

        private void listKota()
        {
            try
            {
                kon = new MySqlConnection(koneksi);
                kon.Open();
                cmd = new MySqlCommand("select *  from daerah_hotel", kon);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HotelController hotel = new HotelController();
            dataGridView1.DataSource = hotel.searchHotel(comboBox1.Text);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuTransaksi transaksi = new MenuTransaksi();
            transaksi.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuControllAdmin adm = new MenuControllAdmin();
            adm.Show();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            MenuPembelian beli = new MenuPembelian();
            beli.Show();
        }
    }
} 