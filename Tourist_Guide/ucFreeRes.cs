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
    public partial class ucFreeRes : UserControl
    {
        //singleton user control
        private static ucFreeRes _instance;
        public static ucFreeRes Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeRes();
                }
                return _instance;
            }
        }
        public ucFreeRes()
        {
            InitializeComponent();
        }
    }
}
