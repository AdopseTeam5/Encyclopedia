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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Formepanaf f4 = new Formepanaf();
            f4.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Formregister f5 = new Formregister();
            f5.ShowDialog();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {   string fname_email = txtemail.Text;
            string password = txtpass.Text;
            OPENXMLTestingDataSet1TableAdapters.UsersTableAdapter user_login = new OPENXMLTestingDataSet1TableAdapters.UsersTableAdapter();
            try
            {
                var access = user_login.GetLogin(fname_email, fname_email, password).SingleOrDefault();
                

               
                User user = new User(access.User_ID,access.First_Name,access.Last_Name,access.Email,access.Password,access.Admin);
                UserManager.Shared.setUpCurrentUser(user);
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("ΛαΘος Κωδικος", ex);
            }

           
            
            
            
        }
    }
}
