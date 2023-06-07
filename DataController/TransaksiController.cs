using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BISMILLAH.Koneksi;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;
using BISMILLAH.Data_Tampungan;
namespace BISMILLAH.DataController 
{

    public class TransaksiController : Koneksi.Koneksi
    {
        DataTable data = new DataTable();
        public DataTable tabelTransaksi()
        {
            try
            {
                string view = "select * from detail_transaksi";
                da = new MySqlDataAdapter(view, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void pendapatan1()
        {
            try{
                string pendapatan1 = "SELECT COUNT(id_pembeli)AS total_pembeli,SUM(jumlah) AS jumlah_tiket_terjual,SUM(total_biaya)AS total_pendapatan FROM detail_transaksi;";
                cmd = new MySqlCommand(pendapatan1, GetConn());
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataTransaksi.totalPembeli = dr[0].ToString();
                    DataTransaksi.jumlahTiketTerjual = dr[1].ToString();
                    DataTransaksi.totalPendapatan = dr[2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void jummlahTiketBus()
        { 
            string tiketBus = "SELECT SUM(jumlah) AS jumlah_tiket_bus FROM detail_transaksi WHERE barang = 'Tiket bus';";
            cmd = new MySqlCommand(tiketBus, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketBus = dr[0].ToString();
            }
        }
        public void jummlahTiketKereta()
        {
            string tiketKereta = "SELECT SUM(jumlah) AS jumlah_tiket_kereta FROM detail_transaksi WHERE barang = 'Tiket kereta';";
            cmd = new MySqlCommand(tiketKereta, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketKereta = dr[0].ToString();
            }
        }
        public void jummlahTiketPesawat()
        {
            string tiketPesawat = "SELECT SUM(jumlah) AS jumlah_tiket_pesawat FROM detail_transaksi WHERE barang = 'Tiket pesawat';";
            cmd = new MySqlCommand(tiketPesawat, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketPesawat = dr[0].ToString();
            }
        }

        public void jummlahTiketEksekutif()
        {
            string tiketEksekutif = "SELECT SUM(jumlah) AS jumlah_tiket_eksekutif FROM detail_transaksi WHERE tipe_class = 'Eksekutif';";
            cmd = new MySqlCommand(tiketEksekutif, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketEksekutif = dr[0].ToString();
            }
        }
        public void jummlahTiketBusines()
        {
            string tiketBusines = "SELECT SUM(jumlah) AS jumlah_tiket_busines FROM detail_transaksi WHERE tipe_class = 'Busines';";
            cmd = new MySqlCommand(tiketBusines, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketBusines = dr[0].ToString();
            }
        }
        public void jummlahTiketReguler()
        {
            string tiketReguler = "SELECT SUM(jumlah) AS jumlah_tiket_reguler FROM detail_transaksi WHERE tipe_class = 'Reguler';";
            cmd = new MySqlCommand(tiketReguler, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DataTransaksi.jumlahTiketReguler = dr[0].ToString();
            }
        }
    }
}
