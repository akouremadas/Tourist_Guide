using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tourist_Guide
{
    public partial class ucMembersGeneral : UserControl
    {
        //singleton user control
        private static ucMembersGeneral _instance;
        public static ucMembersGeneral Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMembersGeneral();
                }
                return _instance;
            }
        }
        public ucMembersGeneral()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text |*.txt";
            savefile.Title = "Εξαγωγή σε αρχείο";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(savefile.FileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(richTextBox1.Text.Replace("\n", Environment.NewLine));
                    sw.Close();
                }
            }

        }
    }
}
