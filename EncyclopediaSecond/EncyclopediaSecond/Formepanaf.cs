using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncyclopediaSecond
{
    public partial class Formepanaf : Form
    {
        public Formepanaf()
        {
            InitializeComponent();
        }

        private void Formepanaf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Formlogin f1 = new Formlogin();
            f1.ShowDialog();
        }

        private void Formepanaf_Load(object sender, EventArgs e)
        {

        }
    }
}
