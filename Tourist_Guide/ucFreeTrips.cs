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
    public partial class ucFreeTrips : UserControl
    {
        //singleton user control
        private static ucFreeTrips _instance;
        public static ucFreeTrips Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeTrips();
                }
                return _instance;
            }
        }
        public ucFreeTrips()
        {
            InitializeComponent();
        }
    }
}
