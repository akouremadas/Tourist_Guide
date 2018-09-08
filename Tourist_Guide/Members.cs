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
using System.IO;

namespace Tourist_Guide
{
    public partial class Members : Form
    {
        int i = 0;
        int a;

        string user = Login.user;
        db db2 = new db();
       

        public Members()
        {
            InitializeComponent();
            db2.dp_open();

            //load first user control when constructing the form
            panel2.Controls.Add(ucMembersGeneral.Instance);
            ucMembersGeneral.Instance.Dock = DockStyle.Fill;
            ucMembersGeneral.Instance.BringToFront();

            //mark startpage as visited
            startpagelbl.LinkVisited = true;

            a = 1;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void startpagelbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersGeneral.Instance))
            {
                panel2.Controls.Add(ucMembersGeneral.Instance);
                ucMembersGeneral.Instance.Dock = DockStyle.Fill;
                ucMembersGeneral.Instance.BringToFront();
            }

            else
            {
                ucMembersGeneral.Instance.BringToFront();
            }

            startpagelbl.LinkVisited = true;

            a = 1;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void historylbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersHistory.Instance))
            {
                panel2.Controls.Add(ucMembersHistory.Instance);
                ucMembersHistory.Instance.Dock = DockStyle.Fill;
                ucMembersHistory.Instance.BringToFront();
            }

            else
            {
                ucMembersHistory.Instance.BringToFront();
            }

            historylbl.LinkVisited = true;

            a = 2;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void musiclabl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersMusic.Instance))
            {
                panel2.Controls.Add(ucMembersMusic.Instance);
                ucMembersMusic.Instance.Dock = DockStyle.Fill;
                ucMembersMusic.Instance.BringToFront();
            }

            else
            {
                ucMembersMusic.Instance.BringToFront();
            }

            musiclabl.LinkVisited = true;

            a = 3;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void festlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersFest.Instance))
            {
                panel2.Controls.Add(ucMembersFest.Instance);
                ucMembersFest.Instance.Dock = DockStyle.Fill;
                ucMembersFest.Instance.BringToFront();
            }

            else
            {
                ucMembersFest.Instance.BringToFront();
            }

            festlbl.LinkVisited = true;

            a = 4;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void foodlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersFood.Instance))
            {
                panel2.Controls.Add(ucMembersFood.Instance);
                ucMembersFood.Instance.Dock = DockStyle.Fill;
                ucMembersFood.Instance.BringToFront();
            }

            else
            {
                ucMembersFood.Instance.BringToFront();
            }

            foodlbl.LinkVisited = true;

            a = 5;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void tripslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersTrips.Instance))
            {
                panel2.Controls.Add(ucMembersTrips.Instance);
                ucMembersTrips.Instance.Dock = DockStyle.Fill;
                ucMembersTrips.Instance.BringToFront();
            }

            else
            {
                ucMembersTrips.Instance.BringToFront();
            }

            tripslbl.LinkVisited = true;

            a = 6;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void reslbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersRes.Instance))
            {
                panel2.Controls.Add(ucMembersRes.Instance);
                ucMembersRes.Instance.Dock = DockStyle.Fill;
                ucMembersRes.Instance.BringToFront();
            }

            else
            {
                ucMembersRes.Instance.BringToFront();
            }

            reslbl.LinkVisited = true;

            a = 7;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void pictimer_Tick(object sender, EventArgs e)
        {
            //create slideshow that starts over when reaching the end of the image list
            if (i < imageList1.Images.Count)
            {
                imgbox.Image = imageList1.Images[i];
                i++;
            }
            else
            {
                i = 0;
            }
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guideDataSet.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.guideDataSet.history);

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //db2.db_delete_user_history(user);
            db2.db_close();
            this.Close();
            Application.Exit();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //Clear history in app and in db
            histlistbox.Items.Clear();
            db2.db_delete_user_history(user);
        }
        private void gmap2_Load(object sender, EventArgs e)
        {
            gmap2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap2.SetPositionByKeywords("Alexandoupoli, Greece");
            gmap2.ShowCenter = false;

        }

        private void αρχικήΓενικέςΠληροφορίεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersGeneral.Instance))
            {
                panel2.Controls.Add(ucMembersGeneral.Instance);
                ucMembersGeneral.Instance.Dock = DockStyle.Fill;
                ucMembersGeneral.Instance.BringToFront();
            }

            else
            {
                ucMembersGeneral.Instance.BringToFront();
            }

            startpagelbl.LinkVisited = true;

            a = 1;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));

        }

        private void ιστορικέςΠληροφορίεςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersMusic.Instance))
            {
                panel2.Controls.Add(ucMembersMusic.Instance);
                ucMembersMusic.Instance.Dock = DockStyle.Fill;
                ucMembersMusic.Instance.BringToFront();
            }

            else
            {
                ucMembersMusic.Instance.BringToFront();
            }

            musiclabl.LinkVisited = true;

            a = 3;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));

        }

        private void μουσικήΠαράδοσηToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersMusic.Instance))
            {
                panel2.Controls.Add(ucMembersMusic.Instance);
                ucMembersMusic.Instance.Dock = DockStyle.Fill;
                ucMembersMusic.Instance.BringToFront();
            }

            else
            {
                ucMembersMusic.Instance.BringToFront();
            }

            musiclabl.LinkVisited = true;

            a = 3;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void εκδηλώσειςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersFest.Instance))
            {
                panel2.Controls.Add(ucMembersFest.Instance);
                ucMembersFest.Instance.Dock = DockStyle.Fill;
                ucMembersFest.Instance.BringToFront();
            }

            else
            {
                ucMembersFest.Instance.BringToFront();
            }

            festlbl.LinkVisited = true;

            a = 4;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));
        }

        private void τοπικάΠροϊόνταToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersFood.Instance))
            {
                panel2.Controls.Add(ucMembersFood.Instance);
                ucMembersFood.Instance.Dock = DockStyle.Fill;
                ucMembersFood.Instance.BringToFront();
            }

            else
            {
                ucMembersFood.Instance.BringToFront();
            }

            foodlbl.LinkVisited = true;

            a = 5;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));

        }

        private void κοντινέςΑποδράσειςToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersTrips.Instance))
            {
                panel2.Controls.Add(ucMembersTrips.Instance);
                ucMembersTrips.Instance.Dock = DockStyle.Fill;
                ucMembersTrips.Instance.BringToFront();
            }

            else
            {
                ucMembersTrips.Instance.BringToFront();
            }

            tripslbl.LinkVisited = true;

            a = 6;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));

        }

        private void διαμονήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ucMembersRes.Instance))
            {
                panel2.Controls.Add(ucMembersRes.Instance);
                ucMembersRes.Instance.Dock = DockStyle.Fill;
                ucMembersRes.Instance.BringToFront();
            }

            else
            {
                ucMembersRes.Instance.BringToFront();
            }

            reslbl.LinkVisited = true;

            a = 7;

            //update user history in db
            db2.db_read_insert_history(user, a);

            //update user history in app
            histlistbox.Items.Add(db2.db_retrieve_history(user, a));

        }
    }
}  

