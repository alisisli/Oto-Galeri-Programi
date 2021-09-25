using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oto;

namespace Oto_Galeri_Otomasyonu
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        void Clear()
        {
            mskTc.ResetText();
            txtAd.ResetText();
            txtSoyad.ResetText();
            cmbCinsiyet.ResetText();
            mskTel.ResetText();
            txtKullaniciAdi.ResetText();
            txtSifre.ResetText();
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string KullanıcıEkleQry = "INSERT INTO Login (tc,ad,soyad,cinsiyet,telefon,kullanıcıAdı,sifre) VALUES (@tc,@ad,@soyad,@cinsiyet,@telefon,@kullanıcıAdı,@sifre)";
            List<dbConnection.cmdParameterType> lstKullanıcıEkle = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@ad" , txtAd.Text),
                new dbConnection.cmdParameterType("@soyad" , txtSoyad.Text),
                new dbConnection.cmdParameterType("@cinsiyet" , cmbCinsiyet.Text),
                new dbConnection.cmdParameterType("@telefon" , mskTel.Text),
                new dbConnection.cmdParameterType("@kullanıcıAdı" , txtKullaniciAdi.Text),
                new dbConnection.cmdParameterType("@sifre" , txtSifre.Text)
            };
            if(dbConnection.cmd_update_DB (KullanıcıEkleQry , lstKullanıcıEkle) > 0)
            {
                MessageBox.Show("Kullanıcı Başarıyla Eklendi !!");
                Clear();
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string KullanıcıSilQry = "DELETE FROM Login WHERE kullanıcıAdı=@kullanıcıAdı AND sifre=@sifre";
            List<dbConnection.cmdParameterType> lstKullanıcıSil = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@ad" , txtAd.Text),
                new dbConnection.cmdParameterType("@soyad" , txtSoyad.Text),
                new dbConnection.cmdParameterType("@cinsiyet" , cmbCinsiyet.Text),
                new dbConnection.cmdParameterType("@telefon" , mskTel.Text),
                new dbConnection.cmdParameterType("@kullanıcıAdı" , txtKAdiSilme.Text),
                new dbConnection.cmdParameterType("@sifre" , txtSifreSilme.Text)
            };
            if(dbConnection.cmd_update_DB(KullanıcıSilQry , lstKullanıcıSil) > 0)
            {
                MessageBox.Show("Kullanıcı Başarıyla Silindi");
                txtKAdiSilme.ResetText();
                txtSifreSilme.ResetText();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                txtKAdiSilme.ResetText();
                txtSifreSilme.ResetText();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string SifreDegistirQry = "UPDATE Login SET sifre=@sifre WHERE kullanıcıAdı=@kullanıcıAdı";
            List<dbConnection.cmdParameterType> lstSifreDegistir = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@kullanıcıAdı" , txtMevcutKadi.Text),
                new dbConnection.cmdParameterType("@sifre" , txtYeniSifre.Text)
            };
            if (dbConnection.cmd_update_DB(SifreDegistirQry, lstSifreDegistir) > 0)
            {
                MessageBox.Show("Şifre Başarıyla Değiştirildi");
                txtMevcutKadi.ResetText();
                txtYeniSifre.ResetText();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı");
                txtMevcutKadi.ResetText();
                txtYeniSifre.ResetText();
            }
        }
    }
}
