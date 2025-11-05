using CCP_FinalProj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                
                this.BackgroundImage = Properties.Resources._9f3365782b2bc5dbe8bbfd103b1f5e7c;
                lblogin.ForeColor = Color.AntiqueWhite;
                lbl_signup.ForeColor = Color.AntiqueWhite;

                pblogo.Image = Properties.Resources._567609274_1336539038208660_6300572118458079317_n_removebg_preview;


            }
            //room and suite
            if (tabControl1.SelectedIndex == 1)
            {
                Color darkred = ColorTranslator.FromHtml("#740001");
                panel1.BackColor = darkred;

                
                this.BackgroundImage = Properties.Resources.bedroom;

                Color yellow = ColorTranslator.FromHtml("#eeba30");
                lblogin.ForeColor = yellow;
                lbl_signup.ForeColor = yellow;

                pblogo.Image = Properties.Resources._567609274_1336539038208660_6300572118458079317_n_removebg_preview;
            }
            //about us
            if (tabControl1.SelectedIndex == 2)
            {
                Color darkgreen = ColorTranslator.FromHtml("#07281a");
                panel1.BackColor = darkgreen;
                
                this.BackgroundImage = Properties.Resources.slytherin;
                Color lightsilver = ColorTranslator.FromHtml("#aaaaaa");
                lblogin.ForeColor = lightsilver;
                lbl_signup.ForeColor = lightsilver;
                Color green = ColorTranslator.FromHtml("#54755a");
                tabPage3.BackColor = green;
                
                pblogo.Image = Properties.Resources.IMG_1539_removebg_preview;
            }
            //contact us
            if (tabControl1.SelectedIndex == 3)
            {
                Color darkbrown = ColorTranslator.FromHtml("#372e29");
                panel1.BackColor= darkbrown;
                
                this.BackgroundImage = Properties.Resources.hufflepuff;
                Color lightcanary = ColorTranslator.FromHtml("#f0c75e");
                lblogin.ForeColor = lightcanary;
                lbl_signup.ForeColor = lightcanary;
                Color dutchwhite = ColorTranslator.FromHtml("#efdfb7");
                tabPage4.BackColor = dutchwhite;
                
                pblogo.Image = Properties.Resources.IMG_1540_removebg_preview;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
