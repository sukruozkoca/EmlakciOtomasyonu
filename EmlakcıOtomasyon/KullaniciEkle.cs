using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;


namespace EmlakcıOtomasyon
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        static bool EmailKontrol(string email)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(email);
        }
        public void btnKaydet_Click(object sender, EventArgs e)//public yaptım hata verebilir
        {
            bool MailKontrol = EmailKontrol(txtMail.Text);

            if(MailKontrol==true)
            {
                    SqlBolum bolum = new SqlBolum();
                    bool kontroll = bolum.KayitKontrol(txtKullanici.Text,txtSifre.Text);

                    if(kontroll==true)
                    {
                         MessageBox.Show("hoop hemşerim!");
                    }

                    else
                    {
                        int kod = DogrulamaKodu();
                        gonderilecekKod = kod;
                        KullaniciAdiGonder = txtKullanici.Text;
                        KullaniciSifreGonder = txtSifre.Text;
                        KullaniciMailGonder = txtMail.Text;
                        MailGonder dogrulama = new MailGonder();
                        dogrulama.DogrulamaGonder(txtMail.Text, kod);
                        MailDogrulama dogrula = new MailDogrulama();
                        dogrula.Show();
                        MessageBox.Show("Dikkat ! Doğrulama kodunuz Gereksiz bölümüne gitmiş olabilir.");
                    }       
                    
            }
            else
            {
                MessageBox.Show("MAİL ADRESİNİZ HATALI ! LÜTFEN KONTROL EDİNİZ.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?","", MessageBoxButtons.YesNo);
            if(cikis==DialogResult.Yes)
            {
                Dispose();
            }

           
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }
       
        public int DogrulamaKodu()
        {
            Random rnd = new Random();
            int sayigonder = rnd.Next(999, 10000);
            return sayigonder;
        }
        public static int gonderilecekKod;
        public static string KullaniciAdiGonder;
        public static string KullaniciSifreGonder;
        public static string KullaniciMailGonder;
        public static string mail;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
