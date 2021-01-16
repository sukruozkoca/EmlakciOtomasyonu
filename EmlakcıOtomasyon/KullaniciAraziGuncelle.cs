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
    public partial class KullaniciAraziGuncelle : Form
    {
        public KullaniciAraziGuncelle()
        {
            InitializeComponent();
        }
        string[] iller = { "İSTANBUL", "ANKARA", "İZMİR", "KONYA", "ÇORUM" };
        string[] istanbul = { "ADALAR", "ARNAVUTKÖY", "ATAŞEHİR", "AVCILAR", "BAĞCILAR", "BAHÇELİEVLER", "BAKIRKÖY", "BAŞAKŞEHİR", "BAYRAMPAŞA", "BEŞİKTAŞ", "BEYKOZ", "BEYLİKDÜZÜ", "BEYOĞLU", "BÜYÜKÇEKMECE", "ÇATALCA", "ÇEKMEKÖY", "EMİNÖNÜ", "ESENLER", "EYÜPSULTAN", "FATİH", "GAZİOSMANPAŞA", "GÜNGÖREN", "KADIKÖY", "KAĞITHANE", "KARTAL", "KÜÇÜKÇEKMECE", "MALTEPE", "PENDİK", "SANCAKTEPE", "SARIYER", "SİLİVRİ", "SULTANBEYLİ", "SULTANGAZİ", "ŞİLE", "ŞİŞLİ", "TUZLA", "ÜMRANİYE", "ÜSKÜDAR", "ZEYTİNBURNU" };
        string[] ankara = { "AKYURT", "ALTINDAĞ", "AYAŞ", "BALA", "BEYPAZARI", "ÇAMLIDERE", "ÇANKAYA", "ÇUBUK", "ELMADAĞ", "ETİMESGUT", "EVREN", "GÖLBAŞI", "GÜDÜL", "HAYMANA", "KAHRAMANKAZAN", "KALECİK", "KEÇİÖREN", "KIZILCAHAMAM", "MAMAK", "NALLIHAN", "POLATLI", "PURSAKLAR", "SİNCAN", "ŞEREFLİKOÇHİSAR", "YENİMAHALLE" };
        string[] izmir = { "ALİAĞA", "BALÇOVA", "BAYINDIR", "BAYRAKLI", "BERGAMA", "BEYDAĞ", "BORNOVA", "BUCA", "ÇEŞME", "ÇİĞLİ", "DİKİLİ", "FOÇA", "GAZİEMİR", "GÜZELBAHÇE", "KARABAĞLAR", "KARABURUN", "KARŞIYAKA", "KEMALPAŞA", "KINIK", "KİRAZ", "KONAK", "MENDERES", "MENEMEN", "NARLIDERE", "ÖDEMİŞ", "SEFERHİSAR", "SELÇUK", "TİRE", "TORBALI", "URLA" };
        string[] konya = { "AHIRLI", "AKÖREN", "AKŞEHİR", "ALTINEKİN", "BEYŞEHİR", "BOZKIR", "CİHANBEYLİ", "ÇELTİK", "ÇUMRA", "DERBENT", "DEREBUCAK", "DOĞANHİSAR", "EMİRGAZİ", "EREĞLİ", "GİNEYSINIR", "HADİM", "HALKAPINAR", "HÜYÜK", "ILGIN", "KADINHANI", "KARAPINAR", "KARATAY", "KULU", "MERAM", "SARAYÖNÜ", "SELÇUKLU", "SEYDİŞEHİR", "TAŞKENT", "TUZLUKÇU", "YALIHÜYÜK", "YUNAK" };
        string[] çorum = { "MERKEZ", "ALACA", "BAYAT", "BOĞAZKALE", "DODURGA", "İSKİLİP", "KARGI", "LAÇİN", "MECİTÖZÜ", "OĞUZLAR", "ORTAKÖY", "OSMANCIK", "SUNGURLU", "UĞURLUDAĞ" };

      

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIl.Text == "İSTANBUL")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(istanbul);
            }
            else if (cmbIl.Text == "ANKARA")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(ankara);
            }
            else if (cmbIl.Text == "İZMİR")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(izmir);
            }
            else if (cmbIl.Text == "KONYA")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(konya);
            }
            else if (cmbIl.Text == "ÇORUM")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(çorum);
            }
        }

        private void KullaniciAraziGuncelle_Load(object sender, EventArgs e)
        {
            cmbIl.Properties.Items.AddRange(iller);
            cmbImar.Text = KullaniciIlanlariGoster.imar;
            cmbIl.Text = KullaniciIlanlariGoster.il;
            cmbIlce.Text = KullaniciIlanlariGoster.ilce;
            txtAda.Text = KullaniciIlanlariGoster.ada;
            txtAlan.Text = KullaniciIlanlariGoster.alan;
            txtFiyat.Text = KullaniciIlanlariGoster.fiyat;
            txtParsel.Text = KullaniciIlanlariGoster.parsel;
            cmbTapu.Text = KullaniciIlanlariGoster.durum;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlBolum guncelleme = new SqlBolum();

            bool kayit = guncelleme.AraziUpdate(cmbImar.Text, cmbIl.Text, cmbIlce.Text, txtAlan.Text, txtAda.Text, txtParsel.Text, cmbTapu.Text, txtFiyat.Text);
            if (kayit == true)
            {
                MessageBox.Show("güncellendi");

            }
            else
            {
                MessageBox.Show("hata");

            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
