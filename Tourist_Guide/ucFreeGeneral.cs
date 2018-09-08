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
    public partial class ucFreeGeneral : UserControl
    {
        //singleton user control
        private static ucFreeGeneral _instance;
        public static ucFreeGeneral Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeGeneral();
                }
                return _instance;
            }
        }
      
        public ucFreeGeneral()
        {
            InitializeComponent();
        }
    }
}
