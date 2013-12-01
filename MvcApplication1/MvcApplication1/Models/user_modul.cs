using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class user_modul
    {
        string connStr = "";
        private int count;

        public List<string> GetUserNames()
        {

            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT email FROM User";

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> emails = new List<string>();

            while(reader.Read())
            {
                emails.Add(reader["email"].ToString());
            }

            return emails;

       
        }

     public int GetUserCount()
     {
         SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            SqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM User";


             int count = Convert.ToInt32 (cmd.ExecuteScalar());
          
        return count;
     }
    }
}