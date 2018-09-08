using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Guide
{
    public partial class ucFreeMusic : UserControl
    {
        //singleton user control
        private static ucFreeMusic _instance;
        public static ucFreeMusic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeMusic();
                }
                return _instance;
            }
        }
        public ucFreeMusic()
        {
            InitializeComponent();
        }
    }
}
