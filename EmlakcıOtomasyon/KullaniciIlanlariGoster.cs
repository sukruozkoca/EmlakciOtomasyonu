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
    public partial class KullaniciIlanlariGoster : Form
    {
        
        public KullaniciIlanlariGoster()
        {
            InitializeComponent();
        }

        private void KullaniciIlanlariGoster_Load(object sender, EventArgs e)
        {
            string ad = KullaniciGiris.kullaniciadi;  //BU KOD SATIRINDA ID YERİNE KULLANICI ADINI KULLANDIĞIMIZ İÇİN GİRİŞ KISMINDAKİ TANIMLADIĞIMIZ KULLANICI ADI DEĞİŞKENİNİ ÇAĞIRDIK.
            this.Width= 746;
            this.Height = 186;

        }
        private void arsaclick(object sender, EventArgs e) //BU KOD SATIRLARIINDA EKLEMİŞ OLDUĞUMUZ ARAZİ İLANLARINI LİSTELEMEKTEYİZ.
        {
            btnKonutGuncelle.Visible = false;
            btnAraziGuncelle.Visible = true;
            btnDaireSil.Visible = false;
            btnAraziSil.Visible = true;
            string ad = KullaniciGiris.kullaniciadi;
            SqlBolum bolumm2 = new SqlBolum();
            dataAraziGoster.DataSource = bolumm2.ListDatas2(ad).Tables[0];
            dataAraziGoster.Visible = true;
            Color renk = button3.BackColor;
            button1.BackColor = Color.Green;
            button2.BackColor = renk;
       
            this.Width = 761;
            this.Height = 672;
            
            dataDaireGoster.Visible = false;
        }

        private void daireclick(object sender, EventArgs e)  //BU KOD SATIRLARINDA EKLEMİŞ OLDUĞUMUZ KONUT İLANLARINI LİSTELEMEKTEYİZ.
        {
            btnKonutGuncelle.Visible = true;
            btnAraziGuncelle.Visible = false;
            btnDaireSil.Visible = true;
            btnAraziSil.Visible = false;
            string ad = KullaniciGiris.kullaniciadi;
            SqlBolum bolumm = new SqlBolum();

            dataDaireGoster.DataSource = bolumm.ListDatas(ad).Tables[0];
            dataDaireGoster.Visible = true;
            Color renk = button3.BackColor;
            button2.BackColor = Color.Green;
            button1.BackColor = renk;
            this.Width = 761;
            this.Height = 672;
            dataAraziGoster.Visible = false;

          
        }



      
        private void dataDaireGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)  //BU KOD SATIRLARINDA İLANIMIZA EKLEDİĞİMİZ RESİMİ PİCTUREBOX A AKTARIYORUZ VE GÜNCELLEME AŞAMASINA HAZIRLIK İÇİN VERİLERİ TUTUYORUZ.
        {
            
            int rowindex = dataDaireGoster.CurrentCell.RowIndex;
            labelControl1.Text = dataDaireGoster.Rows[rowindex].Cells[9].Value.ToString();
            pctDaireResim.Image = Image.FromFile(labelControl1.Text);


            ilanturu = dataDaireGoster.CurrentRow.Cells[0].Value.ToString();
            il = dataDaireGoster.CurrentRow.Cells[1].Value.ToString();
            ilce = dataDaireGoster.CurrentRow.Cells[2].Value.ToString();
            adres = dataDaireGoster.CurrentRow.Cells[3].Value.ToString();
            katno = dataDaireGoster.CurrentRow.Cells[4].Value.ToString();
            toplamalan = dataDaireGoster.CurrentRow.Cells[5].Value.ToString();
            odasayisi = dataDaireGoster.CurrentRow.Cells[6].Value.ToString();
            binayili = dataDaireGoster.CurrentRow.Cells[7].Value.ToString();
            fiyat = dataDaireGoster.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataAraziGoster_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//BU KOD SATIRLARINDA İLANIMIZA EKLEDİĞİMİZ RESİMİ PİCTUREBOX A AKTARIYORUZ VE GÜNCELLEME AŞAMASINA HAZIRLIK İÇİN VERİLERİ TUTUYORUZ.
        {
            int rowindex = dataAraziGoster.CurrentCell.RowIndex;
            labelControl1.Text = dataAraziGoster.Rows[rowindex].Cells[8].Value.ToString();
            pctDaireResim.Image = Image.FromFile(labelControl1.Text);

            imar= dataAraziGoster.CurrentRow.Cells[0].Value.ToString();
            il = dataAraziGoster.CurrentRow.Cells[1].Value.ToString();
            ilce = dataAraziGoster.CurrentRow.Cells[2].Value.ToString();
            alan= dataAraziGoster.CurrentRow.Cells[3].Value.ToString();
            ada = dataAraziGoster.CurrentRow.Cells[4].Value.ToString();
            parsel = dataAraziGoster.CurrentRow.Cells[5].Value.ToString();
            durum= dataAraziGoster.CurrentRow.Cells[6].Value.ToString();
            fiyat= dataAraziGoster.CurrentRow.Cells[7].Value.ToString();
        }
        private void btnDaireSil_Click(object sender, EventArgs e)// BU KOD SATIRLARINDA EKLEDİĞİMİZ KONUT İLANI SİLME İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        {
            string adres = dataDaireGoster.CurrentRow.Cells[3].Value.ToString();
            SqlBolum bolum = new SqlBolum();
            bool dogrulama = bolum.DaireKayitSilindiMi(adres);
            if (dogrulama == true)
            {
                MessageBox.Show("KAYIT SİLİNDİ");
                string ad = KullaniciGiris.kullaniciadi;
                SqlBolum bolumm2 = new SqlBolum();
                dataDaireGoster.DataSource = bolumm2.ListDatas2(ad).Tables[0];
            }
            else
            {
                MessageBox.Show("HATA!");
            }
        }

        private void btnAraziSil_Click(object sender, EventArgs e)  // BU KOD SATIRLARINDA EKLEDİĞİMİZ ARAZİ İLANI SİLME İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        {
            bool dogrulama = false;
            int parsel = Convert.ToInt32(dataAraziGoster.CurrentRow.Cells[5].Value);
          
            SqlBolum bolum = new SqlBolum();
            dogrulama = bolum.AraziKayitSilindiMi(parsel);
            if (dogrulama == true)
            {
                MessageBox.Show("KAYIT SİLİNDİ");
                string ad = KullaniciGiris.kullaniciadi;
                SqlBolum bolumm2 = new SqlBolum();
                dataAraziGoster.DataSource = bolumm2.ListDatas2(ad).Tables[0];
            }
            else
            {
                MessageBox.Show("HATA!");
            }
        }

        private void btnKonutGuncelle_Click(object sender, EventArgs e) //BU KOD SATIRLARINDA EKLEMİŞ OLDUĞUMUZ KONUT İLANINI GÜNCELLEMEK İÇİN GÜNCELLEME FORMUNA YÖNLENDİRME SAĞLIYORUZ.
        {
            KullaniciDaireGuncelle guncelle = new KullaniciDaireGuncelle();
            guncelle.Show();
          

        }
        public static string ilanturu;
        public static string il;
        public static string ilce;
        public static string adres;
        public static string katno;
        public static string toplamalan;
        public static string odasayisi;
        public static string binayili;
        public static string fiyat;

        public static string imar;
        public static string ada;
        public static string durum;
        public static string parsel;
        public static string alan;

        private void btnAraziGuncelle_Click(object sender, EventArgs e)   //BU KOD SATIRLARINDA EKLEMİŞ OLDUĞUMUZ ARAZİ İLANINI GÜNCELLEMEK İÇİN GÜNCELLEME FORMUNA YÖNLENDİRME SAĞLIYORUZ.
        {
            KullaniciAraziGuncelle guncelle = new KullaniciAraziGuncelle();
            guncelle.Show();
        }

      

        private void btnCikis_Click_1(object sender, EventArgs e) // BU KOD SATIRLARINDA BUTON VASITASIYLA ÇIKIŞ İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void btnLogout_Click(object sender, EventArgs e) // BU KOD SATIRLARINDA BUTON VASITASIYLA LOGİN PANELİNE YÖNLENDİRMEYİ SAĞLIYORUZ.
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

        private void btnBack_Click(object sender, EventArgs e)// BU KOD SATIRLARINDA BUTON VASITASIYLA PROJEDEN ÇIKIŞ İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        {
            KullaniciAnasayfa anasayfa = new KullaniciAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        public void btnYenile_Click(object sender, EventArgs e)
        {
            string ad = KullaniciGiris.kullaniciadi;
            SqlBolum bolumm2 = new SqlBolum();
            dataAraziGoster.DataSource = bolumm2.ListDatas2(ad).Tables[0];
            dataDaireGoster.DataSource = bolumm2.ListDatas(ad).Tables[0];

        }
    }
}
