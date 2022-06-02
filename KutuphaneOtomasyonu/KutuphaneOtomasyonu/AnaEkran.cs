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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        

        private void uyeIslemleriButonu_Click(object sender, EventArgs e)
        {
            Uyeİslemleri uyeFormu = new Uyeİslemleri();
            uyeFormu.MdiParent = this;
            uyeFormu.Show();
            
        }

        private void emanetIslemleriButonu_Click(object sender, EventArgs e)
        {
            Emanetİslemleri emanetFormu = new Emanetİslemleri();
            emanetFormu.MdiParent = this;
            emanetFormu.Show();
            

        }

        private void kitapIslemleriButonu_Click(object sender, EventArgs e)
        {
            Kitapİslemleri kitapFormu = new Kitapİslemleri();
            kitapFormu.MdiParent = this;
            kitapFormu.Show();
            
        }

        private void istatistikButonu_Click(object sender, EventArgs e)
        {
            İstatistik istatistikFormu = new İstatistik();
            istatistikFormu.MdiParent = this;
            istatistikFormu.Show();
            
        }

        private void ayarlarButonu_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlarFormu = new Ayarlar();
            ayarlarFormu.MdiParent = this;
            ayarlarFormu.Show();
            

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
