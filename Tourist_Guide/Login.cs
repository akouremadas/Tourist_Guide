using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Guide
{
    public partial class Login : Form
    {
        public static string user;
        db db1 = new db();
        public Login()
        {
            InitializeComponent();
        }

        private void usernametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checks if enter key is pressed
            if (e.KeyChar==(char)13)
            {
                passwordtxt.Focus();
            }
            
        }

        private void passwordtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checks if enter key is pressed
            if (e.KeyChar == (char)13)
            {
                loginbtn.Focus();
            }

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            user = usernametxt.Text;
            if (string.IsNullOrEmpty(usernametxt.Text))
            {
                MessageBox.Show("Παρακαλώ εισάγετε το όνομα χρήστη.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(passwordtxt.Text))
            {
                MessageBox.Show("Παρακαλώ εισάγετε τον κωδικό χρήστη.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordtxt.Focus();
                return;
            }

            db1.dp_open();
            db1.db_user_auth(usernametxt.Text, passwordtxt.Text);
            db1.db_close();
            this.Close();
            Members mb = new Members();
            mb.Show();
        }

    }
}
