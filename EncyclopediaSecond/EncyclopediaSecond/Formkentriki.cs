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
    public partial class Formkentriki : Form
    {
        public Formkentriki()
        {

            InitializeComponent();
            //adiazei to panel
            MainPanel.Controls.Clear();

            arxiki ar = new arxiki();
            ar.Show();
            MainPanel.Controls.Add(ar);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           Formlogin f1 = new Formlogin();
            f1.ShowDialog();
        }

        private void Formarxiki_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Formregister f1 = new Formregister();
            f1.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            //panel9.Hide();
            //panel10.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {
           // panel6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //groupBox5.Visible = true; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // panel11.Hide();
            //panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel3.Hide();
            //panel11.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           // panel9.Visible = true;
            //panel10.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //adiazei to panel
            MainPanel.Controls.Clear();

           arxiki ar = new arxiki();
            ar.Show();
            MainPanel.Controls.Add(ar);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //edw ua ginete elegxos ean einai sundemenos o xristis i oxi ,wste na emfanizei to profil1 usercontrol i to XwrisSundesi
            //if(den exei sundethei)
            ///kwdikas gia emfanisi mi sundedemenou xristi
            //panel1.Controls.Clear();

            //XwrisSundesi xs = new XwrisSundesi();
            //xs.Show();
           // panel1.Controls.Add(xs);




            //kwdikas gia emfanisei sundedemenoy xristi
            //else(exei sundethei)


              MainPanel.Controls.Clear();
        
                profil1 prof1 = new profil1();
              prof1.Show();
              MainPanel.Controls.Add(prof1);






        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


            //edw ua ginete elegxos ean einai sundemenos o xristis i oxi ,wste na emfanizei to profil1 usercontrol i to XwrisSundesi
            //if(den exei sundethei)
            ///kwdikas gia emfanisi mi sundedemenou xristi
            MainPanel.Controls.Clear();

            XwrisSundesi xs = new XwrisSundesi();
            xs.Show();
            MainPanel.Controls.Add(xs);

            
            
            
            //kwdikas gia emfanisei sundedemenoy xristi
          //else(exei sundethei)


         //   panel1.Controls.Clear();

        //    profil1 prof1 = new profil1();
          //  prof1.Show();
          //  panel1.Controls.Add(prof1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Formkentriki_Activated(object sender, EventArgs e)
        {
            User user = UserManager.Shared.getCurrentUser();
            if (user != null) {

                //kwdikas ean exei sundethei na allazei to menu
                this.toolStripLabel1.Text = user.getEmail();
                aposundesi.Visible = true;
                toolStripButton2.Visible = false;
                toolStripButton3.Visible = false;
                toolStripSeparator1.Visible = false;

            }
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SideButtonPanel.Height = ProfileButton.Height;
            SideButtonPanel.Top = ProfileButton.Top;

            MainPanel.Controls.Clear();
            XwrisSundesi v2 = new XwrisSundesi();
            MainPanel.Controls.Add(v2);
        }

       

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            SideButtonPanel.Height = materialFlatButton2.Height;
            SideButtonPanel.Top = materialFlatButton2.Top;
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            SideButtonPanel.Height = materialFlatButton3.Height;
            SideButtonPanel.Top = materialFlatButton3.Top;
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            SideButtonPanel.Height = materialFlatButton4.Height;
            SideButtonPanel.Top = materialFlatButton4.Top;
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            SideButtonPanel.Height = materialFlatButton5.Height;
            SideButtonPanel.Top = materialFlatButton5.Top;
        }
    }
}
