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
    public partial class MailDogrulama : Form
    {
        public MailDogrulama()
        {
            InitializeComponent();
        }
        int sayac = 2;
        int kodTekrari = 0;
       
        private void btnDogrulama_Click(object sender, EventArgs e)
        {
            
            int uretilen = KullaniciEkle.gonderilecekKod;
            string kul_adi = KullaniciEkle.KullaniciAdiGonder;
            string kul_sifre = KullaniciEkle.KullaniciSifreGonder;
            string kul_mail = KullaniciEkle.KullaniciMailGonder;



            if (txtGirilen.Text==uretilen.ToString())

            {
              
                SqlBolum Kaydet = new SqlBolum();
                string k_adi = kul_adi;
                string sifre = kul_sifre;
                string mail = kul_mail;
               bool kontrol= Kaydet.KayitEkle(k_adi, sifre, mail);
                if (kontrol == true)
                {
                    MessageBox.Show("BAŞARILI ! LÜTFEN GİRİŞ YAPINIZ !");

                    this.Close();
                     KullaniciEkle cik = new KullaniciEkle();
                     cik.Close();
                 
                    
                }
                else MessageBox.Show("KULLANICI ADI KULLANILMIŞTIR !");
               


            }
            else
            {
                MessageBox.Show("GİRDİĞİNİZ KOD HATALI ! \n \n KALAN DENEME SAYISI = "+sayac);
                sayac = sayac - 1;
                if(sayac==-1)
                {
                    timer1.Stop();
                    MessageBox.Show("Güvenlik nedeniyle ANA EKRANA yönlendiriliyorsunuz !");
                    KullaniciGiris giris = new KullaniciGiris();
                    giris.Show();
                    this.Hide();
                }

            }
        }
        
        private void MailDogrulama_Load(object sender, EventArgs e)
        {
       
            timer1.Enabled = true;
            
        }
        int saniye = 60;
        int dakika = 3;

        private void timer1_Tick(object sender, EventArgs e) // BU KOD SATIRLARINDA DOĞRULAMA MAİLİ GÖNDERİLDİKTEN SONRA GÜVENLİK AMAÇLI SÜRE İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        {
            timer1.Interval = 1000;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
           
                txtGirilen.Visible = false;
                btnDogrulama.Visible = false;
                btnTekrar.Visible = true;
                lblUyari.Text = "Belirtilen sürede kodu girmediniz !";
                lblUyari.ForeColor = Color.Red;
            }
            if(lblSaniye.Text=="10"&&lblDakika.Text=="0")
            {
                lblSaniye.BackColor = Color.Red;
            }
        }

        private void btnTekrar_Click(object sender, EventArgs e)// BU KOD SATIRLARINDA YANLIŞ GİRİLEN VEYA VERİLEN SÜRE İÇERİNDE GİRİLMEYEN KODU TEKRAR GÖNDERME İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        {
            kodTekrari++;  
            if(kodTekrari==3)
            {
                Application.Exit();
            }
            else
            {
                KullaniciEkle ekle = new KullaniciEkle();
                string deger = KullaniciEkle.KullaniciMailGonder;
                int kod = KullaniciEkle.gonderilecekKod;
                

                MailGonder gonder = new MailGonder();
                gonder.DogrulamaGonder(deger, kod);

                MailDogrulama gir = new MailDogrulama();
                gir.Show();
                this.Hide();
                   
            }
           
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
