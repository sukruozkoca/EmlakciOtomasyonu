using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EmlakcıOtomasyon
{
    public partial class KullaniciSifreHatirlatma : Form
    {
        public KullaniciSifreHatirlatma()
        {
            InitializeComponent();
        }

       
      
        public void btnGonder_Click_1(object sender, EventArgs e) //BU KOD SATIRLARINDA BİLGİLERİNİ UNUTAN KULLANICIMIZA MAİL YOLUYLA HATIRLATMA İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        {
            SqlBolum mailgonder = new SqlBolum();
            string mailadresi = txtMail.Text;
            bool varMi = mailgonder.KayitHatirlatma(mailadresi);
            if (varMi == true)
            {
                SqlBolum getir = new SqlBolum();
                string bilgi= getir.gonder(txtMail.Text);
                MailGonder hatirlatma = new MailGonder();
                hatirlatma.KullaniciHatirlatma(mailadresi, bilgi);

                MessageBox.Show("kullanıcı bilgileri gönderildi");
                Dispose();
            }
            else MessageBox.Show("kullanıcı mevcut değil");
        }

        private void KullaniciSifreHatirlatma_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
