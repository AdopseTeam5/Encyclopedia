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
    public partial class profil1 : UserControl
    {
        public profil1()
        {
            InitializeComponent();
            panel3.Controls.Clear();

            AllagiKwdikou ak = new AllagiKwdikou();
            ak.Show();
            panel3.Controls.Add(ak);
        }



        //listview






        private void label28_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            Allagiemail am = new Allagiemail();
            am.Show();
            panel3.Controls.Add(am);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            AllagiKwdikou ak = new AllagiKwdikou();
            ak.Show();
            panel3.Controls.Add(ak);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



      

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Provoli_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = true;
           

            Provoli.Visible = false;
            Ektup.Visible = false;
            Kleisimo.Visible = true;
        }

        private void Kleisimo_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;

            Provoli.Visible = true;
            Ektup.Visible = true;
            Kleisimo.Visible = false;
           
            

        }

        private void ektyp_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;

            // EktypisoBook eb = new EktypisoBook();
            //eb.Show();
            // panel4.Controls.Add(eb);


            Provoli.Visible = false;
            Ektup.Visible = false;
            Kleisimo.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean allselides= false;
            Boolean apoewsselides = false;
            Boolean miaselida = false;

            int aposelida = 0;
            int ewsselida = 0;

            String oneselida = "";
            //elegxos gia to pio radiobutton exei epileksei, thetei timi true gia opoio radio button kai krataei tis selides se int
            if (all.Checked == true)
            {
                allselides = true;

            }
            else if (apoews.Checked== true)
            {
                apoewsselides = true;

                String apos = "";
                apos = apo.Value.ToString();
                aposelida = Int32.Parse(apos);

                String ewss = "";
                ewss = ews.Value.ToString();
                ewsselida = Int32.Parse(ewss);

            }
            else {

                miaselida = true;

           
                oneselida = onesel.Value.ToString();
                int oneselida1 = Int32.Parse(oneselida);

            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        PictureBox picbox1 = new PictureBox();
        
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem ivi = new ListViewItem("Μέγας Αλέξανδρος");
            ivi.SubItems.Add("newimage");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;

            neasim.Visible = true;

            label4.Visible = false;
            

        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            neasim.Visible = false;
            label4.Visible = true;
            listView2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

