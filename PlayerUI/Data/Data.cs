using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TestAndScore.Data
{
    class Data
    {
        public SqlConnection connect()
        {
            return new SqlConnection(@"Data Source=LAPTOP-OR960A4M;Initial Catalog=test;Integrated Security=True");
        }
        public DataTable GET(string sql)
        {
            SqlConnection con = connect();
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void AC(string sql)
        {
            SqlConnection con = connect();
           
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        
    }
}
