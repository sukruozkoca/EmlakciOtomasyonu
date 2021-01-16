using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace EmlakcıOtomasyon
{
     
    class SqlBolum
    {
        static string adres = System.IO.File.ReadAllText(@"C:\test.txt");
        SqlConnection conn = new SqlConnection(adres);
       //  SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CKCFO7U\\SQLEXPRESS;Initial Catalog=EmlakOtomasyon;Integrated Security=TRUE");
         
        public bool KayitKontrol(string k_adi, string sifre)   //BU KOD SATIRLARINDA KULLANICI ADI DAHA ÖNCEDEN KULLANILMIŞ MI ONU TEST EDİYORUZ.DESKTOP-CKCFO7U\\SQLEXPRESS
        {
            bool kayitli_mi = false;
            conn.Open();
            SqlCommand Kontrol = new SqlCommand($"Select * from KullaniciVerileri Where KullaniciAdi='{k_adi}' and KullaniciSifre='{sifre}'", conn);

        
            SqlDataReader dr = Kontrol.ExecuteReader();
         
            while (dr.Read())
            {
                if (k_adi == dr["KullaniciAdi"].ToString() && sifre==dr["KullaniciSifre"].ToString())
                {
                    kayitli_mi = true;
                }
                else
                {
                    kayitli_mi = false;
                }
            }
            dr.Close();
            conn.Close();
            return kayitli_mi;



           // SELECT* FROM tblUser where usr = '" + txtUser.Text + "' AND pwd = '" + txtPass.Text + "'"
        }

       
        public bool KayitEkle(string k_adi,string sifre,string e_posta)  // BU KOD SATIRLARINDA KULLANICI KAYDINI GERÇEKLEŞTİRİYORUZ
        {
            conn.Open();
            bool KayitEdildi_Mi = false;
            SqlCommand Kayit = new SqlCommand("Insert Into KullaniciVerileri (KullaniciAdi,KullaniciSifre,KullaniciMail) values (@p1,@p2,@p3)",conn);
            try
            {
                Kayit.Parameters.AddWithValue("@p1", k_adi);
                Kayit.Parameters.AddWithValue("@p2", sifre);
                Kayit.Parameters.AddWithValue("@p3", e_posta);
                Kayit.ExecuteNonQuery();
                KayitEdildi_Mi = true;
            }
            catch(Exception e)
            {
                KayitEdildi_Mi = false;
            }
            conn.Close();
            return KayitEdildi_Mi;

        }
       public bool KayitHatirlatma(string mailAdresi)   
        {
            string mail = mailAdresi;
            conn.Open();
            bool KayitHatirlat= false;
            SqlCommand Kontrol = new SqlCommand($"Select KullaniciMail from KullaniciVerileri Where KullaniciMail='{mailAdresi}'", conn);
            SqlDataReader dr = Kontrol.ExecuteReader();
           

            while (dr.Read())
            {
                if (mailAdresi == dr["KullaniciMail"].ToString())
                {

                  
                        KayitHatirlat = true;
                    
                   
                    
                   
                }
                else
                {
                    KayitHatirlat = false;
                }
                
            }
            dr.Close();
          
            return KayitHatirlat;
        }
        public string gonder(string mailAdresi) //// BU KOD SATIRLARINDA KULLANICI BİLGİLERİNİ HATIRLATMAK İÇİN MAİL ADRESİNE GİRİŞ BİLGİLERİNİ GÖNDERİYORUZ.
        {
            conn.Open();
            SqlCommand kontroll = new SqlCommand ($"SELECT KullaniciAdi,KullaniciSifre FROM KullaniciVerileri WHERE KullaniciMail='{mailAdresi}'", conn);
            SqlDataReader dr = kontroll.ExecuteReader();
            string k_adi, sifre, birlestir="";
            while(dr.Read())
            {
                k_adi=dr[0].ToString();
                sifre = dr[1].ToString();
                birlestir = k_adi + " " + sifre;
            }
            conn.Close();
            return birlestir;
        }

        //BU KOD SATIRLARINDA UYGULAMAMIZA KONUT İLANI EKLEME İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        public bool IlanKayitEkle(string kullanicikayit,string ilantürü,string il,string ilce,string adres,string katno,string alan,string odasayisi,string binayili,string fiyat,string foto)
        {
            conn.Open();
            bool ilaneklendiMi = false;

            SqlCommand ilanekle = new SqlCommand("insert into KullaniciKayitEkleme (KullaniciAdi,IlanTuru,IlanIl,IlanIlce,IlanAdres,IlanKatNo,IlanToplamAlan,IlanOdaSayisi,IlanBinaYili,IlanFiyat,IlanImage) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", conn);

            try
            {
                ilanekle.Parameters.AddWithValue("@p1", kullanicikayit);
                ilanekle.Parameters.AddWithValue("@p2", ilantürü);
                ilanekle.Parameters.AddWithValue("@p3", il);
                ilanekle.Parameters.AddWithValue("@p4", ilce);
                ilanekle.Parameters.AddWithValue("@p5", adres);
                ilanekle.Parameters.AddWithValue("@p6", katno);
                ilanekle.Parameters.AddWithValue("@p7", alan);
                ilanekle.Parameters.AddWithValue("@p8", odasayisi);
                ilanekle.Parameters.AddWithValue("@p9", binayili);
                ilanekle.Parameters.AddWithValue("@p10", fiyat);
                ilanekle.Parameters.AddWithValue("@p11", SqlDbType.Image).Value=foto;
                ilanekle.ExecuteNonQuery();
                ilaneklendiMi = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ilaneklendiMi = false;
            } 
            conn.Close();
            return ilaneklendiMi;

        }
        public DataSet ListDatas(string kullaniciadi) // BU KOD SATIRLARINDA KULLANICI ADINA GÖRE İLANDAKİ KONUT VERİLERİNİ TUTAR
        {
            conn.Open();
            string query = $"SELECT IlanTuru, IlanIl,IlanIlce,IlanAdres,IlanKatNo,IlanToplamAlan,IlanOdaSayisi,IlanBinaYili,IlanFiyat,IlanImage  FROM KullaniciKayitEkleme where KullaniciAdi='{kullaniciadi}'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
            
        }
       public DataSet ListDatas2(string kullaniciadi)  // BU KOD SATIRLARINDA KULLANICI ADINA GÖRE İLANDAKİ ARAZİ VERİLERİNİ TUTAR
        {
            conn.Open();
            string query = $"SELECT ImarDurumu, IlanIl,IlanIlce,Alan,AdaNo,ParselNo,TapuDurumu,Fiyat,IlanFoto FROM KullaniciAraziKayit where KullaniciAdi='{kullaniciadi}'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        //BU KOD SATIRLARINDA UYGULAMAMIZA ARAZİ KATEGORİSİNDE İLAN EKLEME İŞLEMİNİ GERÇEKLEŞTİRİYORUZ.
        public bool IlanAraziKayitEkle(string kullanicikayit, string ilanimar, string il, string ilce, string alan, string ada, string parsel, string tapu, string fiyat,string foto)
        {
            conn.Open();
            bool ArazieklendiMi = false;
            string sql = "insert into KullaniciAraziKayit (KullaniciAdi,ImarDurumu,IlanIl,IlanIlce,Alan,AdaNo,ParselNo,TapuDurumu,Fiyat,IlanFoto) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            SqlCommand araziekle = new SqlCommand(sql, conn);

            try
            {
                araziekle.Parameters.AddWithValue("@p1", kullanicikayit);
                araziekle.Parameters.AddWithValue("@p2", ilanimar);
                araziekle.Parameters.AddWithValue("@p3", il);
                araziekle.Parameters.AddWithValue("@p4", ilce);
                araziekle.Parameters.AddWithValue("@p5", alan);
                araziekle.Parameters.AddWithValue("@p6", ada);
                araziekle.Parameters.AddWithValue("@p7", parsel);
                araziekle.Parameters.AddWithValue("@p8", tapu);
                araziekle.Parameters.AddWithValue("@p9", fiyat);             
                araziekle.Parameters.AddWithValue("@p10", SqlDbType.Image).Value = foto;
                araziekle.ExecuteNonQuery();
                ArazieklendiMi = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                ArazieklendiMi = false;
            }
            conn.Close();
            return ArazieklendiMi;
        }
        public bool DaireKayitSilindiMi(string adres)  // BU KOD SATIRLARINDA EKLEDİĞİMİZ KONUTLARIN İÇİNDEN SEÇTİĞİMİZİ SİLME İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        {
            bool kayitSil = false;
            conn.Open();
            string sql = "DELETE FROM KullaniciKayitEkleme WHERE IlanAdres=@p1";
            SqlCommand komut = new SqlCommand(sql, conn);
            try
            {
                komut.Parameters.AddWithValue("@p1", adres);
                komut.ExecuteNonQuery();
                kayitSil = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                kayitSil = false;
            }
            conn.Close();



            return kayitSil;
        }
        public bool AraziKayitSilindiMi(int parsel)  // BU KOD SATIRLARINDA EKLEDİĞİMİZ ARAZİLERİN İÇİNDEN SEÇTİĞİMİZİ SİLME İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        {
            bool kayitSil = false;
            conn.Open();
            string sql = "DELETE FROM KullaniciAraziKayit WHERE ParselNo=@p1";
            SqlCommand komut = new SqlCommand(sql, conn);
            try
            {
                komut.Parameters.AddWithValue("@p1", parsel.ToString());
                komut.ExecuteNonQuery();
                kayitSil = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                kayitSil = false;
            }
            conn.Close();



            return kayitSil;
        }

        //BU KOD SATIRLARINDA EKLEMİŞ OLDUĞUMUZ HERHANGİ BİR KONUT İLANI ÜZERİNDE BİLGİ GÜNCELLEŞTİRME İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        public bool KonutUpdate(string ilantürü,string il,string ilce,string adres,string katno,string alan,string oda,string yil,string yasi,string fiyati)
        {
            bool guncellendiMi = false ;
            conn.Open();

            string sql = "UPDATE KullaniciKayitEkleme SET Ilanturu=@tur,IlanIl=@il,IlanIlce=@ilce,IlanAdres=@adres,IlanKatNo=@katno,IlanToplamAlan=@alan,IlanOdaSayisi=@oda,IlanBinaYili=@bina,IlanFiyat=@fiyat WHERE IlanAdres=@ilanid";
            SqlCommand komut = new SqlCommand(sql, conn);
            string id = KullaniciIlanlariGoster.adres;
            try
            {
                komut.Parameters.AddWithValue("@tur", ilantürü);
                komut.Parameters.AddWithValue("@il", il);
                komut.Parameters.AddWithValue("@ilce", ilce);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@katno", katno);
                komut.Parameters.AddWithValue("@alan", alan);
                komut.Parameters.AddWithValue("@oda", oda);
                komut.Parameters.AddWithValue("@bina", yasi);
                komut.Parameters.AddWithValue("@fiyat", fiyati);
                komut.Parameters.AddWithValue("@ilanid", id);
                komut.ExecuteNonQuery();
                guncellendiMi = true;
            }


             
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                guncellendiMi = false;
            }
            return guncellendiMi;


        }


        //BU KOD SATIRLARINDA EKLEMİŞ OLDUĞUMUZ HERHANGİ BİR KONUT İLANI ÜZERİNDE BİLGİ GÜNCELLEŞTİRME İŞLEMİ GERÇEKLEŞTİRİYORUZ.
        public bool AraziUpdate(string imardurumu, string il, string ilce, string alan, string ada, string parsel, string durum, string fiyat)
        {
            bool guncellendiMi = false;
            conn.Open();

            string sql = "UPDATE KullaniciAraziKayit SET ImarDurumu=@durum,IlanIl=@il,IlanIlce=@ilce,Alan=@alan,AdaNo=@ada,ParselNo=@parsel,TapuDurumu=@tapudurum,Fiyat=@fiyat WHERE ParselNo=@ilanid";
            SqlCommand komut = new SqlCommand(sql, conn);
            string id = KullaniciIlanlariGoster.parsel;
            try
            {
                komut.Parameters.AddWithValue("@durum", imardurumu);
                komut.Parameters.AddWithValue("@il", il);
                komut.Parameters.AddWithValue("@ilce", ilce);
                komut.Parameters.AddWithValue("@alan", alan);
                komut.Parameters.AddWithValue("@ada", ada);
                komut.Parameters.AddWithValue("@parsel", parsel);
                komut.Parameters.AddWithValue("@tapudurum", durum);
                komut.Parameters.AddWithValue("@fiyat", fiyat);
                
                komut.Parameters.AddWithValue("@ilanid", id);
                komut.ExecuteNonQuery();
                guncellendiMi = true;
            }



            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                guncellendiMi = false;
            }
            return guncellendiMi;


        }
        public bool KullaniciSil(string kullaniciadi)
        {
            bool sil = false;
            conn.Open();
            string kullanicisil = "DELETE FROM KullaniciVerileri WHERE KullaniciAdi=@p1";
            string arazisil= "DELETE FROM KullaniciAraziKayit WHERE KullaniciAdi=@p2";
            string konutsil= "DELETE FROM KullaniciKayitEkleme WHERE KullaniciAdi=@p3";

            SqlCommand komut = new SqlCommand(kullanicisil, conn);
            SqlCommand komut2 = new SqlCommand(arazisil, conn);
            SqlCommand komut3 = new SqlCommand(konutsil, conn);
            try
            {
                komut.Parameters.AddWithValue("@p1", kullaniciadi);
                komut2.Parameters.AddWithValue("@p2", kullaniciadi);
                komut3.Parameters.AddWithValue("@p3", kullaniciadi);
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut3.ExecuteNonQuery();
                sil = true;

            }
            catch
            {
                MessageBox.Show("HATA");
                sil = false;
            }
            return sil;
        }




        

    }
}
