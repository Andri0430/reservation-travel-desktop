using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;
using BISMILLAH.Data_Tampungan;
using System.Data;

namespace BISMILLAH.DataController
{
    class AdminController : Koneksi.Koneksi
    {
        DataTable data = new DataTable();
        public int login_admin(string username, string password)
        {
            int a = 0;
            string login = "select * from akun_admin where user_admin = '" + username + "' and sandi_admin='" + password + "'";
            cmd = new MySqlCommand(login, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                DataAdmin.username = dr[1].ToString();
                DataAdmin.password = dr[2].ToString();
                a = 1;
            }
            return a;
        }

        public int cek_data_admin(string nama, string nohp)
        {
            int cek = 0;
            string cekData = "select nama_admin from data_admin where nama_admin = '" + nama + "' and telepon_admin='" + nohp + "'";
            cmd = new MySqlCommand(cekData, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                cek = 1;
            }
            return cek;
        }

        public int cek_akun_admin(string username)
        {
            int cek2 = 0;
            string cekAkun = "select user_admin from akun_admin where user_admin = '" + username + "'";
            cmd = new MySqlCommand(cekAkun, GetConn());
            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                cek2 = 1;
            }

            return cek2;
        }

        public void insert_data_admin(string nama, string kota, string nohp, string usia, string jk, string user, string pw)
        {
            int foreign = 0;
            string cari = "select * from akun_admin where user_admin = '" + user + "' and sandi_admin = '" + pw + "'";
            cmd = new MySqlCommand(cari, GetConn());
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                foreign = Convert.ToInt32(dr[0].ToString());
            }

            string insert_da = "insert into data_admin values(@kode_admin,@nama_admin,@alamat_admin,@telepon_admin,@umur_admin,@jk_admin)";
            try
            {
                cmd = new MySqlCommand(insert_da, GetConn());
                cmd.Parameters.Add("@kode_admin", MySqlDbType.VarChar).Value = foreign.ToString().ToUpper();
                cmd.Parameters.Add("@nama_admin", MySqlDbType.VarChar).Value = nama.ToUpper();
                cmd.Parameters.Add("@alamat_admin", MySqlDbType.VarChar).Value = kota.ToUpper();
                cmd.Parameters.Add("@telepon_admin", MySqlDbType.VarChar).Value = nohp.ToUpper();
                cmd.Parameters.Add("@umur_admin", MySqlDbType.VarChar).Value = usia.ToUpper();
                cmd.Parameters.Add("@jk_admin", MySqlDbType.VarChar).Value = jk.ToUpper();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Akun berhasil di buat");
            }
            catch (Exception e1)
            {
                MessageBox.Show("Daftar Akun Gagal" + e1.Message);
            }
        }

        public void insert_akun_admin(string username2, string password2)
        {
            string insert_ad = "insert into akun_admin values(@kode_admin,@user_admin,@sandi_admin)";
            try
            {
                cmd = new MySqlCommand(insert_ad, GetConn());
                cmd.Parameters.Add("@kode_admin", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("@user_admin", MySqlDbType.VarChar).Value = username2;
                cmd.Parameters.Add("@sandi_admin", MySqlDbType.VarChar).Value = password2;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Daftar Akun Gagal2" + e1.Message);
            }
        }
        public DataTable tampilDataAkun()
        {
            try
            {
                string view = $"select * from data_admin";
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
