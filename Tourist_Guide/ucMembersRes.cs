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
    public partial class ucMembersRes : UserControl
    {
        //singleton user control
        private static ucMembersRes _instance;
        public static ucMembersRes Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMembersRes();
                }
                return _instance;
            }
        }
        public ucMembersRes()
        {
            InitializeComponent();
        }
    }
}
