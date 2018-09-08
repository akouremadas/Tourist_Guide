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
    public partial class ucFreeFood : UserControl
    {
        //singleton user control
        private static ucFreeFood _instance;
        public static ucFreeFood Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucFreeFood();
                }
                return _instance;
            }
        }
        public ucFreeFood()
        {
            InitializeComponent();
        }
    }
}
