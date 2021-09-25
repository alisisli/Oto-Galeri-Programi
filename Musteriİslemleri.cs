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
    public partial class Musteriİslemleri : Form
    {
        public Musteriİslemleri()
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
            dtpDTarihi.ResetText();
            txtEhliyetNo.ResetText();
        }
        void MusteriGetir()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbConnection.srConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT tc,ad,soyad,cinsiyet,telefon,d_Tarihi,ehliyet_no FROM Musteri", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgMusteri.DataSource = dtbl;
            }
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            string MusteriEkleQry = "INSERT INTO Musteri(tc,ad,soyad,cinsiyet,telefon,d_Tarihi,ehliyet_no) VALUES (@tc,@ad,@soyad,@cinsiyet,@telefon,@d_Tarihi,@ehliyet_no)";
            List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@ad" , txtAd.Text),
                new dbConnection.cmdParameterType("@soyad" , txtSoyad.Text),
                new dbConnection.cmdParameterType("@cinsiyet" , cmbCinsiyet.Text),
                new dbConnection.cmdParameterType("@telefon" , mskTel.Text),
                new dbConnection.cmdParameterType("@d_Tarihi" , dtpDTarihi.Text),
                new dbConnection.cmdParameterType("@ehliyet_no" , txtEhliyetNo.Text)
            };
            if(dbConnection.cmd_update_DB(MusteriEkleQry , lstParam) > 0)
            {
                MessageBox.Show("Müşteri Başarıyla Eklendi !!");
                MusteriGetir();
                this.Refresh();
                Clear();
            }
        }

        private void Musteriİslemleri_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dtgMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskTc.Text = dtgMusteri.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dtgMusteri.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dtgMusteri.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.Text = dtgMusteri.CurrentRow.Cells[3].Value.ToString();
            mskTel.Text = dtgMusteri.CurrentRow.Cells[4].Value.ToString();
            dtpDTarihi.Value = Convert.ToDateTime(dtgMusteri.CurrentRow.Cells[5].Value);
            txtEhliyetNo.Text = dtgMusteri.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            string MusteriGuncelleQry = "UPDATE Musteri SET tc=@tc,ad=@ad,soyad=@soyad,cinsiyet=@cinsiyet,telefon=@telefon,d_Tarihi=@d_Tarihi,ehliyet_no=@ehliyet_no WHERE tc=@tc";
            List<dbConnection.cmdParameterType> lstUpadate = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@ad" , txtAd.Text),
                new dbConnection.cmdParameterType("@soyad" , txtSoyad.Text),
                new dbConnection.cmdParameterType("@cinsiyet" , cmbCinsiyet.Text),
                new dbConnection.cmdParameterType("@telefon" , mskTel.Text),
                new dbConnection.cmdParameterType("@d_Tarihi" , dtpDTarihi.Text),
                new dbConnection.cmdParameterType("@ehliyet_no" , txtEhliyetNo.Text)
            };
            if(dbConnection.cmd_update_DB(MusteriGuncelleQry , lstUpadate) > 0)
            {
                MessageBox.Show("Müşteri Bilgileri Güncellendi");
                MusteriGetir();
                this.Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            string MusteriSilQry = "DELETE FROM Musteri WHERE tc=@tc";
            List<dbConnection.cmdParameterType> lstDelete = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@ad" , txtAd.Text),
                new dbConnection.cmdParameterType("@soyad" , txtSoyad.Text),
                new dbConnection.cmdParameterType("@cinsiyet" , cmbCinsiyet.Text),
                new dbConnection.cmdParameterType("@telefon" , mskTel.Text),
                new dbConnection.cmdParameterType("@d_Tarihi" , dtpDTarihi.Text),
                new dbConnection.cmdParameterType("@ehliyet_no" , txtEhliyetNo.Text)
            };
            if(dbConnection.cmd_update_DB(MusteriSilQry , lstDelete) > 0)
            {
                MessageBox.Show("Müşteri Başarıyla Silindi");
                MusteriGetir();
                this.Refresh();
                Clear();
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
