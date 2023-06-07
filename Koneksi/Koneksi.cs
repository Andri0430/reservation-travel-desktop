using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySqlConnector;
using System.Data;
using System.Windows.Forms;

namespace BISMILLAH.Koneksi
{
    public class Koneksi
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlDataReader dr;

        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost; user=root; database=indo_travel";
            try
            {
                Conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal :" + ex.Message);
            }
            return Conn;
        }
    }
}
