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
using BISMILLAH.Koneksi;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH
{
    public partial class NextTiket : Form
    {

        private TiketController Tiket = new TiketController();
        public NextTiket()
        {
            InitializeComponent();
        }

        private void Next_Tiket(object sender, EventArgs e)
        { 

            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label10.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel4.BackColor = ColorTranslator.FromHtml("#DB1F48");
            textBox1.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            textBox1.BackColor = ColorTranslator.FromHtml("#DB1F48");
            panel10.BackColor = ColorTranslator.FromHtml("#DB1F48");
            dataGridView1.ForeColor = ColorTranslator.FromHtml("#175873");
            button1.BackColor = ColorTranslator.FromHtml("#175873");
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
            dataGridView1.DataSource = Tiket.tampilTiket(DataTiket.jenisTiket);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TiketController Tiket = new TiketController();
            dataGridView1.DataSource = Tiket.searchTiket(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTiket.getData = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            NextTiket2 buy = new NextTiket2();
            this.Hide();
            buy.Show();
            buy.label1.Text = label1.Text;
            buy.textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            buy.textBox4.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            buy.textBox6.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DataTiket.getIdTiket = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            MenuTiket tik = new MenuTiket();
            this.Hide();
            tik.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MenuPembelian beli = new MenuPembelian();
            this.Hide();
            beli.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            MenuBookingHotel hotel = new MenuBookingHotel();
            this.Hide();
            hotel.Show();
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTransaksi trans = new MenuTransaksi();
            this.Hide();
            trans.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuControllAdmin adm = new MenuControllAdmin();
            this.Hide();
            adm.Show();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }
    }
} 