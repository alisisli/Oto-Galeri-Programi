using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_Galeri_Otomasyonu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAracBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracBilgileri aracbilgileri = new AracBilgileri();
            aracbilgileri.Show();
        }

        private void btnAracİslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aracİslemleri aracİslemleri = new Aracİslemleri();
            aracİslemleri.Show();
        }

        private void btnMusteriİslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Musteriİslemleri musteriİslemleri = new Musteriİslemleri();
            musteriİslemleri.Show();
        }

        private void btnAracSatis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracSatis aracSatis = new AracSatis();
            aracSatis.Show();
        }

        private void btnAracKiralama_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracKiralama aracKiralama = new AracKiralama();
            aracKiralama.Show();
        }

        private void btnOturmuKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }
    }
}
