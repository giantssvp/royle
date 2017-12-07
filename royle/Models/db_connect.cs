using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;namespace royle.Models
{
    public class db_connect
    {
        private MySqlConnection connection;

        private bool OpenConnection()
        {
            string connetionString = null;
            connetionString = "server=182.50.133.77;database=common_db;uid=commonadmin;pwd=Common@123;Allow User Variables=True;";
            connection = new MySqlConnection(connetionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public int Insert(string Name, string Email, String Phone, string Subject, string Message)
        {
            try
            {
                string query = "INSERT INTO royal_contact (Name, Email_id, Phone, Subject, Message, Status, Date) VALUES(@name, @email, @phone, @sub, @msg, @sts, CURDATE())";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@sub", Subject);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@msg", Message);
                    cmd.Parameters.AddWithValue("@sts", false);

                    cmd.ExecuteNonQuery();
                                      
                    this.CloseConnection();
                }
                return 0;
            }
            catch (MySqlException ex)
            {
                return -1;
            }
        }

        /* Transport insert*/
        public int transportInsert(string Name, string Email, String Phone, string t_from, string t_to)
        {
            try
            {
                string query = "INSERT INTO royal_transport (Name, Email_id, Phone, transport_from, transport_to, Status, Date) VALUES(@name, @email, @phone, @from, @to, @sts, CURDATE())";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@from", t_from);
                    cmd.Parameters.AddWithValue("@phone", Phone);
                    cmd.Parameters.AddWithValue("@to", t_to);
                    cmd.Parameters.AddWithValue("@sts", false);

                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }
                return 0;
            }
            catch (MySqlException ex)
            {
                return -1;
            }
        }

    } //db_connect class
} // namespace