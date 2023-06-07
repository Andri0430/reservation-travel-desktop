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
using BISMILLAH.Koneksi;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH
{
    public partial class MenuTransaksi : Form
    {
        TransaksiController transaksi = new TransaksiController();
        public MenuTransaksi()
        {
            InitializeComponent();
        }

        private void MenuTransaksi_Load(object sender, EventArgs e)
        {
            reloadTable();
            transaksi.pendapatan1();
            transaksi.jummlahTiketBus();
            transaksi.jummlahTiketKereta();
            transaksi.jummlahTiketPesawat();
            transaksi.jummlahTiketEksekutif();
            transaksi.jummlahTiketBusines();
            transaksi.jummlahTiketReguler();
            label26.Text = DataTransaksi.jumlahTiketBus;
            label27.Text = DataTransaksi.jumlahTiketKereta;
            label28.Text = DataTransaksi.jumlahTiketPesawat;
            label29.Text = DataTransaksi.jumlahTiketEksekutif;
            label30.Text = DataTransaksi.jumlahTiketBusines;
            label31.Text = DataTransaksi.jumlahTiketReguler;

            label1.Text = DataAdmin.namaAdmin;
            label23.Text = DataTransaksi.totalPembeli;
            label24.Text = DataTransaksi.jumlahTiketTerjual;
            label25.Text = DataTransaksi.totalPendapatan;
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label10.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel6.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.ForeColor = ColorTranslator.FromHtml("#004369");
            label12.ForeColor = ColorTranslator.FromHtml("#004369");
            label13.ForeColor = ColorTranslator.FromHtml("#004369");
            label14.ForeColor = ColorTranslator.FromHtml("#004369");
            label15.ForeColor = ColorTranslator.FromHtml("#004369");
            label16.ForeColor = ColorTranslator.FromHtml("#004369");
            label35.ForeColor = ColorTranslator.FromHtml("#004369");
            label36.ForeColor = ColorTranslator.FromHtml("#004369");
            label37.ForeColor = ColorTranslator.FromHtml("#004369");
            label23.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label24.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label25.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label26.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label27.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label28.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label29.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label30.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label31.ForeColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            DataPembeli.fiturPembelian = "hapus_";
            NextPembelian buy = new NextPembelian();
            this.Hide();
            buy.Show();
            buy.label12.Text = "Data Return";
            buy.button1.Text = "Pulihkan";
            buy.label19.Text = "Lanjut Memulihkan Data?";
            buy.button2.Hide();
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            DataPembeli.fiturPembelian = "";
            NextPembelian buy = new NextPembelian();
            this.Hide();
            buy.Show();
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MenuPembelian buy = new MenuPembelian();
            this.Hide();
            buy.Show();
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
            MenuTiket tik = new MenuTiket();
            this.Hide();
            tik.Show();
        }
        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        public void reloadTable()
        {
            dataGridView1.DataSource = transaksi.tabelTransaksi();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel10_Click_1(object sender, EventArgs e)
        {
            MenuBookingHotel m = new MenuBookingHotel();
            this.Hide();
            m.Show();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuControllAdmin a = new MenuControllAdmin();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap btm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(btm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(btm, 170, 120);
            e.Graphics.DrawString(label10.Text, new Font("Consolas", 50, FontStyle.Bold), Brushes.Black, new Point(250, 50));
        }
    }
}
