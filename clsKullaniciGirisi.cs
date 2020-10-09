using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestCoz 
{ 
    public class clsKullaniciGirisi
    {

            Sqlbaglantisi bgl = new Sqlbaglantisi();
        

            private String sifre;
            public int girisDurum;

        public String[] KullaniciBilgi = new String[5];


        public void kimlikDogrulama(string isim,String pass,string tur) {

                girisDurum = 0;
                bgl.baglanti();
                SqlCommand komut1 = new SqlCommand("SELECT sifre FROM tblKullanici where kullaniciAdi=@p1 AND KullaniciTuru=@p2 ", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", isim.ToString());
                komut1.Parameters.AddWithValue("@p2", tur.ToString()); 
                SqlDataReader dr1 = komut1.ExecuteReader();
                while (dr1.Read()) {

                    sifre = dr1[0].ToString();
                
                }
                if (sifre == pass) {

                    girisDurum = 1;
                    
                }
            }       
        public void KullaniciBilgileri(String KullaniciAdi)
        {
            SqlCommand komut2 = new SqlCommand("SELECT adi,soyadi,eposta,telefon,kullaniciid FROM tblKullanici WHERE kullaniciAdi=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", KullaniciAdi);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                KullaniciBilgi[0] = dr2[0].ToString();
                KullaniciBilgi[1] = dr2[1].ToString();
                KullaniciBilgi[2] = dr2[2].ToString();
                KullaniciBilgi[3] = dr2[3].ToString();
                KullaniciBilgi[4] = dr2[4].ToString();

            }

        }
        public string kullaniciBilgileriYaz(string kullaniciAdi, Label lblAd, Label lblEposta, Label lblTel)
        {
            KullaniciBilgileri(kullaniciAdi);
            lblAd.Text = KullaniciBilgi[0] + " " + KullaniciBilgi[1];
            lblEposta.Text = KullaniciBilgi[2];
            lblTel.Text = KullaniciBilgi[3];
            return KullaniciBilgi[4];
        }






    }
}
