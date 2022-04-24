using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyon
{
    class SQLHelper
    {
        public string ConnetionString { get; set; }
        public SqlConnection SqlConnection { get; set; }

        public SQLHelper()
        {
            ConnetionString = "Data Source=DESKTOP-IGDIKK1;Initial Catalog=Apartman;User ID=udemy; Password=123";
            SqlConnection = new SqlConnection(ConnetionString);
        }

        public void ExecuteProcedure(string procName, params SqlParameter[] sp)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procName;
            command.Parameters.AddRange(sp);
            command.Connection = SqlConnection;
            SqlConnection.Open();
            command.ExecuteNonQuery();
            SqlConnection.Close();
        }

        public DataTable GetData(string sorgu)
        {
            SqlDataAdapter da = new SqlDataAdapter(sorgu, ConnetionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
