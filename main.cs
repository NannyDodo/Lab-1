using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        String[] imglist = new String[] { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg" };
        int index = 0;
        Country[] countries = new Country[5];
        Player[] players = new Player[5];
        public main()
        {
            InitializeComponent();
            pictureBox2.Load("../../pictures/" + imglist[0]);
            pictureBox3.Load("../../pictures/" + imglist[1]);
            pictureBox4.Load("../../pictures/" + imglist[2]);

            Country country = new Country();
            country.set("ARG", "Argentina");
            countries[0] = country;

            country.set("AT", "Austria");
            countries[1] = country;

            country.set("AUS", "Australia");
            countries[2] = country;

            country.set("BI", "Bosnia");
            countries[3] = country;

            country.set("BIH", "Bosnia Herzegovina");
            countries[4] = country;

            country.set("BIH", "Bosnia Herzegovina");
            countries[5] = country;

            Player player = new Player();
            player.set("1", "Mo", "Williams");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form visitors_menuForms = new visitors_menu();
            visitors_menuForms.Show();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox GetPictureBox2()
        {
            return pictureBox2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index+3 > imglist.Length) index = 0;
            pictureBox2.Load("../../pictures/" + imglist[index + 0]);
            pictureBox3.Load("../../pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../pictures/" + imglist[index + 2]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = index-1;
            if (index < 0) index = imglist.Length-3;
            pictureBox2.Load("../../pictures/" + imglist[index + 0]);
            pictureBox3.Load("../../pictures/" + imglist[index + 1]);
            pictureBox4.Load("../../pictures/" + imglist[index + 2]);
        }
    }
}
