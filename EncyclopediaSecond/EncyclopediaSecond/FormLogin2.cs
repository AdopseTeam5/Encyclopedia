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
    public partial class FormLogin2 : MaterialSkin.Controls.MaterialForm
    {

        public FormLogin2()
        {
            InitializeComponent();
          
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User("testMail", "testPass");
            UserManager.Shared.setUpCurrentUser(user);
        }
        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormEpanafora2 f1 = new FormEpanafora2();
            f1.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void LinkLabelEpanafora_Click(object sender, EventArgs e) {
            this.Hide();
            FormEpanafora2 f1 = new FormEpanafora2();
            f1.Show();
            
        }

        private void LinkLabelNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister2 f1 = new FormRegister2();
            f1.ShowDialog();
        }
    }
}
