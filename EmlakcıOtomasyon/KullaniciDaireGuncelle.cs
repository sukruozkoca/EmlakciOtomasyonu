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
    public partial class KullaniciDaireGuncelle : Form
    {
        public KullaniciDaireGuncelle()
        {
            InitializeComponent();
        }
        string[] iller = { "İSTANBUL", "ANKARA", "İZMİR", "KONYA", "ÇORUM" };
        string[] istanbul = { "ADALAR", "ARNAVUTKÖY", "ATAŞEHİR", "AVCILAR", "BAĞCILAR", "BAHÇELİEVLER", "BAKIRKÖY", "BAŞAKŞEHİR", "BAYRAMPAŞA", "BEŞİKTAŞ", "BEYKOZ", "BEYLİKDÜZÜ", "BEYOĞLU", "BÜYÜKÇEKMECE", "ÇATALCA", "ÇEKMEKÖY", "EMİNÖNÜ", "ESENLER", "EYÜPSULTAN", "FATİH", "GAZİOSMANPAŞA", "GÜNGÖREN", "KADIKÖY", "KAĞITHANE", "KARTAL", "KÜÇÜKÇEKMECE", "MALTEPE", "PENDİK", "SANCAKTEPE", "SARIYER", "SİLİVRİ", "SULTANBEYLİ", "SULTANGAZİ", "ŞİLE", "ŞİŞLİ", "TUZLA", "ÜMRANİYE", "ÜSKÜDAR", "ZEYTİNBURNU" };
        string[] ankara = { "AKYURT", "ALTINDAĞ", "AYAŞ", "BALA", "BEYPAZARI", "ÇAMLIDERE", "ÇANKAYA", "ÇUBUK", "ELMADAĞ", "ETİMESGUT", "EVREN", "GÖLBAŞI", "GÜDÜL", "HAYMANA", "KAHRAMANKAZAN", "KALECİK", "KEÇİÖREN", "KIZILCAHAMAM", "MAMAK", "NALLIHAN", "POLATLI", "PURSAKLAR", "SİNCAN", "ŞEREFLİKOÇHİSAR", "YENİMAHALLE" };
        string[] izmir = { "ALİAĞA", "BALÇOVA", "BAYINDIR", "BAYRAKLI", "BERGAMA", "BEYDAĞ", "BORNOVA", "BUCA", "ÇEŞME", "ÇİĞLİ", "DİKİLİ", "FOÇA", "GAZİEMİR", "GÜZELBAHÇE", "KARABAĞLAR", "KARABURUN", "KARŞIYAKA", "KEMALPAŞA", "KINIK", "KİRAZ", "KONAK", "MENDERES", "MENEMEN", "NARLIDERE", "ÖDEMİŞ", "SEFERHİSAR", "SELÇUK", "TİRE", "TORBALI", "URLA" };
        string[] konya = { "AHIRLI", "AKÖREN", "AKŞEHİR", "ALTINEKİN", "BEYŞEHİR", "BOZKIR", "CİHANBEYLİ", "ÇELTİK", "ÇUMRA", "DERBENT", "DEREBUCAK", "DOĞANHİSAR", "EMİRGAZİ", "EREĞLİ", "GİNEYSINIR", "HADİM", "HALKAPINAR", "HÜYÜK", "ILGIN", "KADINHANI", "KARAPINAR", "KARATAY", "KULU", "MERAM", "SARAYÖNÜ", "SELÇUKLU", "SEYDİŞEHİR", "TAŞKENT", "TUZLUKÇU", "YALIHÜYÜK", "YUNAK" };
        string[] çorum = { "MERKEZ", "ALACA", "BAYAT", "BOĞAZKALE", "DODURGA", "İSKİLİP", "KARGI", "LAÇİN", "MECİTÖZÜ", "OĞUZLAR", "ORTAKÖY", "OSMANCIK", "SUNGURLU", "UĞURLUDAĞ" };

        private void KullaniciDaireGuncelle_Load(object sender, EventArgs e)
        {
           
            cmbIlSec.Properties.Items.AddRange(iller);
            cmbIlSec.Text = KullaniciIlanlariGoster.il;
            cmbIlanTuru.Text = KullaniciIlanlariGoster.ilanturu;
            cmbIlce.Text = KullaniciIlanlariGoster.ilce;
            txtAdres.Text = KullaniciIlanlariGoster.adres;
            txtAlan.Text = KullaniciIlanlariGoster.toplamalan;
            txtBinaYili.Text = KullaniciIlanlariGoster.binayili;
            txtFiyati.Text = KullaniciIlanlariGoster.fiyat;
            txtKatNo.Text = KullaniciIlanlariGoster.katno;
            txtOdaSayisi.Text = KullaniciIlanlariGoster.odasayisi;
            
        }

        private void cmbIlSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIlSec.Text == "İSTANBUL")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(istanbul);
            }
            else if (cmbIlSec.Text == "ANKARA")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(ankara);
            }
            else if (cmbIlSec.Text == "İZMİR")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(izmir);
            }
            else if (cmbIlSec.Text == "KONYA")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(konya);
            }
            else if (cmbIlSec.Text == "ÇORUM")
            {
                cmbIlce.Text = "";
                cmbIlce.Properties.Items.Clear();
                cmbIlce.Properties.Items.AddRange(çorum);
            }
        }


     
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlBolum guncelleme = new SqlBolum();
            
            bool kayit = guncelleme.KonutUpdate(cmbIlanTuru.Text, cmbIlSec.Text, cmbIlce.Text, txtAdres.Text, txtKatNo.Text, txtAlan.Text, txtOdaSayisi.Text, txtBinaYili.Text, txtBinaYili.Text, txtFiyati.Text);
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
