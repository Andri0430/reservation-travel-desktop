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
    public partial class MenuPembelian : Form
    {
        public MenuPembelian()
        {
            InitializeComponent();
        }

        private void MenuPembelian_Load(object sender, EventArgs e)
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
            label11.ForeColor = ColorTranslator.FromHtml("#004369");
            label12.ForeColor = ColorTranslator.FromHtml("#004369");
            panel5.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.ForeColor = ColorTranslator.FromHtml("#DB1F48");

        }
        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label12.ForeColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#175873");
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
            NextPembelian buy = new NextPembelian();
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

        private void panel12_Click(object sender, EventArgs e)
        {
            MenuBookingHotel hotel = new MenuBookingHotel();
            this.Hide();
            hotel.Show();
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

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuControllAdmin adm = new MenuControllAdmin();
            this.Hide();
            adm.Show();
        }
    }
}
