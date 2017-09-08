using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System;

namespace SarangaBatteryWorks
{
    public class dbcon
    {
        private SqlConnection con;
        public SqlCommand command;
        private SqlDataAdapter da;
        private DataTable dt;

        public dbcon() {
            con = new SqlConnection("Data Source=DESKTOP-S3RM42G;Initial Catalog=SarangaBatteryWorks;Integrated Security=True");
            con.Open();
        }
      

        public DataTable queryEx(String querytext) {
            command = new SqlCommand(querytext, con);
            da = new SqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int NonQueryEx(String querytext) {
            command = new SqlCommand(querytext, con);
            return command.ExecuteNonQuery();
        }


    }
}
