using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using KutuphaneOtomasyonu;

namespace KutuphaneOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        MySqlConnection con;
        Database baglanti = new Database();

        public GirisEkrani()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            
                
                baglanti.Open();
                
                string mysql = "Select*From KullaniciAyarlari where KullaniciAdi=@Kullaniciadi AND Sifre=@sifre";
                MySqlParameter prm1 = new MySqlParameter("Kullaniciadi", kullaniciAdiTextBox.Text.Trim());
                MySqlParameter prm2 = new MySqlParameter("sifre", sifreTextBox.Text.Trim());
                MySqlCommand komut = new MySqlCommand(mysql, con);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AnaEkran giris = new AnaEkran();
                    giris.Show();
                    this.Hide();
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
            baglanti.Close();
            
           

                
      
            
             
        }

        //private void girisYapmadanDevamEtButonu_Click(object sender, EventArgs e)
        //{
        //    AnaEkran giris = new AnaEkran();
        //    giris.Show();
        //    this.Hide();
            
        //}

        
    }
}
