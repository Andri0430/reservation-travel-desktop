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
    public partial class MenuTiket : Form
    {
        public MenuTiket()
        {
            InitializeComponent();
        }

        private void Menu_Tiket(object sender, EventArgs e)
        {
            label1.Text = DataAdmin.namaAdmin;
            this.BackColor = ColorTranslator.FromHtml("#E5DDC8");
            panel2.BackColor = ColorTranslator.FromHtml("#004369");
            button3.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label5.ForeColor = ColorTranslator.FromHtml("#E5DDC8");
            panel1.BackColor = ColorTranslator.FromHtml("#2B7C85");
            panel3.BackColor = ColorTranslator.FromHtml("#175873");
            label9.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            label10.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel9.BackColor = ColorTranslator.FromHtml("#175873");
            panel10.BackColor = ColorTranslator.FromHtml("#175873");
            panel11.BackColor = ColorTranslator.FromHtml("#175873");
            panel12.BackColor = ColorTranslator.FromHtml("#175873");
            label11.ForeColor = ColorTranslator.FromHtml("#DB1F48");
            panel4.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.Show();
            label11.Text = "Bus";
        }
        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#175873");
            label11.Text = "";
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.Show();
            label11.Text = "Train";
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#175873");
            label11.Text = "";
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.Show();
            label11.Text = "Plane";
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#175873");
            label11.Text = "";
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

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            DataTiket.jenisTiket = "kereta";
            NextTiket t2 = new NextTiket();
            this.Hide();
            t2.Show();
            t2.label9.Text = "Train";
            t2.label1.Text = label1.Text;
        }

        private void panel12_MouseClick(object sender, MouseEventArgs e)
        {
            DataTiket.jenisTiket = "pesawat";
            NextTiket t2 = new NextTiket();
            this.Hide();
            t2.Show();
            t2.label9.Text = "Plane";
            t2.label1.Text = label1.Text;
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            DataTiket.jenisTiket = "bus";
            NextTiket t2 = new NextTiket();
            this.Hide();
            t2.Show();
            t2.label9.Text = "Bus";
            t2.label1.Text = label1.Text;
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

        private void panel14_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuBookingHotel hotel = new MenuBookingHotel();
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

        private void panel6_Click(object sender, EventArgs e)
        {
            MenuTransaksi transaksi = new MenuTransaksi();
            this.Hide();
            transaksi.Show();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login();
            this.Hide();
            frm1.Show();
        }

        private void panel6_Click_1(object sender, EventArgs e)
        {
            MenuTransaksi transaksi = new MenuTransaksi();
            this.Hide();
            transaksi.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuControllAdmin adm = new MenuControllAdmin();
            this.Hide();
            adm.Show();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void panel5_Click_1(object sender, EventArgs e)
        {
            MenuPembelian beli = new MenuPembelian();
            this.Hide();
            beli.Show();
        }
    }
}
