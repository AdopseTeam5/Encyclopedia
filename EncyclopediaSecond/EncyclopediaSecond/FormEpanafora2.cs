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
    public partial class FormEpanafora2 : MaterialSkin.Controls.MaterialForm
    {
        public FormEpanafora2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void FormEpanfora_FormClosed(object sender, FormClosedEventArgs e) {

            this.Hide();
            FormLogin2 f1 = new FormLogin2();
            f1.ShowDialog();
        }
        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
    }
}
