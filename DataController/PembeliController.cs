using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using System.Data;
using BISMILLAH.Data_Tampungan;

namespace BISMILLAH.DataController
{
    class PembeliController : Koneksi.Koneksi
    {
        DataTable data = new DataTable();
        public DataTable tabelPembeli(string fitur)
        {
            try
            {
                string view = "select * from "+fitur+"pembeli";
                da = new MySqlDataAdapter(view, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public void insertPembeli(string nama, string nohp, string jk,string usia)
        {
            string tambah = "insert into pembeli values (" + "@id_pembeli,@nama_pembeli,@no_hp,@jenis_kelamin,@usia)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pembeli", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = nama.ToUpper();
                cmd.Parameters.Add("@no_hp", MySqlDbType.VarChar).Value = nohp.ToUpper();
                cmd.Parameters.Add("@jenis_kelamin", MySqlDbType.VarChar).Value = jk.ToUpper();
                cmd.Parameters.Add("@usia", MySqlDbType.VarChar).Value = usia.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }
        public DataTable searchPembeli(string pembeli)
        {
            string search = "select * from "+DataPembeli.fiturPembelian+"pembeli where nama_pembeli like '%"+pembeli+"%'";
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
        public int cekPembeli(string nohp)
        {
            int a = 0;
            string cekPembeli = "select id_pembeli from pembeli where no_hp = '" + nohp + "';";
            cmd = new MySqlCommand(cekPembeli, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                DataPembeli.getIdPembeli = dr[0].ToString();
                a = 1;
            }
            return a;
        }

        public void insertDetailTransaksi(string id_pembeli, string nama,string tanggal,string tipe_class,string jumlah,string total_biaya)
        {
            string tambah = "insert into detail_transaksi values (" + "@id_pembeli,@nama_pembeli,@tanggal_beli,@barang,@tipe_class,@jumlah,@total_biaya)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pembeli", MySqlDbType.VarChar).Value = id_pembeli.ToUpper();
                cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = nama.ToUpper();
                cmd.Parameters.Add("@tanggal_beli", MySqlDbType.VarChar).Value = tanggal.ToUpper();
                cmd.Parameters.Add("@barang", MySqlDbType.VarChar).Value = "Booking Hotel".ToUpper();
                cmd.Parameters.Add("@tipe_class", MySqlDbType.VarChar).Value = tipe_class.ToUpper();
                cmd.Parameters.Add("@jumlah", MySqlDbType.VarChar).Value = jumlah.ToUpper();
                cmd.Parameters.Add("@total_biaya", MySqlDbType.VarChar).Value = total_biaya.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void insertDetailTransaksiTiket(string id_pembeli, string nama, string tipe_class, string jumlah, string total_biaya)
        {
            string tambah = "insert into detail_transaksi values (" + "@id_pembeli,@nama_pembeli,@tanggal_beli,@barang,@tipe_class,@jumlah,@total_biaya)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_pembeli", MySqlDbType.VarChar).Value = id_pembeli.ToUpper();
                cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = nama.ToUpper();
                cmd.Parameters.Add("@tanggal_beli", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@barang", MySqlDbType.VarChar).Value = ("Tiket "+DataTiket.jenisTiket).ToUpper();
                cmd.Parameters.Add("@tipe_class", MySqlDbType.VarChar).Value = tipe_class.ToUpper();
                cmd.Parameters.Add("@jumlah", MySqlDbType.VarChar).Value = jumlah.ToUpper();
                cmd.Parameters.Add("@total_biaya", MySqlDbType.VarChar).Value = total_biaya.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public int hapusPembeli(string fitur, string id_pembeli)
        {
            int cek = 0;
            string delete = "delete from "+fitur+"pembeli where id_pembeli=@id_pembeli";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_pembeli", MySqlConnector.MySqlDbType.VarChar).Value = id_pembeli;
                cmd.ExecuteNonQuery();
                cek = 1;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Hapus data gagal", exx.Message);
            }
            return cek;
        }

        public void updatePembeli(string id_pembeli, string nama_pembeli, string no_hp, string jk , string usia)
        {
            string update1 = "update pembeli set nama_pembeli=@nama_pembeli,no_hp=@no_hp, jenis_kelamin =@jenis_kelamin,usia=@usia where id_pembeli=" + id_pembeli;
            try
            {
                cmd = new MySqlCommand(update1, GetConn());
                cmd.Parameters.Add("@id_pembeli", MySqlDbType.VarChar).Value = id_pembeli.ToUpper();
                cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = nama_pembeli.ToUpper();
                cmd.Parameters.Add("@no_hp", MySqlDbType.VarChar).Value = no_hp.ToUpper();
                cmd.Parameters.Add("@jenis_kelamin", MySqlDbType.VarChar).Value = jk.ToUpper();
                cmd.Parameters.Add("@usia", MySqlDbType.VarChar).Value = usia.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal " + ex.Message);
            }
        }

        public void updatePembeliDetail(string id_pembeli, string nama_pembeli)
        {
            string update1 = "update detail_transaksi set nama_pembeli=@nama_pembeli where id_pembeli = '"+id_pembeli+"';";
            try
            {
                cmd = new MySqlCommand(update1, GetConn());
                cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = nama_pembeli.ToUpper();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal " + ex.Message);
            }
        }
    }
}
