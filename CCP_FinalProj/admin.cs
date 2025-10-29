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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //home
            if (tabControl1.SelectedIndex == 0)
            {
                Color darkred = ColorTranslator.FromHtml("#740001");
                panel1.BackColor = darkred;
                Color yellow = ColorTranslator.FromHtml("#eeba30");
                label2.ForeColor = yellow;
                label1.ForeColor = yellow;
                label3.ForeColor = yellow;
                string logopath = @"C:\Users\rieje\source\repos\CCP_FinalProj\CCP_FinalProj\Resources\567609274_1336539038208660_6300572118458079317_n-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
                Color lightcanary = ColorTranslator.FromHtml("#ffeaa2");
                tabPage1.BackColor = lightcanary;

            }
            //user
            if (tabControl1.SelectedIndex == 1) 
            {
                Color darkgreen = ColorTranslator.FromHtml("#07281a");
                panel1.BackColor = darkgreen;
                Color lightsilver = ColorTranslator.FromHtml("#aaaaaa");
                label1.ForeColor = lightsilver;
                label2.ForeColor = lightsilver;
                label3.ForeColor = lightsilver;
                string logopath = @"C:\Users\rieje\source\repos\CCP_FinalProj\CCP_FinalProj\Resources\IMG_1539-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
                Color green = ColorTranslator.FromHtml("#54755a");
                tabPage2.BackColor = green;
            }
            //room
            if(tabControl1.SelectedIndex == 2)
            {
                Color darkblue = ColorTranslator.FromHtml("#0e1a40");
                panel1.BackColor = darkblue;
                Color gold = ColorTranslator.FromHtml("#946b2d");
                label1.ForeColor = gold;
                label2.ForeColor = gold;
                label3.ForeColor = gold;
                string logopath = @"C:\Users\rieje\source\repos\CCP_FinalProj\CCP_FinalProj\Resources\IMG_1539-removebg-preview.png";
                Image logo = Image.FromFile(logopath);
                pblogo.Image = logo;
                
            }
            //resevation
            if (tabControl1.SelectedIndex == 3) 
            {
                Color darkbrown = ColorTranslator.FromHtml("#372e29");
                panel1.BackColor = darkbrown;
                Color lightcanary = ColorTranslator.FromHtml("#f0c75e");
                label1.ForeColor = lightcanary;
                label2.ForeColor = lightcanary;
                label3.ForeColor = lightcanary;
                string logopath = @"C:\Users\rieje\source\repos\CCP_FinalProj\CCP_FinalProj\Resources\IMG_1540-removebg-preview.png";
                Image logo= Image.FromFile(logopath);
                pblogo.Image = logo;
            }

        }

        private void admin_Load(object sender, EventArgs e)
        {
            //design load
            Color darkred = ColorTranslator.FromHtml("#740001");
            panel1.BackColor = darkred;
            Color yellow = ColorTranslator.FromHtml("#eeba30");
            label2.ForeColor = yellow;
            label1.ForeColor = yellow;
            label3.ForeColor = yellow;
            string logopath = @"C:\Users\rieje\source\repos\CCP_FinalProj\CCP_FinalProj\Resources\567609274_1336539038208660_6300572118458079317_n-removebg-preview.png";
            Image logo = Image.FromFile(logopath);
            pblogo.Image = logo;
            Color lightcanary = ColorTranslator.FromHtml("#ffeaa2");
            tabPage1.BackColor = lightcanary;
        }
    }
}
