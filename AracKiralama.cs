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
    public partial class AracKiralama : Form
    {
        public AracKiralama()
        {
            InitializeComponent();
        }

        void Clear()
        {
            mskTc.ResetText();
            txtPlaka.ResetText();
            dtpAlisTarihi.ResetText();
            dtpTeslimTarihi.ResetText();
            txtUcret.ResetText();
        }

        void KiraGetir()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbConnection.srConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT tc,plaka,alisTarihi,teslimTarihi,ucret FROM Kiralama", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dtgKiralama.DataSource = dtbl;
            }
        }
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void AracKiralama_Load(object sender, EventArgs e)
        {
            KiraGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string kiraEkleQry = "INSERT INTO Kiralama (tc,plaka,alisTarihi,teslimTarihi,ucret) VALUES (@tc,@plaka,@alisTarihi,@teslimTarihi,@ucret)";
            List<dbConnection.cmdParameterType> lstKiraEkle = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@alisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@teslimTarihi" , dtpTeslimTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if(dbConnection.cmd_update_DB(kiraEkleQry , lstKiraEkle) > 0)
            {
                MessageBox.Show("Kira Başarıyla Eklendi !!");
                KiraGetir();
                Clear();
            }
            else
            {
                MessageBox.Show("HATA OLUŞTU");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string kiraGuncelleQry = "UPDATE Kiralama SET tc=@tc,plaka=@plaka,alisTarihi=@alisTarihi,teslimTarihi=@teslimTarihi,ucret=@ucret WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstKiraGuncelle = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@alisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@teslimTarihi" , dtpTeslimTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if (dbConnection.cmd_update_DB(kiraGuncelleQry, lstKiraGuncelle) > 0)
            {
                MessageBox.Show("Kira Başarıyla Güncellendi !!");
                KiraGetir();
                Clear();
            }
            else
            {
                MessageBox.Show("HATA OLUŞTU");
            }
        }

        private void dtgKiralama_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskTc.Text = dtgKiralama.CurrentRow.Cells[0].Value.ToString();
            txtPlaka.Text = dtgKiralama.CurrentRow.Cells[1].Value.ToString();
            dtpAlisTarihi.Value = Convert.ToDateTime(dtgKiralama.CurrentRow.Cells[2].Value);
            dtpTeslimTarihi.Value = Convert.ToDateTime(dtgKiralama.CurrentRow.Cells[3].Value);
            txtUcret.Text = dtgKiralama.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string kiraSilQry = "DELETE FROM Kiralama WHERE plaka=@plaka";
            List<dbConnection.cmdParameterType> lstKiraSil = new List<dbConnection.cmdParameterType>
            {
                new dbConnection.cmdParameterType("@tc" , mskTc.Text),
                new dbConnection.cmdParameterType("@plaka" , txtPlaka.Text),
                new dbConnection.cmdParameterType("@alisTarihi" , dtpAlisTarihi.Text),
                new dbConnection.cmdParameterType("@teslimTarihi" , dtpTeslimTarihi.Text),
                new dbConnection.cmdParameterType("@ucret" , txtUcret.Text)
            };
            if (dbConnection.cmd_update_DB(kiraSilQry, lstKiraSil) > 0)
            {
                MessageBox.Show("Kira Başarıyla Silindi !!");
                KiraGetir();
                Clear();
            }
            else
            {
                MessageBox.Show("HATA OLUŞTU");
            }
        }
    }
}
