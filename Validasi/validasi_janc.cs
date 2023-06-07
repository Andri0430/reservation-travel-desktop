using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using BISMILLAH.DataController;
using BISMILLAH.Data_Tampungan;
namespace BISMILLAH.Validasi
{
    public class validasi_janc
    {

        string koneksi = "server=localhost;user=root;database=indo_travel";
        public MySqlConnection kon;
        public MySqlDataReader dr;
        public MySqlCommand cmd;

        public int valString(string x)
        {
            int cek = 0;

            for(int a = 0; a<x.Length; a++)
            {
                if(!(x[a]>= 'a' && x[a] <= 'z' || x[a]>='A' && x[a]<='Z' || x[a] == ' '))
                {
                    cek = 1;
                }
                else if(x[0] == ' ' || x[x.Length-1]==' ')
                {
                    cek = 1;
                }
                else if(x[a] == ' ' && x[a+1] == ' ')
                {
                    cek = 1;
                }
            }
            return cek;
        }

        public int valNotelp(string z)
        {
            int cek2 = 0;
            if(z[0] != '0' || z[1] != '8' || z[2] == '0' || z[2] =='4' || z[2] == '6')
            {
                cek2 = 1;
            }

            return cek2;
        }

        public int valHarga(string x)
        {
            int xx = 0;
            for(int a=0; a<x.Length; a++)
            {
                if(x[0] == '0')
                {
                    xx = 1;
                }
                if(!(x[a] >= '0' && x[a] <= '9'))
                {
                    xx = 1;
                }
            }

            return xx;
        }

        public int validasiStok(string stok)
        {
            int cek = 0;

            kon = new MySqlConnection(koneksi);
            kon.Open();
            cmd = new MySqlCommand("select * from tiket_"+DataTiket.jenisTiket+" where tujuan = '"+DataTiket.getData+"'", kon);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(Convert.ToInt32(dr[5].ToString()) < Convert.ToInt32(stok))
                {
                    cek = 1;
                }
            }
            return cek;
        }

        public int validasijumlahKamar(string stok)
        {
            int cek = 0;

            kon = new MySqlConnection(koneksi);
            kon.Open();
            cmd = new MySqlCommand("select * from booking_hotel where id_hotel = '" +DataHotel.getIdHotel + "'", kon);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt32(dr[5].ToString()) < Convert.ToInt32(stok))
                {
                    cek = 1;
                }
            }
            return cek;
        }
    }
}
