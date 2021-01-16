using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakcıOtomasyon
{
    public partial class KullaniciAnasayfa : Form
    {
        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Dispose();
            }

        }

        private void btnKonutEkle_Click(object sender, EventArgs e)
        {
            KullaniciKonutEkle konut = new KullaniciKonutEkle();
            konut.Show();
          
        }

        private void btnAraziEkle_Click(object sender, EventArgs e)
        {
            KullaniciAraziEkle arazi = new KullaniciAraziEkle();
            arazi.Show();
          
        }

        private void btnIlanGoster_Click(object sender, EventArgs e)
        {
            KullaniciIlanlariGoster goster = new KullaniciIlanlariGoster();
            goster.Show();
            this.Hide();


        }

        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = KullaniciGiris.kullaniciadi;
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Oturumu Kapatmak İstediğinize Emin Misiniz ?", "", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                KullaniciGiris giris = new KullaniciGiris();
                giris.Show();
                this.Hide();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Kayıt Silmek İstediğinize Emin Misiniz ?", "", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                SqlBolum sql = new SqlBolum();
                bool silindiMi=sql.KullaniciSil(lblKullanici.Text);
                if(silindiMi==true)
                {
                    MessageBox.Show("KAYDINIZ BAŞARIYLA SİLİNDİ.GİRİŞ EKRANINA YÖNLENDİRİLİYORSUNUZ !");
                    KullaniciGiris giris = new KullaniciGiris();
                    giris.Show();
                    this.Hide();
                }
            }
        }
    }
}
