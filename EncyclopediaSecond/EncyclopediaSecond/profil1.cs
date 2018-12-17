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
        }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            // ean patisei ektypwsi tha vazei sto panel4 to usercontrol EktyposiBook
            panel4.Controls.Clear();

            EktypisoBook eb = new EktypisoBook();
            eb.Show();
            panel4.Controls.Add(eb);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ean patisei provoli tha vazei sto panel4 to usercontrol ProvoliBook
            
            panel4.Controls.Clear();

            ProvoliBook pb = new ProvoliBook();
            pb.Show();
            panel4.Controls.Add(pb);




            
        }
    }
}
