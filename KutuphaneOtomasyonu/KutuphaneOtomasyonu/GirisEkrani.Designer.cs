
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
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.girisYapButonu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisYapmadanDevamEtButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciAdi.AutoSize = true;
            this.kullaniciAdi.Location = new System.Drawing.Point(125, 354);
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
            this.sifre.Location = new System.Drawing.Point(181, 393);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(41, 17);
            this.sifre.TabIndex = 1;
            this.sifre.Text = "Şifre:";
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(227, 351);
            this.kullaniciAdiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(148, 22);
            this.kullaniciAdiTextBox.TabIndex = 3;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.sifreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifreTextBox.Location = new System.Drawing.Point(227, 390);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(148, 22);
            this.sifreTextBox.TabIndex = 4;
            // 
            // girisYapButonu
            // 
            this.girisYapButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisYapButonu.Location = new System.Drawing.Point(281, 428);
            this.girisYapButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisYapButonu.Name = "girisYapButonu";
            this.girisYapButonu.Size = new System.Drawing.Size(148, 46);
            this.girisYapButonu.TabIndex = 5;
            this.girisYapButonu.Text = "Giriş yap";
            this.girisYapButonu.UseVisualStyleBackColor = true;
            this.girisYapButonu.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // girisYapmadanDevamEtButonu
            // 
            this.girisYapmadanDevamEtButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisYapmadanDevamEtButonu.Location = new System.Drawing.Point(127, 428);
            this.girisYapmadanDevamEtButonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisYapmadanDevamEtButonu.Name = "girisYapmadanDevamEtButonu";
            this.girisYapmadanDevamEtButonu.Size = new System.Drawing.Size(148, 46);
            this.girisYapmadanDevamEtButonu.TabIndex = 7;
            this.girisYapmadanDevamEtButonu.Text = "Giriş yapmadan devam et";
            this.girisYapmadanDevamEtButonu.UseVisualStyleBackColor = true;
            this.girisYapmadanDevamEtButonu.Click += new System.EventHandler(this.girisYapmadanDevamEtButonu_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 578);
            this.Controls.Add(this.girisYapmadanDevamEtButonu);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisYapButonu);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdi;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button girisYapButonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button girisYapmadanDevamEtButonu;
    }
}

