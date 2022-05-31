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
         //string server = "172.21.54.3";
         //string user = "Beta";
         //string password = "Ulas&Hll.2022";
         //string database = "Beta";

        MySqlConnection baglanti = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        private MySqlCommand komut;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;
        public void Open()
        {
            if(baglanti.State != System.Data.ConnectionState.Open)
                baglanti.Open();
 
        }

        internal MySqlDataReader ExecuteReader(string query)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            baglanti.Close();
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
