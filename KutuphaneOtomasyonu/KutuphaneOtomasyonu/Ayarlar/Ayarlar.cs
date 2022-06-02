using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Ayarlar : Form

    {
        MySqlConnection con;
        private Database baglanti = new Database();
        public Ayarlar()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

        }

        private void ekleButonu_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                var komut = baglanti.Command();
                komut.CommandText = "insert into KullaniciAyarlari(KullaniciID,Adi,Soyadi,KullaniciAdi,Sifre,KullanilacakVeriTabani,KullaniciTipi) values (@KullaniciID,@Adi,@Soyadi,@KullaniciAdi,@Sifre,@KullanilacakVeriTabani,@KullaniciTipi)";

                komut.Parameters.AddWithValue("@KullaniciID", kullaniciIDtextBox.Text);
                komut.Parameters.AddWithValue("@Adi", gorevliAdTextBox.Text);
                komut.Parameters.AddWithValue("@Soyadi", gorevliSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdiTextBox.Text);
                komut.Parameters.AddWithValue("@Sifre", sifreTextBox.Text);
                komut.Parameters.AddWithValue("@KullanilacakVeriTabani", veritabaniComboBox.Text);
                komut.Parameters.AddWithValue("@KullaniciTipi", gorevliTuruComboBox.Text);


                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı kaydı başarılı.");
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt veritabanına eklenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void silButonu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                var komut = baglanti.Command();
                komut.CommandText = "delete from KullaniciAyarlari where KullaniciID = @KullaniciID";
                komut.Parameters.AddWithValue("@KullaniciID", dataGridView1.CurrentRow.Cells["KullaniciID"].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı silme işlemi başarılı.");
            }
            catch (MySqlException myEx)
            {

                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void guncelleButonu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            var komut = baglanti.Command();
            try
            {
                komut.CommandText = "update KullaniciAyarlari set KullaniciID=@KullaniciID,Adi=@Adi,Soyadi=@Soyadi,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,KullanilacakVeriTabani=@KullanilacakVeriTabani,KullaniciTipi=@KullaniciTipi where KullaniciID=@KullaniciID ";

                komut.Parameters.AddWithValue("@KullaniciID", kullaniciIDtextBox.Text);
                komut.Parameters.AddWithValue("@Adi", gorevliAdTextBox.Text);
                komut.Parameters.AddWithValue("@Soyadi", gorevliSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdiTextBox.Text);
                komut.Parameters.AddWithValue("@Sifre", sifreTextBox.Text);
                komut.Parameters.AddWithValue("@KullanilacakVeriTabani", veritabaniComboBox.Text);
                komut.Parameters.AddWithValue("@KullaniciTipi", gorevliTuruComboBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarılı.");

            }

            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
            baglanti.Close();
        }

        private void listeleButonu_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            baglanti.Open();
            string command = "select KullaniciID,Adi,Soyadi,KullaniciAdi,Sifre,KullanilacakVeriTabani,KullaniciTipi from KullaniciAyarlari";
            var adapter = baglanti.Adapter(command);
            try
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıtlar listelenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
                this.Close();
            }
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciIDtextBox.Text = dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString();
            gorevliAdTextBox.Text = dataGridView1.CurrentRow.Cells["Adi"].Value.ToString();
            gorevliSoyadTextBox.Text = dataGridView1.CurrentRow.Cells["Soyadi"].Value.ToString();
            kullaniciAdiTextBox.Text = dataGridView1.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
            sifreTextBox.Text = dataGridView1.CurrentRow.Cells["Sifre"].Value.ToString();
            veritabaniComboBox.Text = dataGridView1.CurrentRow.Cells["KullanilacakVeriTabani"].Value.ToString();
            gorevliTuruComboBox.Text = dataGridView1.CurrentRow.Cells["KullaniciTipi"].Value.ToString();
        }
    }
}
