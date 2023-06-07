using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Windows.Forms;
using BISMILLAH.Koneksi;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH.DataController
{
    class HotelController : Koneksi.Koneksi 
    {
        DataTable data = new DataTable();
        public DataTable tampilHotel()
        {
            try
            {
                string view = $"select * from booking_hotel";
                da = new MySqlDataAdapter(view, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public DataTable searchHotel(string tujuan)
        {
            string search = "select * from booking_hotel where kota = '"+tujuan+"';";
            da = new MySqlDataAdapter(search, GetConn());
            da.Fill(data);
            return data;
        }

        public int updateKurangJumlahKamar(string stokKamar)
        {
            int x = 0;
            try
            {
                string update = "update booking_hotel set kamar_tersedia = kamar_tersedia -"+stokKamar+" where id_hotel =" + DataHotel.getIdHotel + ";";
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

        public DataTable tampilTipeClass()
        {
            try
            {
                string view = "select * from tipeClass";
                da = new MySqlDataAdapter(view, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
    }
}
