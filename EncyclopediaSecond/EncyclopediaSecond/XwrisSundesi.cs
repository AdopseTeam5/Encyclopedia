using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyclopediaSecond
{
    public partial class XwrisSundesi : UserControl
    {
        public XwrisSundesi()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FormLogin2 f1 = new FormLogin2();
            f1.Show();

        }
    }
}
