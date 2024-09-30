using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorcery_Management_System
{
    class Access
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Personal\Projects\C#\Gorcery_Management_System\Gorcery_Management_Database.mdf;Integrated Security=True;Connect Timeout=30";

        public static DataTable GetData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static byte[] GetImage(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();
                return result as byte[];
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static bool ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
