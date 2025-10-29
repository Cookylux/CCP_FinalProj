using CCP_FinalProj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCP_FinalProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(128, Color.Black);
        }

        private void lbsignup_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //home
            if (tabControl1.SelectedIndex == 0)
            {
                Color darkmahogany = ColorTranslator.FromHtml("#4a2d1a");
                panel1.BackColor = darkmahogany;
                string path = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\9f3365782b2bc5dbe8bbfd103b1f5e7c.jpg";
                Image bg= Image.FromFile(path);
                this.BackgroundImage = bg;
                lblogin.ForeColor = Color.AntiqueWhite;
                lbsignup.ForeColor = Color.AntiqueWhite;
                string logopath = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\567609274_1336539038208660_6300572118458079317_n-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
                
            }
            //room and suite
            if (tabControl1.SelectedIndex == 1)
            {
                Color darkred = ColorTranslator.FromHtml("#740001");
                panel1.BackColor = darkred;
                string path = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\bedroom.jpeg";
                Image room = Image.FromFile(path);
                this.BackgroundImage = room;
                Color yellow = ColorTranslator.FromHtml("#eeba30");
                lblogin.ForeColor = yellow;
                lbsignup.ForeColor = yellow;
                string logopath = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\567609274_1336539038208660_6300572118458079317_n-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
            }
            //about us
            if (tabControl1.SelectedIndex == 2)
            {
                Color darkgreen = ColorTranslator.FromHtml("#07281a");
                panel1.BackColor = darkgreen;
                string path = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\slytherin.jpeg";
                Image bg = Image.FromFile(path);
                this.BackgroundImage = bg;
                Color lightsilver = ColorTranslator.FromHtml("#aaaaaa");
                lblogin.ForeColor = lightsilver;
                lbsignup.ForeColor = lightsilver;
                Color green = ColorTranslator.FromHtml("#54755a");
                tabPage3.BackColor = green;
                string logopath = @"CC:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\slytherin.jpeg";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
            }
            //contact us
            if (tabControl1.SelectedIndex == 3)
            {
                Color darkbrown = ColorTranslator.FromHtml("#372e29");
                panel1.BackColor= darkbrown;
                string path = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\hufflepuff.jpg";
                Image bg = Image.FromFile(path);
                this.BackgroundImage = bg;
                Color lightcanary = ColorTranslator.FromHtml("#f0c75e");
                lblogin.ForeColor = lightcanary;
                lbsignup.ForeColor = lightcanary;
                Color dutchwhite = ColorTranslator.FromHtml("#efdfb7");
                tabPage4.BackColor = dutchwhite;
                string logopath = @"C:\Users\rieje\Desktop\FinalProj_CCP\CCP_FinalProj\Resources\IMG_1540-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color darkmahogany = ColorTranslator.FromHtml("#4a2d1a");
            panel1.BackColor = darkmahogany;
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
        }
    }
}
