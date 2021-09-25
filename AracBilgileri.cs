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
    public partial class AracBilgileri : Form
    {
        public AracBilgileri()
        {
            InitializeComponent();
        }
        void Filter()
        {
            using (SqlConnection sqlconn = new SqlConnection(dbConnection.srConnectionString))
            {
                DataTable dtbl = new DataTable();
                dtbl.Clear();
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu FROM Araclar WHERE plaka='" + txtFilter.Text + "'", sqlconn);
                sqlDa.Fill(dtbl);
                dtgAracBilgileri.DataSource = dtbl;
            }
        }
        void SatısaUygun()
        {
            using (SqlConnection sqlconn = new SqlConnection(dbConnection.srConnectionString))
            {
                DataTable dtbl = new DataTable();
                dtbl.Clear();
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu FROM Araclar WHERE satis_durumu='SATIŞA UYGUN'", sqlconn);
                sqlDa.Fill(dtbl);
                dtgAracBilgileri.DataSource = dtbl;
            }
        }
        void KirayaUygun()
        {
            using (SqlConnection sqlconn = new SqlConnection(dbConnection.srConnectionString))
            {
                DataTable dtbl = new DataTable();
                dtbl.Clear();
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu FROM Araclar WHERE satis_durumu='KİRAYA UYGUN'", sqlconn);
                sqlDa.Fill(dtbl);
                dtgAracBilgileri.DataSource = dtbl;
            }
        }
        void doldur()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbConnection.srConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT plaka,marka,model,renk,yakit,yıl,arac_durumu,satis_durumu FROM Araclar", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgAracBilgileri.DataSource = dtbl;
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        private void btnTumAraclar_Click(object sender, EventArgs e)
        {
            doldur();
        }

        private void btnSatisaUygun_Click(object sender, EventArgs e)
        {
            SatısaUygun();
        }

        private void btnKirayaUygun_Click(object sender, EventArgs e)
        {
            KirayaUygun();
        }

        private void dtgAracBilgileri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dtgAracBilgileri.CurrentRow.Cells[0].Value.ToString();
            txtMarka.Text = dtgAracBilgileri.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dtgAracBilgileri.CurrentRow.Cells[2].Value.ToString();
            txtRenk.Text = dtgAracBilgileri.CurrentRow.Cells[3].Value.ToString();
            cmbYakit.Text = dtgAracBilgileri.CurrentRow.Cells[4].Value.ToString();
            txtYıl.Text = dtgAracBilgileri.CurrentRow.Cells[5].Value.ToString();
            cmbAracDurumu.Text = dtgAracBilgileri.CurrentRow.Cells[6].Value.ToString();
            cmbSatısDurumu.Text = dtgAracBilgileri.CurrentRow.Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
