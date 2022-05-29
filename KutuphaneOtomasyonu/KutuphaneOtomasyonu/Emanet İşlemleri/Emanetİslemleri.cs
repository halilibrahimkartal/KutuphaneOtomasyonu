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
    public partial class Emanetİslemleri : Form

    {

        
        private Database db = new Database();
        public Emanetİslemleri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            db.Open();
            string command = @"select kartId,ISBN,AlisTarihi,TeslimTarihi,emanetId,KitapAdi
                 from Emanet";
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

        private void Emanetİslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            emanetId.Visible = false;
            KitapAdi.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Open();
                var komut = db.Command();
                komut.CommandText = "insert into Emanet(ISBN,kartID,EmanetId,KitapAdi,AlisTarihi,TeslimTarihi) values (@ISBN,@kartId,@EmanetId@KitapAdi@AlisTarihi,@TeslimTarihi)";

                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);
                komut.Parameters.AddWithValue("@kartId", KartID.Text);
                komut.Parameters.AddWithValue("@AlisTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("X kaydı başarılı.");
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt veritabanına eklenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            db.Open();
            var komut = db.Command();
            try
            {
                komut.CommandText = "update Emanet set EmanetId=@EmanetId,KitapAdi=@KitapAdikartID=@kartId,ISBN=@ISBN,AlisTarihi=@AlisTarihi,TeslimTarihi=@TeslimTarihi where kartId=@kartId";
                
                komut.Parameters.AddWithValue("@kartId", KartID.Text);
                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);               
                komut.Parameters.AddWithValue("@AlisTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarılı.");

            }

            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KartID.Text = dataGridView1.CurrentRow.Cells["kartId"].Value.ToString();
            ISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            emanetId.Text = dataGridView1.CurrentRow.Cells["emanetId"].Value.ToString();
            KitapAdi.Text = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Open();
            try
            {
                var komut = db.Command();
                komut.CommandText = "delete from Emanet where kartId = @kartId";
                komut.Parameters.AddWithValue("@kartId", dataGridView1.CurrentRow.Cells["kartId"].Value);
                komut.ExecuteNonQuery();
                MessageBox.Show("Üye kitabı teslim etti.");
            }
            catch (MySqlException myEx)
            {

                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
        }
    }
}

