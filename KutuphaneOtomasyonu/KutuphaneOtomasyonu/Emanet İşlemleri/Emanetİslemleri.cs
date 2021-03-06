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

        MySqlConnection con;
        private Database db = new Database();
        public Emanetİslemleri()
        {
            InitializeComponent();
            con = new MySqlConnection("server=172.21.54.3; user id =Beta; pwd=Ulas&Hll.2022; database=Beta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            db.Open();
            string command = @"select emanetId,kartId,ISBN,KitapAdi,AlisTarihi,TeslimTarihi,EmanetinDurumu from Emanet1";
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
            db.Close();
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
                komut.CommandText = "insert into Emanet1(ISBN,kartID,AlisTarihi,TeslimTarihi,EmanetinDurumu) values (@ISBN,@kartId,@AlisTarihi,@TeslimTarihi,EmanetinDurumu)";

                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);
                komut.Parameters.AddWithValue("@kartId", KartID.Text);
                komut.Parameters.AddWithValue("@AlisTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@EmanetinDurumu", teslimAlindiTextBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("kayıt başarılı.");
            }
            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt veritabanına eklenirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
                
            }
            db.Close();
        }

        private void teslimAlButonu_Click(object sender, EventArgs e)
        {
            db.Open();
            var komut = db.Command();
            try
            {
                komut.CommandText = "update Emanet1 set kartID=@kartId,ISBN=@ISBN,AlisTarihi=@AlisTarihi,TeslimTarihi=@TeslimTarihi,EmanetinDurumu=@EmanetinDurumu where kartId=@kartId";
                
                komut.Parameters.AddWithValue("@kartId", KartID.Text);
                komut.Parameters.AddWithValue("@ISBN", ISBN.Text);               
                komut.Parameters.AddWithValue("@AlisTarihi", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Value);
                komut.Parameters.AddWithValue("@EmanetinDurumu", teslimAlindiTextBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Düzenleme başarılı.");

            }

            catch (MySqlException myEx)
            {
                string hata = string.Format("Kayıt silinirken bir hata oluştu.\n{0}", myEx.Message);
                MessageBox.Show(hata);
            }
            db.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KartID.Text = dataGridView1.CurrentRow.Cells["kartId"].Value.ToString();
            ISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
            emanetId.Text = dataGridView1.CurrentRow.Cells["emanetId"].Value.ToString();
            KitapAdi.Text = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();
            teslimAlindiTextBox.Text = dataGridView1.CurrentRow.Cells["EmanetinDurumu"].Value.ToString();


        }

        
    }
}

