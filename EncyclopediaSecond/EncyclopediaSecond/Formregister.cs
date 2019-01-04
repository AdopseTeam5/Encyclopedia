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
    public partial class Formregister : Form
    {
        public Formregister()
        {
            InitializeComponent();
        }

        //elexgei ean exoun simplirwthei ola ta pedia
        public Boolean checkall()
        {
            Boolean ok = true;

            if (textBox1.Text == "")
            {

                ok = false;
                textBox1.Clear();
                label6.Visible = true;
                label6.ForeColor = Color.Red;
               
               

            }
            if (textBox2.Text == "")
            {

                ok = false;
                textBox2.Clear();
                label7.Visible = true;
                label7.ForeColor = Color.Red;


            }
            if (textBox3.Text == "")
            {

                ok = false;
                textBox3.Clear();
                label8.Visible = true;
                label8.ForeColor = Color.Red;

            }
            if (textBox4.Text == "")
            {

                ok = false;
                textBox4.Clear();
                label9.Visible = true;
                label9.ForeColor = Color.Red;

            }


            if (textBox5.Text == "")
            {

                ok = false;
                textBox5.Clear();
                label10.Visible = true;
                label10.ForeColor = Color.Red;

            }



            

            return ok;

        }


        //methodos pou elegxei  ean oi kwdikoi einai idioi
        public Boolean checkKwdikoi()
        {
            Boolean ok = true;


            String pass = textBox4.Text;
            String repass = textBox5.Text;
            if (pass != repass)
            {
                ok = false;
                labelkwdikoi.Visible = true;
                labelkwdikoi.ForeColor = Color.Red;
               
                textBox5.Clear();
                textBox4.Clear();

            }

           
           
            return ok;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Formlogin f3 = new Formlogin();
            f3.ShowDialog();



        }

        private void Formregister_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String email=textBox3.Text;
            String fname = textBox1.Text;
            String lname = textBox2.Text;
            String pass = textBox4.Text;


            
            if (checkall())
            {
                if (checkKwdikoi())
                {
                    //kane eggrafi
                    User u = new User(email, pass, fname, lname);

                }


            }
          


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
