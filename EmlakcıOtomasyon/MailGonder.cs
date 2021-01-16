using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EmlakcıOtomasyon
{
    class MailGonder
    {
        MailMessage mailgonder = new MailMessage();
        SmtpClient sc = new SmtpClient();
        public void DogrulamaGonder(string mail, int kod)
        {
            
           
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("sukruozkoca5@hotmail.com", "Sukru1218");
            mailgonder.To.Add(mail);
            mailgonder.From = new MailAddress("sukruozkoca5@hotmail.com");
            mailgonder.Subject = "KAYIT DOĞRULAMA İŞLEMİ";
            mailgonder.Body = "DOĞRULAMA KODUNUZ = " + kod.ToString();
            sc.Send(mailgonder);
        }
        public void KullaniciHatirlatma(string mail,string bilgi)
        {
            MailMessage mailgonder = new MailMessage();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.live.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("sukruozkoca5@hotmail.com", "Sukru1218");
            mailgonder.To.Add(mail);
            mailgonder.From = new MailAddress("sukruozkoca5@hotmail.com");
            mailgonder.Subject = "KAYIT DOĞRULAMA İŞLEMİ";
            mailgonder.Body = "KULLANICI ADI VE ŞİFRENİZ  = " + bilgi;
            sc.Send(mailgonder);
        }
    }
}
