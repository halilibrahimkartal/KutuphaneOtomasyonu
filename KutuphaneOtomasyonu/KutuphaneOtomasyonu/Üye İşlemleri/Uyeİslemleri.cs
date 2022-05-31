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
    public partial class Uyeİslemleri : Form
    {
        private Database db = new Database();

        public Uyeİslemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                var komut = db.Command();
                komut.CommandText = "insert into Uye(Uyetipi,kartId,Ad,Soyad,OgrenciNo,OkulAdi,BolumAdi,Eposta,Telefon,KayitTarih,AyrilisTarih) values (@Uyetipi,@KartId,@Ad,@Soyad,@OgrenciNo,@OkulAdi,@BolumAdi,@Eposta,@Telefon,@KayitTarih,@AyrilisTarih)";

                komut.Parameters.AddWithValue("@Uyetipi", Uyetipi.Text);
                komut.Parameters.AddWithValue("@kartId", kartId.Text);
                komut.Parameters.AddWithValue("@Ad", Ad.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
                komut.Parameters.AddWithValue("@OgrenciNo", Ogrencino.Text);
                komut.Parameters.AddWithValue("@OkulAdi", Okuladi.Text);
                komut.Parameters.AddWithValue("@BolumAdi", BolumAdi.Text);
                komut.Parameters.AddWithValue("@Eposta", Eposta.Text);
                komut.Parameters.AddWithValue("@Telefon", Telefon.Text);
                komut.Parameters.AddWithValue("@KayitTarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@AyrilisTarih", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Uye kaydı başarılı.");
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt veritabanına eklenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            db.Open();
            try
            {
                var komut = db.Command();
                komut.CommandText = "delete from Uye where kartId = @kartId";
                komut.Parameters.AddWithValue("@kartId", dataGridView1.CurrentRow.Cells["kartId"].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme işlemi başarılı.");
            }
            catch (MySqlException myEx)
            {

                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Open();
            var komut = db.Command();
            try
            {
                komut.CommandText = "update Uye set Uyetipi = @Uyetipi,kartId = @kartId ,Ad = @Ad,Soyad=@Soyad ,OgrenciNo=@OgrenciNo,OkulAdi=@Okuladi,BolumAdi=@BolumAdi,Eposta=@Eposta,Telefon=@Telefon,KayitTarih=@KayitTarih,AyrilisTarih=@AyrilisTarih where kartId=@kartId";

                komut.Parameters.AddWithValue("@Uyetipi", Uyetipi.Text);
                komut.Parameters.AddWithValue("@kartId", kartId.Text);
                komut.Parameters.AddWithValue("@Ad", Ad.Text);
                komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
                komut.Parameters.AddWithValue("@OgrenciNo", Ogrencino.Text);
                komut.Parameters.AddWithValue("@OkulAdi", Okuladi.Text);
                komut.Parameters.AddWithValue("@BolumAdi", BolumAdi.Text);
                komut.Parameters.AddWithValue("@Eposta", Eposta.Text);
                komut.Parameters.AddWithValue("@Telefon", Telefon.Text);
                komut.Parameters.AddWithValue("@KayitTarih", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@AyrilisTarih", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarılı.");

            }

            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Open();
            string command = @"select kartID,Uyetipi,Ad,Soyad,Telefon,Eposta,OgrenciNo,Okuladi,Bolumadi
                 from Uye";
            var adapter = db.Adapter(command);
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


            dataGridView1.Visible = true;
        }
        private void Uyetipi_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            if (Uyetipi.SelectedItem.ToString() == "Öğrenci")
            {
                Ogrencino.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                BolumAdi.Visible = true;
            }
            else
            {
                Ogrencino.Visible = false;
                label9.Visible = false;
                label12.Visible = false;
                BolumAdi.Visible = false;
            }

        }

        private void Uyeİslemleri_Load_1(object sender, EventArgs e)
        {
            Uyetipi.Items.Add("Akademik Personel");
            Uyetipi.Items.Add("Personel");
            Uyetipi.Items.Add("Öğrenci");


            dataGridView1.Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uyetipi.Text = dataGridView1.CurrentRow.Cells["Uyetipi"].Value.ToString();
            kartId.Text = dataGridView1.CurrentRow.Cells["kartId"].Value.ToString();
            Ad.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            Soyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            Telefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Eposta.Text = dataGridView1.CurrentRow.Cells["Eposta"].Value.ToString();
            Ogrencino.Text = dataGridView1.CurrentRow.Cells["OgrenciNo"].Value.ToString();
            Okuladi.Text = dataGridView1.CurrentRow.Cells["OkulAdi"].Value.ToString();
            BolumAdi.Text = dataGridView1.CurrentRow.Cells["BolumAdi"].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["KayitTarih"].Value);
            //dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["AyrilisTarih"].Value);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
