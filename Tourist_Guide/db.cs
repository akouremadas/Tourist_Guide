using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Guide
{
    class db
    {
        OleDbConnection conn;
        string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=guide.accdb";


        public void dp_open()
        {
            conn = new OleDbConnection(connectionstring);

            try
            {
                conn.Open();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void db_close()
        {
            try
            {

                conn.Close();
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        public void db_read_insert_history(string u, int num)
        {
            try
            {

                String myquery = "SELECT page_num FROM history WHERE ((page_num =" + num + ") AND (username='"+ u +"'))";

                OleDbCommand cmd = new OleDbCommand(myquery, conn);

                OleDbDataReader rdr = cmd.ExecuteReader();
                //check if already exists in table history in db
                if (rdr.HasRows != true)
                {
                    db_insert_history(u, num);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    

        private void db_insert_history(string u, int num)
        {
            try
            {
                
                String myquery = "INSERT INTO history (username,page_num) VALUES('" + u + "',"+num+")";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void db_user_auth(string u, string p)
        {
            try
            {
                String myquery = "SELECT username FROM logins WHERE (username ='" + u + "') AND (password ='" + p + "')";
                String myquery2 = "SELECT password FROM logins WHERE (username ='" + u + "') AND (password ='" + p + "')";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbCommand cmd2 = new OleDbCommand(myquery2, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();
                OleDbDataReader rdr2 = cmd2.ExecuteReader();
                if (rdr.HasRows == true)
                {
                    if (rdr2.HasRows == true)
                    {
                        System.Windows.Forms.MessageBox.Show("Επιτυχής είσοδος στην εφαρμογή!");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Ο κωδικός χρήστη είναι λάθος. Παρακαλώ δοκιμάστε ξανά.");
                    }
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(" Το όνομα χρήστη είναι λάθος. Παρακαλώ δοκιμάστε ξανά.");
                }

                rdr.Close();
                rdr2.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        public string db_retrieve_history(string u, int num)
        {
            try
            {
                String myquery = "SELECT pages.page_descr FROM pages INNER JOIN history ON pages.ID = history.page_num WHERE (history.username ='" + u + "') AND (history.page_num=" + num + ")";
                OleDbCommand cmd = new OleDbCommand(myquery, conn);
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (rdr.HasRows == true)
                    {
                        return rdr.GetString(0);
                    }
                    else
                    {
                        return null;
                    }
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void db_delete_user_history(string u)
        {
            try
            {
                String myquery = "DELETE * FROM history WHERE (username ='" + u + "')";
                
                OleDbCommand cmd = new OleDbCommand(myquery, conn);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
