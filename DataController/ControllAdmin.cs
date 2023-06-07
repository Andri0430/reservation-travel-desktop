using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using BISMILLAH.Data_Tampungan;


namespace BISMILLAH.DataController
{
    public class ControllAdmin : Koneksi.Koneksi
    {
        public void insertTravel(string namaTravel)
        {
            string tambah = "insert into travel values (" + "@id_travel,@nama_travel)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_travel", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@nama_travel", MySqlDbType.VarChar).Value = namaTravel.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void insertKota(string namaKota)
        {
            string tambah = "insert into daerah_hotel values (@id_kota,@kota)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_kota", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@kota", MySqlDbType.VarChar).Value = namaKota.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void cekIdTravel (string namaTravel, string trans, string namaTransport, string tujuan, string harga, string stok)
        {
            string xxxx = "select * from travel where nama_travel ='"+namaTravel+"';";

            cmd = new MySqlCommand(xxxx, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                ControlAdmin.getIdTravel = dr[0].ToString();   
            }

           string tambah = "insert into tiket_"+trans.ToLower()+" values(@id_"+trans+",@id_travel,@nama_" + ControlAdmin.jenisControlKendaraan.ToLower() +",@tujuan ,@harga, @stok)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_" + trans.ToLower() + "", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@id_travel", MySqlDbType.VarChar).Value = ControlAdmin.getIdTravel.ToUpper();
                cmd.Parameters.Add("@nama_" + trans.ToLower() + "", MySqlDbType.VarChar).Value = namaTransport.ToUpper();
                cmd.Parameters.Add("@tujuan", MySqlDbType.VarChar).Value = tujuan.ToUpper();
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga.ToUpper();
                cmd.Parameters.Add("@stok", MySqlDbType.VarChar).Value = stok.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void updateTransport(string namaTravel, string trans, string namaTransport, string tujuan , string harga, string stok , string id_trans)
        {
            string xxxx = "select * from travel where nama_travel ='"+namaTravel+"';";

            cmd = new MySqlCommand(xxxx, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                ControlAdmin.getIdTravel = dr[0].ToString();
            }

            string update = "update tiket_"+trans.ToLower()+" set id_travel=@id_travel,nama_"+trans.ToLower()+"=@nama_"+trans.ToLower()+",tujuan=@tujuan,harga=@harga,stok=@stok where id_"+trans.ToLower()+"='"+id_trans+"';";
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id_travel", MySqlDbType.VarChar).Value = ControlAdmin.getIdTravel.ToUpper();
                cmd.Parameters.Add("@nama_" + trans.ToLower() + "", MySqlDbType.VarChar).Value = namaTransport.ToUpper();
                cmd.Parameters.Add("@tujuan", MySqlDbType.VarChar).Value = tujuan.ToUpper();
                cmd.Parameters.Add("@harga", MySqlDbType.VarChar).Value = harga.ToUpper();
                cmd.Parameters.Add("@stok", MySqlDbType.VarChar).Value = stok.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void hapusTrans(string id_trans, string trans)
        {
            string delete = "delete from tiket_"+trans.ToLower()+" where id_"+trans.ToLower()+"='"+id_trans+"';";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_"+trans.ToLower()+"", MySqlDbType.VarChar).Value = id_trans.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Hapus data gagal", exx.Message);
            }
        }

        public void insertHotel(string namaHotel , string kota , string hargaPerMalam, string kamarTersedia)
        {
            string xxxx = "select * from daerah_hotel where kota ='"+ControlAdmin.getNamaKota+"';";

            cmd = new MySqlCommand(xxxx, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                ControlAdmin.getIdKota = dr[0].ToString();
            }

            string tambah = "insert into booking_hotel values(@id_hotel, @id_kota, @nama_hotel, @kota, @harga_per_malam ,@kamar_tersedia)";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_hotel", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@id_kota", MySqlDbType.VarChar).Value = ControlAdmin.getIdKota.ToUpper();
                cmd.Parameters.Add("@nama_hotel", MySqlDbType.VarChar).Value = namaHotel.ToUpper();
                cmd.Parameters.Add("@kota", MySqlDbType.VarChar).Value = kota.ToUpper();
                cmd.Parameters.Add("@harga_per_malam", MySqlDbType.VarChar).Value = hargaPerMalam.ToUpper();
                cmd.Parameters.Add("@kamar_tersedia", MySqlDbType.VarChar).Value = kamarTersedia.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void UpdateHotel(string namaHotel, string hargaPerMalam, string kamarTersedia , string idHotel)
        {
            string xxxx = "select * from daerah_hotel where kota ='"+ControlAdmin.getNamaKota+"';";

            cmd = new MySqlCommand(xxxx, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                ControlAdmin.getIdKota = dr[0].ToString();
            }

            string tambah = "update booking_hotel set id_kota=@id_kota,nama_hotel=@nama_hotel,kota=@kota,harga_per_malam=@harga_per_malam,kamar_tersedia=@kamar_tersedia where id_hotel = '"+idHotel+"';";
            try
            {
                cmd = new MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_kota", MySqlDbType.VarChar).Value = ControlAdmin.getIdKota.ToUpper();
                cmd.Parameters.Add("@nama_hotel", MySqlDbType.VarChar).Value = namaHotel.ToUpper();
                cmd.Parameters.Add("@kota", MySqlDbType.VarChar).Value = ControlAdmin.getNamaKota.ToUpper();
                cmd.Parameters.Add("@harga_per_malam", MySqlDbType.VarChar).Value = hargaPerMalam.ToUpper();
                cmd.Parameters.Add("@kamar_tersedia", MySqlDbType.VarChar).Value = kamarTersedia.ToUpper();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }

        public void hapusHotel(string id_hotel)
        {
            string delete = "delete from booking_hotel where id_hotel = '"+id_hotel+"';";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id_hotel", MySqlDbType.VarChar).Value = id_hotel;
                cmd.ExecuteNonQuery();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Hapus data gagal", exx.Message);
            }
        }

        public void updateDataAdmin(string namaAdmin , string alamatAdmin , string teleponAdmin , string umurAdmin , string jkAdmin , string kodeAdmin)
        {
            string update = "update data_admin set nama_admin=@nama_admin,alamat_admin=@alamat_admin,telepon_admin=@telepon_admin,umur_admin=@umur_admin,jk_admin=@jk_admin where kode_admin='"+kodeAdmin+"';";

            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@nama_admin", MySqlDbType.VarChar).Value = namaAdmin.ToUpper();
                cmd.Parameters.Add("@alamat_admin", MySqlDbType.VarChar).Value = alamatAdmin.ToUpper();
                cmd.Parameters.Add("@telepon_admin", MySqlDbType.VarChar).Value = teleponAdmin.ToUpper();
                cmd.Parameters.Add("@umur_admin", MySqlDbType.VarChar).Value = umurAdmin.ToUpper();
                cmd.Parameters.Add("@jk_admin", MySqlDbType.VarChar).Value = jkAdmin.ToUpper();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update data Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("update data gagal " + ex.Message);

            }
        }

        public void hapusDataAdmin(string nomorTelepon)
        {
            string delete = "delete from data_admin where telepon_admin ='"+nomorTelepon+"';";
            cmd = new MySqlCommand(delete, GetConn());
            cmd.ExecuteNonQuery();
        }
    }
}
