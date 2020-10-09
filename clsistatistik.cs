using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestCoz
{
    class clsistatistik
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DateTime bugun = DateTime.Now;
        public int[,] genelistatistikler = new int[5, 2];


        public void sinavSonucuEkle(String kullaniciid, int[,] cozulenTestVerileri)
        {
            SqlCommand komut1 = new SqlCommand("INSERT INTO tblistatistik(ogrenciid,tarih,konuADogru,konuAYanlis,konuBDogru,konuBYanlis,konuCDogru,konuCYanlis,konuDDogru,KonuDYanlis,KonuEDogru,KonuEYanlis) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(kullaniciid));
            komut1.Parameters.AddWithValue("@p2", bugun);
            komut1.Parameters.AddWithValue("@p3", cozulenTestVerileri[0, 0]);
            komut1.Parameters.AddWithValue("@p4", cozulenTestVerileri[0, 1]);
            komut1.Parameters.AddWithValue("@p5", cozulenTestVerileri[1, 0]);
            komut1.Parameters.AddWithValue("@p6", cozulenTestVerileri[1, 1]);
            komut1.Parameters.AddWithValue("@p7", cozulenTestVerileri[2, 0]);
            komut1.Parameters.AddWithValue("@p8", cozulenTestVerileri[2, 1]);
            komut1.Parameters.AddWithValue("@p9", cozulenTestVerileri[3, 0]);
            komut1.Parameters.AddWithValue("@p10", cozulenTestVerileri[3, 1]);
            komut1.Parameters.AddWithValue("@p11", cozulenTestVerileri[4, 0]);
            komut1.Parameters.AddWithValue("@p12", cozulenTestVerileri[4, 1]);
            komut1.ExecuteNonQuery();
        }//Görsel içermeyen Soru 


        public void genelistatistik(int kullaniciid)
        {

            SqlCommand komut1 = new SqlCommand("SELECT SUM(konuADogru),SUM(konuAYanlis),SUM(konuBDogru),SUM(konuBYanlis),SUM(konuCDogru),SUM(konuCYanlis),SUM(konuDDogru),SUM(konuDYanlis),SUM(konuEDogru),SUM(konuEYanlis) FROM tblistatistik WHERE ogrenciid=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", kullaniciid);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                //                 dogrular                                                     yanlışlar
                genelistatistikler[0, 0] = Convert.ToInt32(dr1[0]); genelistatistikler[0, 1] = Convert.ToInt32(dr1[1]);

                genelistatistikler[1, 0] = Convert.ToInt32(dr1[2]); genelistatistikler[1, 1] = Convert.ToInt32(dr1[3]);

                genelistatistikler[2, 0] = Convert.ToInt32(dr1[4]); genelistatistikler[2, 1] = Convert.ToInt32(dr1[5]);

                genelistatistikler[3, 0] = Convert.ToInt32(dr1[6]); genelistatistikler[3, 1] = Convert.ToInt32(dr1[7]);

                genelistatistikler[4, 0] = Convert.ToInt32(dr1[8]); genelistatistikler[4, 1] = Convert.ToInt32(dr1[9]);



            }






        }

    }
}
