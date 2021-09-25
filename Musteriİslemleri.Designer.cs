
namespace Oto_Galeri_Otomasyonu
{
    partial class Musteriİslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriİslemleri));
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.dtgMusteri = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.dtpDTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtEhliyetNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.Image")));
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.Location = new System.Drawing.Point(431, 306);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(311, 61);
            this.btnMusteriEkle.TabIndex = 80;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGuncelle.Image")));
            this.btnMusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(431, 217);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(311, 61);
            this.btnMusteriGuncelle.TabIndex = 79;
            this.btnMusteriGuncelle.Text = "GÜNCELLE";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.Image")));
            this.btnMusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriSil.Location = new System.Drawing.Point(431, 126);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(311, 61);
            this.btnMusteriSil.TabIndex = 78;
            this.btnMusteriSil.Text = "SİL";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.Image = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa.Image")));
            this.btnAnasayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnasayfa.Location = new System.Drawing.Point(431, 34);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(311, 61);
            this.btnAnasayfa.TabIndex = 77;
            this.btnAnasayfa.Text = "ANASAYFA";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // dtgMusteri
            // 
            this.dtgMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMusteri.Location = new System.Drawing.Point(23, 407);
            this.dtgMusteri.Name = "dtgMusteri";
            this.dtgMusteri.RowHeadersWidth = 51;
            this.dtgMusteri.RowTemplate.Height = 24;
            this.dtgMusteri.Size = new System.Drawing.Size(719, 261);
            this.dtgMusteri.TabIndex = 76;
            this.dtgMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMusteri_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(71, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "D.Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 68;
            this.label7.Text = "Ehliyet No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(78, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 60;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "TC :";
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.mskTc.Location = new System.Drawing.Point(164, 111);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(194, 28);
            this.mskTc.TabIndex = 81;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.mskTel.Location = new System.Drawing.Point(163, 262);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(194, 28);
            this.mskTel.TabIndex = 83;
            // 
            // dtpDTarihi
            // 
            this.dtpDTarihi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDTarihi.Location = new System.Drawing.Point(165, 300);
            this.dtpDTarihi.Name = "dtpDTarihi";
            this.dtpDTarihi.Size = new System.Drawing.Size(193, 28);
            this.dtpDTarihi.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 40);
            this.label8.TabIndex = 85;
            this.label8.Text = "MÜŞTERİ BİLGİLERİ";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(163, 148);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(195, 27);
            this.txtAd.TabIndex = 110;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(164, 186);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(194, 27);
            this.txtSoyad.TabIndex = 111;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(163, 224);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(194, 28);
            this.cmbCinsiyet.TabIndex = 112;
            // 
            // txtEhliyetNo
            // 
            this.txtEhliyetNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEhliyetNo.Location = new System.Drawing.Point(165, 339);
            this.txtEhliyetNo.Name = "txtEhliyetNo";
            this.txtEhliyetNo.Size = new System.Drawing.Size(192, 27);
            this.txtEhliyetNo.TabIndex = 113;
            // 
            // Musteriİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(87)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(772, 698);
            this.Controls.Add(this.txtEhliyetNo);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDTarihi);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dtgMusteri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Musteriİslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriİslemleri";
            this.Load += new System.EventHandler(this.Musteriİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.DataGridView dtgMusteri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.DateTimePicker dtpDTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.TextBox txtEhliyetNo;
    }
}