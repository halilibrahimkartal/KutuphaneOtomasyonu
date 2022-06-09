using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu
{
    public partial class İstatistik : Form
    {
        MySqlConnection con;
        private Database baglanti = new Database();
        public İstatistik()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand komut = new MySqlCommand("Select KitapAdi,Adet From Kitaplar1", con);
            MySqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                chart1.Series["Series1"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
            con.Close();
            
        }
    }
}
