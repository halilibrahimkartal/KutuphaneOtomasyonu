using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace KutuphaneOtomasyonu
{
    class Database
    {
        private string server = "172.21.54.3";
        private string user = "Beta";
        private string password = "Ulas&Hll.2022";
        private string database = "Beta";

        private MySqlConnection baglanti;
        private MySqlCommand komut;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;
        public void Open()
        {
            baglanti = new MySqlConnection("server=" + this.server + ";uid=" + this.user
                + ";pwd=" + this.password + ";database=" + this.database);
            try
            {
                baglanti.Open();
            }
            catch (MySqlException myEx)
            {

                throw myEx;
            }

        }
        public void Close()
        {
            try
            {
                baglanti.Close();
            }
            catch (MySqlException myEx)
            {

                throw myEx;
            }
        }
        public MySqlCommand Command()
        {
            komut = new MySqlCommand();
            komut.Connection = baglanti;
            return komut;

        }
        public MySqlDataReader Reader()
        {
            return reader;
        }
        public MySqlDataAdapter Adapter(string command)
        {
            adapter = new MySqlDataAdapter(command, baglanti);
            return adapter;
        }
    }
}