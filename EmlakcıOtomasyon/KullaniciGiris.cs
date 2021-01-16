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
    public partial class KullaniciGiris : Form
    {
       
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        
        private void KullaniciGiris_Load(object sender, EventArgs e)
        {
            chkSifre.Visible = false;
            txtSifre.Properties.PasswordChar = '*';
        }    
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void SifremiUnuttumClick(object sender, EventArgs e)
        {
            KullaniciSifreHatirlatma giris = new KullaniciSifreHatirlatma();
            giris.Show();
        }

        private void chkSifre_CheckedChanged(object sender, EventArgs e)  // BU KOD SATIRLARINDA GİRİŞ ŞİFRESİNİ GÜVENLİK AMAÇLI BİR CHECKBOX KULLANARAK İSTEĞE BAĞLI ŞİFRE GÖRÜNÜRLÜĞÜ SAĞLAMA İŞLEMİ GERÇEKLEŞTİRDİK.
        {
            if (chkSifre.Checked == true)
            {
                txtSifre.Properties.PasswordChar='\0';
            }
            else txtSifre.Properties.PasswordChar='*';

        }

     
        
        private void btnGiris_Click(object sender, EventArgs e) //BU KOD SATIRLARINDA GİRİLEN GİRİŞ BİLGİLERİ DOĞRULTUSUNDA SİSTEME GİRİŞ YAPMA VEYA YAPAMAMA İŞLEMİNİ GERÇEKLEŞTİRDİK.
        {
            SqlBolum nesne = new SqlBolum();
            string id = txtKullanici.Text;
            string sifre = txtSifre.Text;
            bool kullanici_mi = false;
            kullanici_mi=nesne.KayitKontrol(id, sifre);
            
            if(kullanici_mi==true)
            {
                sifre = txtSifre.Text;
                kullaniciadi = txtKullanici.Text;
                MessageBox.Show("GİRİŞ BAŞARILI");
                KullaniciAnasayfa AnasayfaGit = new KullaniciAnasayfa();
                AnasayfaGit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GİRİŞ BAŞARISIZ");
                txtKullanici.Text = "";
                txtSifre.Text = "";
            }
            
          
            Console.ReadLine();
        }

        private void txtSifre_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text != "")
            {
                
                chkSifre.Visible = true;
            }
            else
            {
              
                chkSifre.Visible = false;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KullaniciEkle Ekle = new KullaniciEkle();
            Ekle.Show();
        }
        public static string kullaniciadi;
        public static string sifre;

    }

}
