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
    public partial class Kitapİslemleri : Form
    {
        private Database db = new Database();
        public Kitapİslemleri()
        {
            InitializeComponent();
        }

        private void Kitapİslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                var komut = db.Command();
                komut.CommandText = "insert into Kitaplar(DemirbasNo,KitapId,ISBN,Barkod,KitapAdi,YazarAd,YazarSoyad,Dil,Yayinevi,Yayinyili,CevirmenAd,CevirmenSoyad,SayfaSayisi,Adet,BaskiYili,BaskiNo,Kategori,KategoriId,DolapNo,RafNo) values (@DemirbasNo,@KitapId,@ISBN,@Barkod,@KitapAdi,@YazarAd,@YazarSoyad,@Dil,@Yayinevi,@Yayinyili,@CevirmenAd,@CevirmenSoyad,@SayfaSayisi,@Adet,@BaskiYili,@BaskiNo,@Kategori,@KategoriId,@DolapNo,@RafNo)";

                komut.Parameters.AddWithValue("@DemirbasNo", Demirbasno.Text);
                komut.Parameters.AddWithValue("@KitapId", kitapID.Text);
                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);
                komut.Parameters.AddWithValue("@Barkod", Barkod.Text);
                komut.Parameters.AddWithValue("@KitapAdi", kitapadı.Text);
                komut.Parameters.AddWithValue("@YazarAd", yazarad.Text);
                komut.Parameters.AddWithValue("@YazarSoyad", yazarsoyad.Text);
                komut.Parameters.AddWithValue("@Dil", dil.Text);
                komut.Parameters.AddWithValue("@Yayinevi", yayinevi.Text);
                komut.Parameters.AddWithValue("@YayinYili", yayinyili.Text);
                komut.Parameters.AddWithValue("@CevirmenAd", cevirmenad.Text);
                komut.Parameters.AddWithValue("@CevirmenSoyad", cevirmensoyad.Text);
                komut.Parameters.AddWithValue("@SayfaSayisi", sayfasayisi.Text);
                komut.Parameters.AddWithValue("@Adet", adet.Text);
                komut.Parameters.AddWithValue("@BaskiYili", baskiyili.Text);
                komut.Parameters.AddWithValue("@BaskiNo", baskino.Text);
                komut.Parameters.AddWithValue("@Kategori", kategori.Text);
                komut.Parameters.AddWithValue("@KategoriId", kategorino.Text);
                komut.Parameters.AddWithValue("@DolapNo", dolapno.Text);
                komut.Parameters.AddWithValue("@RafNo", rafno.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap kaydı başarılı.");
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
                komut.CommandText = "delete from Kitaplar where KitapId = @KitapId";
                komut.Parameters.AddWithValue("@KitapId", dataGridView1.CurrentRow.Cells["kitapId"].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap silme işlemi başarılı.");
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
                komut.CommandText = "update Kitaplar set DemirbasNo=@DemirbasNo,KitapId=@KitapId,ISBN=@ISBN,Barkod=@Barkod,KitapAdi=@KitapAdi,YazarAd=@YazarAd,YazarSoyad=@YazarSoyad,Dil=@Dil,Yayinevi=@Yayinevi,Yayinyili=@Yayinyili,CevirmenAd=@CevirmenAd,CevirmenSoyad=@CevirmenSoyad,SayfaSayisi=@SayfaSayisi,Adet=@Adet,BaskiYili=@BaskiYili,BaskiNo=@BaskiNo,Kategori=@Kategori,KategoriId=@KategoriId,DolapNo=@DolapNo,RafNo=@RafNo where ISBN=@ISBN";

                komut.Parameters.AddWithValue("@DemirbasNo", Demirbasno.Text);
                komut.Parameters.AddWithValue("@KitapId", kitapID.Text);
                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);
                komut.Parameters.AddWithValue("@Barkod", Barkod.Text);
                komut.Parameters.AddWithValue("@KitapAdi", kitapadı.Text);
                komut.Parameters.AddWithValue("@YazarAd", yazarad.Text);
                komut.Parameters.AddWithValue("@YazarSoyad", yazarsoyad.Text);
                komut.Parameters.AddWithValue("@Dil", dil.Text);
                komut.Parameters.AddWithValue("@Yayinevi", yayinevi.Text);
                komut.Parameters.AddWithValue("@YayinYili", yayinyili.Text);
                komut.Parameters.AddWithValue("@CevirmenAd", cevirmenad.Text);
                komut.Parameters.AddWithValue("@CevirmenSoyad", cevirmensoyad.Text);
                komut.Parameters.AddWithValue("@SayfaSayisi", sayfasayisi.Text);
                komut.Parameters.AddWithValue("@Adet", adet.Text);
                komut.Parameters.AddWithValue("@BaskiYili", baskiyili.Text);
                komut.Parameters.AddWithValue("@BaskiNo", baskino.Text);
                komut.Parameters.AddWithValue("@Kategori", kategori.Text);
                komut.Parameters.AddWithValue("@KategoriId", kategorino.Text);
                komut.Parameters.AddWithValue("@DolapNo", dolapno.Text);
                komut.Parameters.AddWithValue("@RafNo", rafno.Text);
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
            dataGridView1.Visible = true;

            db.Open();
            string command = @"select DemirbasNo,KitapId,ISBN,Barkod,KitapAdi,YazarAd,YazarSoyad,Dil,Yayinevi,Yayinyili,CevirmenAd,CevirmenSoyad,SayfaSayisi,Adet,BaskiYili,BaskiNo,Kategori,KategoriId,DolapNo,RafNo
                 from Kitaplar";
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

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Demirbasno.Text = dataGridView1.CurrentRow.Cells["Demirbasno"].Value.ToString();
            kitapID.Text = dataGridView1.CurrentRow.Cells["kitapId"].Value.ToString();
            ISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            Barkod.Text = dataGridView1.CurrentRow.Cells["Barkod"].Value.ToString();
            kitapadı.Text = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();
            yazarad.Text = dataGridView1.CurrentRow.Cells["YazarAd"].Value.ToString();
            yazarsoyad.Text = dataGridView1.CurrentRow.Cells["YazarSoyad"].Value.ToString();
            dil.Text = dataGridView1.CurrentRow.Cells["Dil"].Value.ToString();
            yayinevi.Text = dataGridView1.CurrentRow.Cells["Yayinevi"].Value.ToString();
            yayinyili.Text = dataGridView1.CurrentRow.Cells["YayinYili"].Value.ToString();
            cevirmenad.Text = dataGridView1.CurrentRow.Cells["CevirmenAd"].Value.ToString();
            cevirmensoyad.Text = dataGridView1.CurrentRow.Cells["CevirmenSoyad"].Value.ToString();
            sayfasayisi.Text = dataGridView1.CurrentRow.Cells["SayfaSayisi"].Value.ToString();
            adet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            baskiyili.Text = dataGridView1.CurrentRow.Cells["BaskiYili"].Value.ToString();
            baskino.Text = dataGridView1.CurrentRow.Cells["BaskiNo"].Value.ToString();
            kategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            kategorino.Text = dataGridView1.CurrentRow.Cells["KategoriId"].Value.ToString();
            dolapno.Text = dataGridView1.CurrentRow.Cells["DolapNo"].Value.ToString();
            rafno.Text = dataGridView1.CurrentRow.Cells["RafNo"].Value.ToString();
        }

        private void kitaparama_TextChanged(object sender, EventArgs e)
        {
            db.Open();
            var komut = db.Command();
            komut.CommandText= "select *from Kitaplar where KitapAdi like '" + kitaparama.Text+"'";
            MySqlDataReader read = komut.ExecuteReader();
            
      

            while (read.Read()) {
                Demirbasno.Text = read["Demirbasno"].ToString();
                kitapID.Text = read["kitapId"].ToString();
                ISBN.Text = read["ISBN"].ToString();
                Barkod.Text = read["Barkod"].ToString();
                kitapadı.Text = read["KitapAdi"].ToString();
                yazarad.Text = read["YazarAd"].ToString();
                yazarsoyad.Text = read["YazarSoyad"].ToString();
                dil.Text = read["Dil"].ToString();
                yayinevi.Text = read["Yayinevi"].ToString();
                yayinyili.Text = read["YayinYili"].ToString();
                cevirmenad.Text = read["CevirmenAd"].ToString();
                cevirmensoyad.Text = read["CevirmenSoyad"].ToString();
                sayfasayisi.Text = read["SayfaSayisi"].ToString();
                adet.Text = read["Adet"].ToString();
                baskiyili.Text = read["BaskiYili"].ToString();
                baskino.Text = read["BaskiNo"].ToString();
                kategori.Text = read["Kategori"].ToString();
                kategorino.Text = read["KategoriId"].ToString();
                dolapno.Text = read["DolapNo"].ToString();
                rafno.Text = read["RafNo"].ToString();

            }
            read.Close();

        }
    }
}
