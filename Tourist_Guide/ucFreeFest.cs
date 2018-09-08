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
    public partial class ucFreeFest : UserControl
    {
        //singleton user control
        private static ucFreeFest _instance;
        public static ucFreeFest Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeFest();
                }
                return _instance;
            }
        }
        public ucFreeFest()
        {
            InitializeComponent();
        }
    }
}
