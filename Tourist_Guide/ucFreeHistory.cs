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
    public partial class ucFreeHistory : UserControl
    {
        //singleton user control
        private static ucFreeHistory _instance;
        public static ucFreeHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeHistory();
                }
                return _instance;
            }
        }

        public ucFreeHistory()
        {
            InitializeComponent();
        }
    }
}
