using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestCoz
{
    public class clsSoruGetir
    {
        public String[] Soru = new string[8];
        public int[,] ogrencidogruYanlislar = new int[5,2];
        public int[] sorusayisi = new int[5];
        int toplamSoruSayisi = 0;
        int enBüyük=0;
        public int dogruSik;

        Sqlbaglantisi bgl = new Sqlbaglantisi();


        public void soruSayisiverileri(String kullaniciid) {

            SqlCommand komut1 = new SqlCommand("SELECT SUM(konuADogru),SUM(konuAYanlis),SUM(konuBDogru),SUM(konuBYanlis),SUM(konuCDogru),SUM(konuCYanlis),SUM(konuDDogru),SUM(konuDYanlis),SUM(konuEDogru),SUM(konuEYanlis) FROM tblistatistik WHERE ogrenciid=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", kullaniciid);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                //                 dogrular                                                     yanlışlar
                ogrencidogruYanlislar[0, 0] = Convert.ToInt32(dr1[0]); ogrencidogruYanlislar[0, 1] = Convert.ToInt32(dr1[1]);

                ogrencidogruYanlislar[1, 0] = Convert.ToInt32(dr1[2]); ogrencidogruYanlislar[1, 1] = Convert.ToInt32(dr1[3]);

                ogrencidogruYanlislar[2, 0] = Convert.ToInt32(dr1[4]); ogrencidogruYanlislar[2, 1] = Convert.ToInt32(dr1[5]);

                ogrencidogruYanlislar[3, 0] = Convert.ToInt32(dr1[6]); ogrencidogruYanlislar[3, 1] = Convert.ToInt32(dr1[7]);

                ogrencidogruYanlislar[4, 0] = Convert.ToInt32(dr1[8]); ogrencidogruYanlislar[4, 1] = Convert.ToInt32(dr1[9]);


                double yanlislartoplam = 0;

                int toplam = 0;

                for (int i = 0; i < 5; i++)
                {
                    double yuzde = (100 * ogrencidogruYanlislar[i,1]) / (ogrencidogruYanlislar[i,0] + ogrencidogruYanlislar[i,1]);
                    yanlislartoplam += yuzde;
                }

                for(int i = 0; i < 5; i++){
                    toplam += ogrencidogruYanlislar[i,0] + ogrencidogruYanlislar[i,1];
                    double yuzde = (100 * ogrencidogruYanlislar[i,1]) / (ogrencidogruYanlislar[i,0] + ogrencidogruYanlislar[i,1]);

                    sorusayisi[i] = Convert.ToInt32((50 * yuzde) / yanlislartoplam);

                   
                }

                for (int i = 0; i < 5; i++)
                {

                    toplamSoruSayisi += sorusayisi[i];
                    if (sorusayisi[i] > enBüyük)
                    {
                        enBüyük = i;
                    }

                }

                if (toplamSoruSayisi > 50)
                {

                    sorusayisi[enBüyük] = toplamSoruSayisi - 50;

                }





            }





        } // Hangi Konudan Kaç Soru Sorulacağını Hesaplar
           
        public void soruCek(int konu) {

            SqlCommand komut1 = new SqlCommand("SELECT soruTuru,soru,dogruCevap,yanlisCevap1,yanlisCevap2,yanlisCevap3,soruGorseli FROM tblSorular where soruKonusu=@p1 ORDER BY NewID()", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",konu);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                Soru[0] = dr1[0].ToString();//soruTuru
                Soru[1] = dr1[1].ToString();//soru
                Soru[2] = dr1[2].ToString();//dogruCevap
                Soru[3] = dr1[3].ToString();//yanlisCevap1
                Soru[4] = dr1[4].ToString();//yanlisCevap2
                Soru[5] = dr1[5].ToString();//yanlisCevap3
                Soru[6] = dr1[6].ToString();//soruGorseli
            }

            siklarikaristir();
        }


        public void siklarikaristir()
        {

            Random rasgele = new Random();
            dogruSik = rasgele.Next(1, 5);

            string temp;

            if (dogruSik == 2)
            {

                temp = Soru[2];
                Soru[2] = Soru[3];
                Soru[3] = temp;


            }
            else if (dogruSik == 3)
            {

                temp = Soru[2];
                Soru[2] = Soru[4];
                Soru[4] = temp;

            }
            else if (dogruSik == 4)
            {

                temp = Soru[2];
                Soru[2] = Soru[5];
                Soru[5] = temp;


            }



        }





    }
}
