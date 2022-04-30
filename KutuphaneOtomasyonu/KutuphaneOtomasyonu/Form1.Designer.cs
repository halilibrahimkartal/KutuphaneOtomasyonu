
namespace KutuphaneOtomasyonu
{
    partial class GirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.kullaniciAdi = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGirisYapmadanDevamEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(135, 354);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(88, 17);
            this.kullaniciAdi.TabIndex = 0;
            this.kullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // sifre
            // 
            this.sifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(182, 393);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(41, 17);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(227, 351);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(129, 22);
            this.textBoxKullaniciAdi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSifre.Location = new System.Drawing.Point(227, 390);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(129, 22);
            this.textBoxSifre.TabIndex = 4;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGirisYap.Location = new System.Drawing.Point(256, 428);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(100, 45);
            this.buttonGirisYap.TabIndex = 5;
            this.buttonGirisYap.Text = "Giriş yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonGirisYapmadanDevamEt
            // 
            this.buttonGirisYapmadanDevamEt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGirisYapmadanDevamEt.Location = new System.Drawing.Point(127, 428);
            this.buttonGirisYapmadanDevamEt.Name = "buttonGirisYapmadanDevamEt";
            this.buttonGirisYapmadanDevamEt.Size = new System.Drawing.Size(123, 45);
            this.buttonGirisYapmadanDevamEt.TabIndex = 7;
            this.buttonGirisYapmadanDevamEt.Text = "Giriş yapmadan devam et";
            this.buttonGirisYapmadanDevamEt.UseVisualStyleBackColor = true;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(496, 578);
            this.Controls.Add(this.buttonGirisYapmadanDevamEt);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGirisYapmadanDevamEt;
    }
}

