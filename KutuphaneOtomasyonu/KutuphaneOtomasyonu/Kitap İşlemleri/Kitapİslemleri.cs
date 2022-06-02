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
        MySqlConnection con;
        private Database baglanti = new Database();
        public Kitapİslemleri()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        }

        private void Kitapİslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                var komut = baglanti.Command();
                komut.CommandText = "insert into Kitaplar1(DemirbasNo,KitapId,ISBN,Barkod,KitapAdi,YazarAd,YazarSoyad,Dil,Yayinevi,Yayinyili,CevirmenAd,CevirmenSoyad,SayfaSayisi,Adet,BaskiYili,BaskiNo,Kategori,KategoriId,DolapNo,RafNo) values (@DemirbasNo,@KitapId,@ISBN,@Barkod,@KitapAdi,@YazarAd,@YazarSoyad,@Dil,@Yayinevi,@Yayinyili,@CevirmenAd,@CevirmenSoyad,@SayfaSayisi,@Adet,@BaskiYili,@BaskiNo,@Kategori,@KategoriId,@DolapNo,@RafNo)";

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

            baglanti.Open();
            try
            {
                var komut = baglanti.Command();
                komut.CommandText = "delete from Kitaplar1 where KitapId = @KitapId";
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
            baglanti.Open();
            var komut = baglanti.Command();
            try
            {
                komut.CommandText = "update Kitaplar1 set DemirbasNo=@DemirbasNo,KitapId=@KitapId,ISBN=@ISBN,Barkod=@Barkod,KitapAdi=@KitapAdi,YazarAd=@YazarAd,YazarSoyad=@YazarSoyad,Dil=@Dil,Yayinevi=@Yayinevi,Yayinyili=@Yayinyili,CevirmenAd=@CevirmenAd,CevirmenSoyad=@CevirmenSoyad,SayfaSayisi=@SayfaSayisi,Adet=@Adet,BaskiYili=@BaskiYili,BaskiNo=@BaskiNo,Kategori=@Kategori,KategoriId=@KategoriId,DolapNo=@DolapNo,RafNo=@RafNo where ISBN=@ISBN";

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
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            baglanti.Open();
            string command = "select DemirbasNo,KitapId,ISBN,Barkod,KitapAdi,YazarAd,YazarSoyad,Dil,Yayinevi,Yayinyili,CevirmenAd,CevirmenSoyad,SayfaSayisi,Adet,BaskiYili,BaskiNo,Kategori,KategoriId,DolapNo,RafNo from Kitaplar1";
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
            Demirbasno.Text = dataGridView1.CurrentRow.Cells["DemirbasNo"].Value.ToString();
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


            //con.Open();

            /* var komut = baglanti.Command();
             komut.CommandText= "select *from Kitaplar1 where KitapAdi like '"+kitaparama.Text+"'";
             MySqlDataReader read = komut.ExecuteReader();
            */


            //MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where KitapAdi like'% " + kitaparama.Text + "%'", con);
            //DataTable dt = new DataTable();
            //adtr.Fill(dt);

            //dataGridView1.DataSource = dt;
            //con.Close();

            if (comboBox1.SelectedIndex == 0)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where DemirbasNo like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where Barkod like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where KitapAdi like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where YazarAd like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where YazarSoyad like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 5)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where Yayinevi like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where CevirmenAd like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where CevirmenSoyad like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 8)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where Kategori like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 9)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where KategoriId like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where DolapNo like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (comboBox1.SelectedIndex == 11)
            {
                con.Open();
                MySqlDataAdapter adtr = new MySqlDataAdapter("select * from Kitaplar1 where RafNo like'% " + kitaparama.Text + "%'", con);
                DataTable dt = new DataTable();
                adtr.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

           






        }
        //if (kitaparama.Text == "")
        //{


        //}

        //MySqlDataAdapter da = new MySqlDataAdapter("SELECT Kitap.,Kategori.,Tur.,Yazar.,YayinEvi.,Cevirmen. FROM Kitap RIGHT JOIN Kategori ON Kategori.ktgrId = Kitap.ktgrId RIGHT JOIN Tur ON Tur.turId = Kitap.turId RIGHT JOIN Yazar ON Yazar.yzrId = Kitap.yzrId RIGHT JOIN YayinEvi ON YayinEvi.yynevId = Kitap.yynevId RIGHT JOIN Cevirmen ON Cevirmen.cvrId = Kitap.cvrId where kitapId like '" + searchBox.Text + "%'", connection);


        //DataTable dt = new DataTable();
        //da.Fill(dt);

        //dataGridView1.DataSource = dt;

        //else if (comboBox1.SelectedIndex == 0)
        //{
        //con.Open();
        //MySqlDataAdapter adtr1 = new MySqlDataAdapter("select * from Kitaplar1 where DemirbasNo like'% " + kitaparama.Text + "%'", con);
        //DataTable dt = new DataTable();
        //adtr1.Fill(dt);
        //dataGridView1.DataSource = dt;
        //}
        //con.Close();


        /*  while (read.Read())
          {
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

          }*/



    }
}

