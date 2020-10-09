using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestCoz
{
    

    class clsSoruEkleDb
    {

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public void metinSoruEkle(String[] ekleneceksoru) {
            SqlCommand komut1 = new SqlCommand("INSERT INTO tblSorular(soruTuru,soruKonusu,soru,dogruCevap,YanlisCevap1,yanlisCevap2,yanlisCevap3)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt16(ekleneceksoru[0]));
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt16(ekleneceksoru[1]));
            komut1.Parameters.AddWithValue("@p3", ekleneceksoru[2]);
            komut1.Parameters.AddWithValue("@p4", ekleneceksoru[3]);
            komut1.Parameters.AddWithValue("@p5", ekleneceksoru[4]);
            komut1.Parameters.AddWithValue("@p6", ekleneceksoru[5]);
            komut1.Parameters.AddWithValue("@p7", ekleneceksoru[6]);
            komut1.ExecuteNonQuery();
        }//Görsel içermeyen Soru 

        public void sadecSorudaGorselliSoruEkle(String[] ekleneceksoru) {
            SqlCommand komut1 = new SqlCommand("INSERT INTO tblSorular(soruTuru,soruKonusu,soru,dogruCevap,YanlisCevap1,yanlisCevap2,yanlisCevap3,soruGorseli)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt16(ekleneceksoru[0]));
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt16(ekleneceksoru[1]));
            komut1.Parameters.AddWithValue("@p3", ekleneceksoru[2]);
            komut1.Parameters.AddWithValue("@p4", ekleneceksoru[3]);
            komut1.Parameters.AddWithValue("@p5", ekleneceksoru[4]);
            komut1.Parameters.AddWithValue("@p6", ekleneceksoru[5]);
            komut1.Parameters.AddWithValue("@p7", ekleneceksoru[6]);
            komut1.Parameters.AddWithValue("@p8", ekleneceksoru[7]);
            komut1.ExecuteNonQuery();
        }

        public void soruVeCevaptaGorselliSoruEkle(String[] ekleneceksoru) {

            SqlCommand komut1 = new SqlCommand("INSERT INTO tblSorular(soruTuru,soruKonusu,soru,dogruCevap,YanlisCevap1,yanlisCevap2,yanlisCevap3,soruGorseli)VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt16(ekleneceksoru[0]));
            komut1.Parameters.AddWithValue("@p2", Convert.ToInt16(ekleneceksoru[1]));
            komut1.Parameters.AddWithValue("@p3", ekleneceksoru[2]);
            komut1.Parameters.AddWithValue("@p4", ekleneceksoru[3]);
            komut1.Parameters.AddWithValue("@p5", ekleneceksoru[4]);
            komut1.Parameters.AddWithValue("@p6", ekleneceksoru[5]);
            komut1.Parameters.AddWithValue("@p7", ekleneceksoru[6]);
            komut1.Parameters.AddWithValue("@p8", ekleneceksoru[7]);
            komut1.ExecuteNonQuery();

        }
     
    }
}
