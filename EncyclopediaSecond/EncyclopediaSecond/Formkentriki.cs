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
            panel1.Controls.Clear();

            arxiki ar = new arxiki();
            ar.Show();
            panel1.Controls.Add(ar);
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
            panel1.Controls.Clear();

           arxiki ar = new arxiki();
            tixeo_lima(ar);//kali tin function tixeo_lima
            ar.Show();
            panel1.Controls.Add(ar);
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //edw ua ginete elegxos ean einai sundemenos o xristis i oxi ,wste na emfanizei to profil1 usercontrol i to XwrisSundesi
            //if(den exei sundethei)
            ///kwdikas gia emfanisi mi sundedemenou xristi
           // panel1.Controls.Clear();

            //XwrisSundesi xs = new XwrisSundesi();
            //xs.Show();
           // panel1.Controls.Add(xs);




            //kwdikas gia emfanisei sundedemenoy xristi
            //else(exei sundethei)


             panel1.Controls.Clear();

               profil1 prof1 = new profil1();
             prof1.Show();
             panel1.Controls.Add(prof1);






        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


            //edw ua ginete elegxos ean einai sundemenos o xristis i oxi ,wste na emfanizei to profil1 usercontrol i to XwrisSundesi
            //if(den exei sundethei)
            ///kwdikas gia emfanisi mi sundedemenou xristi
            panel1.Controls.Clear();

            XwrisSundesi xs = new XwrisSundesi();
            xs.Show();
            panel1.Controls.Add(xs);

            
            
            
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
                this.toolStripLabel1.Text = user.getEmail();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();

            KatalogosLimmatwn xs = new KatalogosLimmatwn();
            xs.Show();
            panel1.Controls.Add(xs);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();

            SanSimera xs = new SanSimera();
            xs.Show();
            panel1.Controls.Add(xs);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();

            TyxaioLimma xs = new TyxaioLimma();
            xs.Show();
            panel1.Controls.Add(xs);
        }


        //kodikas emfanisis tixeon limaton{Rafail} stin arxiki
        public void tixeo_lima(arxiki ar)
        {
            Random rnd = new Random();
            int article_id_1 = rnd.Next(18, 601301);//18 mikrotero id 601301 megalitero
            int article_id_2 = rnd.Next(18, 601301);
            int article_id_3 = rnd.Next(18, 601301);



            OPENXMLTestingEntities1 article_tixeo = new OPENXMLTestingEntities1();


            //tixeo lima 1 
            var get_article_tixeo = article_tixeo.articles.Where(a => a.id == article_id_1).SingleOrDefault();
            var get_article_image_tixeo = article_tixeo.imagelinks.Where(a => a.il_from == article_id_1).First();
            ar.Label14.Text = get_article_tixeo.title;
            ar.Label15.Text = get_article_tixeo.kimeno;
            string get_article_image_tixeo_il_to = get_article_image_tixeo.il_to;//pernoume to onoma tou arxiou
            string image_path_tixeo = "https://el.wikipedia.org/wiki/%CE%91%CF%81%CF%87%CE%B5%CE%AF%CE%BF:" + get_article_image_tixeo_il_to;//topothetoume to arxio se url tis wikipidia
            ar.PictureBox7.Image = Image.FromFile(image_path_tixeo);//emfanizoume to arxio

            //tixeo lima 2 
            get_article_tixeo = article_tixeo.articles.Where(a => a.id == article_id_1).SingleOrDefault();
            get_article_image_tixeo = article_tixeo.imagelinks.Where(a => a.il_from == article_id_1).First();
            ar.Label16.Text = get_article_tixeo.title;
            ar.Label17.Text = get_article_tixeo.kimeno;
            get_article_image_tixeo_il_to = get_article_image_tixeo.il_to;
            image_path_tixeo = "https://el.wikipedia.org/wiki/%CE%91%CF%81%CF%87%CE%B5%CE%AF%CE%BF:" + get_article_image_tixeo_il_to;
            ar.PictureBox8.Image = Image.FromFile(image_path_tixeo);



            //tixeo lima 3
            get_article_tixeo = article_tixeo.articles.Where(a => a.id == article_id_1).SingleOrDefault();
            get_article_image_tixeo = article_tixeo.imagelinks.Where(a => a.il_from == article_id_1).First();
            ar.Label18.Text = get_article_tixeo.title;
            ar.Label19.Text = get_article_tixeo.kimeno;
            get_article_image_tixeo_il_to = get_article_image_tixeo.il_to;
            image_path_tixeo = "https://el.wikipedia.org/wiki/%CE%91%CF%81%CF%87%CE%B5%CE%AF%CE%BF:" + get_article_image_tixeo_il_to;//
            ar.PictureBox9.Image = Image.FromFile(image_path_tixeo);



        }

        /*
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();

            TyxaioLimma xs = new TyxaioLimma();
            xs.Show();
            panel1.Controls.Add(xs);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Controls.Clear();

            SanSimera xs = new SanSimera();
            xs.Show();
            panel1.Controls.Add(xs);
        }
        */
    }
}
