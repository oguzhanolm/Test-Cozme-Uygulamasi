using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestCoz
{
    class Sqlbaglantisi
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-7OCD4IRC\\SQLEXPRESS;Initial Catalog=dtbSoruCoz;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
