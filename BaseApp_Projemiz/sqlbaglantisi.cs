using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BaseApp_Projemiz
{
    class sqlbaglantisi
    {
        
        public SqlConnection baglanti()
        {           
            SqlConnection baglan = new SqlConnection(System.IO.File.ReadAllText(@"C:\VeriTabaniAdres_SefaKorkmaz.txt"));
            baglan.Open();
            return baglan;          
        }        
    }
}
