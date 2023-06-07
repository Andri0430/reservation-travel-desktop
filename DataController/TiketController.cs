using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH.DataController
{
    class TiketController : Koneksi.Koneksi
    {
        DataTable data = new DataTable();
        public DataTable tampilTiket(string tujuan)
        {
            try
            {
                string view = $"select * from tiket_" + tujuan + "";
                da = new MySqlDataAdapter(view, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchTiket(string tujuan)
        {
            string search = "select * from tiket_"+DataTiket.jenisTiket+" where tujuan like '%" + tujuan + "%'";
            try
            {
                da = new MySqlDataAdapter(search, GetConn());
                da.Fill(data);
            }
            catch (Exception exxx)
            {
                MessageBox.Show("Data Tidak Ada", exxx.Message);
            }
            return data;
        }
        public int updateKurangStokTiket(string id_tiket, string stok, string jenisTiket)
        {
            int x = 0;
            try
            {
                string update = "update tiket_" + jenisTiket + " set stok = stok -" + stok + " where id_" + jenisTiket + "=" + id_tiket + ";";
                cmd = new MySqlCommand(update, GetConn());
                cmd.ExecuteNonQuery();
                x = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pembelian Gagal " + ex.Message);
            }   
            return x;
        }
    }
}
