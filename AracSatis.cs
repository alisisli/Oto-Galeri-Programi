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
    public partial class AracSatis : Form
    {
        public AracSatis()
        {
            InitializeComponent();
        }

        void Clear()
        {
            mskTc.ResetText();
            txtPlaka.ResetText();
            dtpAlisTarihi.ResetText();
            txtUcret.ResetText();
        }

        void SatisGetir()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbConnection.srConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT tc,plaka,satisTarihi,ucret FROM Satis", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgSatis.DataSource = dtbl;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string SatisEkleQry = "INSERT INTO Satis (tc,plaka,satisTarihi,ucret) VALUES (@tc,@plaka,@satisTarihi,@ucret)";
            List<dbConnection.cmdParameterType> lstMusteri = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@satisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if(dbConnection.cmd_update_DB(SatisEkleQry , lstMusteri) > 0)
            {
                MessageBox.Show("Satış Başarıyla Eklendi !!");
                SatisGetir();
                Clear();
            }
        }

        private void AracSatis_Load(object sender, EventArgs e)
        {
            SatisGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string SatisGuncelleQry = "UPDATE Satis SET tc=@tc,plaka=@plaka,satisTarihi=@satisTarihi,ucret=@ucret WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstSatisGuncelle = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@satisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if (dbConnection.cmd_update_DB(SatisGuncelleQry, lstSatisGuncelle) > 0)
            {
                MessageBox.Show("Güncelleme Başarılıyla Tamamlandı !!");
                SatisGetir();
                Clear();
            }
        }

        private void dtgSatis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskTc.Text = dtgSatis.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text = dtgSatis.CurrentRow.Cells[1].Value.ToString();
            dtpAlisTarihi.Value = Convert.ToDateTime(dtgSatis.CurrentRow.Cells[2].Value);
            txtUcret.Text = dtgSatis.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string SatisSileQry = "DELETE FROM Satis WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstSatisSil = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@satisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if (dbConnection.cmd_update_DB(SatisSileQry, lstSatisSil) > 0)
            {
                MessageBox.Show("Satış Başarıyla Silindi !!");
                SatisGetir();
                Clear();
            }
        }
    }
}
