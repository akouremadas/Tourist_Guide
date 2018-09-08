using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Guide
{
    public partial class Free_Users : Form
    {
        int i = 0;
        public string user = "guest";
        int a;

        db db1 = new db();
        public Free_Users()
        {
            InitializeComponent();
            //user = "guest";

            db1.dp_open();

            //load first user control when constructing the form
            panel2.Controls.Add(ucFreeGeneral.Instance);
            ucFreeGeneral.Instance.Dock = DockStyle.Fill;
            ucFreeGeneral.Instance.BringToFront();

            //mark startpage as visited
            startpagelbl.LinkVisited = true;
            a = 1;


            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }
        

        private void pictimer2_Tick(object sender, EventArgs e)
        {
            //create slideshow that starts over when reaching the end of the image list
            if (i < imageList2.Images.Count)
            {
                imgbox2.Image = imageList2.Images[i];
                i++;
            }
            else
            {
                i = 0;
            }
        }

        private void startpagelbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeGeneral.Instance))
            {
                panel2.Controls.Add(ucFreeGeneral.Instance);
                ucFreeGeneral.Instance.Dock = DockStyle.Fill;
                ucFreeGeneral.Instance.BringToFront();
            }

            else
            {
                ucFreeGeneral.Instance.BringToFront();
            }

            startpagelbl.LinkVisited = true;

            a = 1;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void historylbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeHistory.Instance))
            {
                panel2.Controls.Add(ucFreeHistory.Instance);
                ucFreeHistory.Instance.Dock = DockStyle.Fill;
                ucFreeHistory.Instance.BringToFront();
            }

            else
            {
                ucFreeHistory.Instance.BringToFront();
            }

            historylbl.LinkVisited = true;

            a = 2;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void musiclbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeMusic.Instance))
            {
                panel2.Controls.Add(ucFreeMusic.Instance);
                ucFreeMusic.Instance.Dock = DockStyle.Fill;
                ucFreeMusic.Instance.BringToFront();
            }

            else
            {
                ucFreeMusic.Instance.BringToFront();
            }

            musiclbl.LinkVisited = true;

            a = 3;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void festlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeFest.Instance))
            {
                panel2.Controls.Add(ucFreeFest.Instance);
                ucFreeFest.Instance.Dock = DockStyle.Fill;
                ucFreeFest.Instance.BringToFront();
            }

            else
            {
                ucFreeFest.Instance.BringToFront();
            }

            festlbl.LinkVisited = true;

            a = 4;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void foodlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeFood.Instance))
            {
                panel2.Controls.Add(ucFreeFood.Instance);
                ucFreeFood.Instance.Dock = DockStyle.Fill;
                ucFreeFood.Instance.BringToFront();
            }

            else
            {
                ucFreeFood.Instance.BringToFront();
            }

            foodlbl.LinkVisited = true;

            a = 5;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void tripslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeTrips.Instance))
            {
                panel2.Controls.Add(ucFreeTrips.Instance);
                ucFreeTrips.Instance.Dock = DockStyle.Fill;
                ucFreeTrips.Instance.BringToFront();
            }

            else
            {
                ucFreeTrips.Instance.BringToFront();
            }

            tripslbl.LinkVisited = true;

            a = 6;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void reslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeRes.Instance))
            {
                panel2.Controls.Add(ucFreeRes.Instance);
                ucFreeRes.Instance.Dock = DockStyle.Fill;
                ucFreeRes.Instance.BringToFront();
            }

            else
            {
                ucFreeRes.Instance.BringToFront();
            }

            reslbl.LinkVisited = true;

            a = 7;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));
        }

        private void eXITToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            db1.db_delete_user_history(user);
            db1.db_close();
            this.Close();
            Application.Exit();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void αρχικήΓενικέςΠληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeGeneral.Instance))
            {
                panel2.Controls.Add(ucFreeGeneral.Instance);
                ucFreeGeneral.Instance.Dock = DockStyle.Fill;
                ucFreeGeneral.Instance.BringToFront();
            }

            else
            {
                ucFreeGeneral.Instance.BringToFront();
            }

            startpagelbl.LinkVisited = true;

            a = 1;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void ιστορικέςΠληροφορίεςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeHistory.Instance))
            {
                panel2.Controls.Add(ucFreeHistory.Instance);
                ucFreeHistory.Instance.Dock = DockStyle.Fill;
                ucFreeHistory.Instance.BringToFront();
            }

            else
            {
                ucFreeHistory.Instance.BringToFront();
            }

            historylbl.LinkVisited = true;

            a = 2;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void μουσικήΠαράδοσηToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeMusic.Instance))
            {
                panel2.Controls.Add(ucFreeMusic.Instance);
                ucFreeMusic.Instance.Dock = DockStyle.Fill;
                ucFreeMusic.Instance.BringToFront();
            }

            else
            {
                ucFreeMusic.Instance.BringToFront();
            }

            musiclbl.LinkVisited = true;

            a = 3;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void εκδηλώσειςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeFest.Instance))
            {
                panel2.Controls.Add(ucFreeFest.Instance);
                ucFreeFest.Instance.Dock = DockStyle.Fill;
                ucFreeFest.Instance.BringToFront();
            }

            else
            {
                ucFreeFest.Instance.BringToFront();
            }

            festlbl.LinkVisited = true;

            a = 4;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void τοπικάΠροϊόνταToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeFood.Instance))
            {
                panel2.Controls.Add(ucFreeFood.Instance);
                ucFreeFood.Instance.Dock = DockStyle.Fill;
                ucFreeFood.Instance.BringToFront();
            }

            else
            {
                ucFreeFood.Instance.BringToFront();
            }

            foodlbl.LinkVisited = true;

            a = 5;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void κοντινέςΑποδράσειςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeTrips.Instance))
            {
                panel2.Controls.Add(ucFreeTrips.Instance);
                ucFreeTrips.Instance.Dock = DockStyle.Fill;
                ucFreeTrips.Instance.BringToFront();
            }

            else
            {
                ucFreeTrips.Instance.BringToFront();
            }

            tripslbl.LinkVisited = true;

            a = 6;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }

        private void διαμονήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucFreeRes.Instance))
            {
                panel2.Controls.Add(ucFreeRes.Instance);
                ucFreeRes.Instance.Dock = DockStyle.Fill;
                ucFreeRes.Instance.BringToFront();
            }

            else
            {
                ucFreeRes.Instance.BringToFront();
            }

            reslbl.LinkVisited = true;

            a = 7;

            //update user history in db
            db1.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db1.db_retrieve_history(user, a));

        }
    }
}
