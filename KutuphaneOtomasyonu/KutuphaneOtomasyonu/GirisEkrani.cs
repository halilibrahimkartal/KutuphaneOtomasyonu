using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text;
            string sifre = sifreTextBox.Text;

            if (kullaniciAdi.Equals("admin") && sifre.Equals("123"))
            {
                AnaEkran giris = new AnaEkran();
                giris.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı tekrardan deneyin !");
                    
            }
    
        }

        private void girisYapmadanDevamEtButonu_Click(object sender, EventArgs e)
        {
            AnaEkran giris = new AnaEkran();
            giris.Show();
            this.Hide();
            
        }
    }
}
