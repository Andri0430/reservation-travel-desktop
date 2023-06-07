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
    public partial class MenuControllAdmin : Form
    {
        public MenuControllAdmin()
        {
            InitializeComponent();
        }

        private void MenuControllAdmin_Load(object sender, EventArgs e)
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
            panel8.BackColor = ColorTranslator.FromHtml("#DB1F48");
            label11.ForeColor = ColorTranslator.FromHtml("#004369");
            label13.ForeColor = ColorTranslator.FromHtml("#004369");
            label14.ForeColor = ColorTranslator.FromHtml("#004369");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }
        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#DB1F48");
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = ColorTranslator.FromHtml("#175873");
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

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAdmin.jenisControlKendaraan = "hotel";
        }

        private void panel12_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAdmin.jenisControlKendaraan = "admin";
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            ControlAdmin.jenisControlKendaraan = "travel";
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MenuPembelian buy = new MenuPembelian();
            this.Hide();
            buy.Show();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            MenuBookingHotel m = new MenuBookingHotel();
            this.Hide();
            m.Show();
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

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuTiket tiket = new MenuTiket();
            this.Hide();
            tiket.Show();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#175873");
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#2B7C85");
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ControlNextTravel nextControll = new ControlNextTravel();
            this.Hide();
            nextControll.Show();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            ControlNextHotel chotel = new ControlNextHotel();
            this.Hide();
            chotel.Show();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            ControlNextAdmin adm = new ControlNextAdmin();
            this.Hide();
            adm.Show();
        }
    }
}
