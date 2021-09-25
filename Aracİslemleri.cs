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
    public partial class Aracİslemleri : Form
    {
        public Aracİslemleri()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        void doldur()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbConnection.srConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu FROM Araclar" , sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgAraclar.DataSource = dtbl;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            string AracEkleQuery = "INSERT INTO Araclar (plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu) VALUES (@plaka,@marka,@model,@renk,@yakit,@yıl,@arac_durumu,@satis_durumu)";
            List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@marka" , txtMarka.Text),
                new dbConnection.cmdParameterType("@model" , txtModel.Text),
                new dbConnection.cmdParameterType("@renk" , txtRenk.Text),
                new dbConnection.cmdParameterType("@yakit" , cmbYakıt.Text),
                new dbConnection.cmdParameterType("@yıl" , txtYıl.Text),
                new dbConnection.cmdParameterType("@arac_durumu" , cmbAracDurumu.Text),
                new dbConnection.cmdParameterType("@satis_durumu" , cmbSatıisDurumu.Text)
            };
            if(dbConnection.cmd_update_DB(AracEkleQuery , lstParam) > 0)
            {
                MessageBox.Show("Araç Başarıyla Kaydedildi !");
            }
            doldur();
            this.Refresh();
            txtPlaka.ResetText();
            txtMarka.ResetText();
            txtModel.ResetText();
            txtRenk.ResetText();
            cmbYakıt.ResetText();
            txtYıl.ResetText();
            cmbAracDurumu.ResetText();
            cmbSatıisDurumu.ResetText();
        }

        private void Aracİslemleri_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void lstAraclar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void dtgAraclar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dtgAraclar.CurrentRow.Cells[0].Value.ToString();
            txtMarka.Text = dtgAraclar.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dtgAraclar.CurrentRow.Cells[2].Value.ToString();
            txtRenk.Text = dtgAraclar.CurrentRow.Cells[3].Value.ToString();
            cmbYakıt.Text = dtgAraclar.CurrentRow.Cells[4].Value.ToString();
            txtYıl.Text = dtgAraclar.CurrentRow.Cells[5].Value.ToString();
            cmbAracDurumu.Text = dtgAraclar.CurrentRow.Cells[6].Value.ToString();
            cmbSatıisDurumu.Text = dtgAraclar.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            string AracGuncelleuery = "UPDATE Araclar SET plaka=@plaka,marka=@marka,model=@model,renk=@renk,yakit=@yakit,yıl=@yıl,arac_durumu=@arac_durumu,satis_durumu=@satis_durumu WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@marka" , txtMarka.Text),
                new dbConnection.cmdParameterType("@model" , txtModel.Text),
                new dbConnection.cmdParameterType("@renk" , txtRenk.Text),
                new dbConnection.cmdParameterType("@yakit" , cmbYakıt.Text),
                new dbConnection.cmdParameterType("@yıl" , txtYıl.Text),
                new dbConnection.cmdParameterType("@arac_durumu" , cmbAracDurumu.Text),
                new dbConnection.cmdParameterType("@satis_durumu" , cmbSatıisDurumu.Text)
            };
            if (dbConnection.cmd_update_DB(AracGuncelleuery, lstParam) > 0)
            {
                MessageBox.Show("Araç Bilgileri Güncellenmiştir !");
                doldur();
            }
            else { MessageBox.Show("Bir Hata Oluştu"); return;}
            txtPlaka.ResetText();
            txtMarka.ResetText();
            txtModel.ResetText();
            txtRenk.ResetText();
            cmbYakıt.ResetText();
            txtYıl.ResetText();
            cmbAracDurumu.ResetText();
            cmbSatıisDurumu.ResetText();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            string AracSileuery = "DELETE FROM Araclar WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstParam = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@marka" , txtMarka.Text),
                new dbConnection.cmdParameterType("@model" , txtModel.Text),
                new dbConnection.cmdParameterType("@renk" , txtRenk.Text),
                new dbConnection.cmdParameterType("@yakit" , cmbYakıt.Text),
                new dbConnection.cmdParameterType("@yıl" , txtYıl.Text),
                new dbConnection.cmdParameterType("@arac_durumu" , cmbAracDurumu.Text),
                new dbConnection.cmdParameterType("@satis_durumu" , cmbSatıisDurumu.Text)
            };
            if (dbConnection.cmd_update_DB(AracSileuery, lstParam) > 0)
            {
                MessageBox.Show("AraçBaşarıyla Silinmiştir !!");
                doldur();
            }
            else { MessageBox.Show("Bir Hata Oluştu"); return; }
            txtPlaka.ResetText();
            txtMarka.ResetText();
            txtModel.ResetText();
            txtRenk.ResetText();
            cmbYakıt.ResetText();
            txtYıl.ResetText();
            cmbAracDurumu.ResetText();
            cmbSatıisDurumu.ResetText();
        }

        private void dtgAraclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
