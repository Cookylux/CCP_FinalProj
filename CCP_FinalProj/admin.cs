using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                lbl_logout.ForeColor = yellow;
                label1.ForeColor = yellow;
                label3.ForeColor = yellow;


                pblogo.Image = Properties.Resources._567609274_1336539038208660_6300572118458079317_n_removebg_preview;
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
                lbl_logout.ForeColor = lightsilver;
                label3.ForeColor = lightsilver;
                
                pblogo.Image = Properties.Resources.IMG_1539_removebg_preview;
            }
            //room
            if(tabControl1.SelectedIndex == 2)
            {
                Color darkblue = ColorTranslator.FromHtml("#0e1a40");
                panel1.BackColor = darkblue;
                Color gold = ColorTranslator.FromHtml("#946b2d");
                label1.ForeColor = gold;
                lbl_logout.ForeColor = gold;
                label3.ForeColor = gold;
               
                pblogo.Image = Properties.Resources.IMG_1539_removebg_preview;


            }
            //resevations
            if (tabControl1.SelectedIndex == 3) 
            {
                Color darkbrown = ColorTranslator.FromHtml("#372e29");
                panel1.BackColor = darkbrown;
                Color lightcanary = ColorTranslator.FromHtml("#f0c75e");
                label1.ForeColor = lightcanary;
                lbl_logout.ForeColor = lightcanary;
                label3.ForeColor = lightcanary;
                
                pblogo.Image = Properties.Resources.IMG_1540_removebg_preview;
            }

        }

        private void admin_Load(object sender, EventArgs e)
        {
            //design load
            Color darkred = ColorTranslator.FromHtml("#740001");
            panel1.BackColor = darkred;
            Color yellow = ColorTranslator.FromHtml("#eeba30");
            lbl_logout.ForeColor = yellow;
            label1.ForeColor = yellow;
            label3.ForeColor = yellow;
            
            pblogo.Image = Properties.Resources._567609274_1336539038208660_6300572118458079317_n_removebg_preview;
            Color lightcanary = ColorTranslator.FromHtml("#ffeaa2");
            tabPage1.BackColor = lightcanary;
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            OrderDatabase orderDatabase = new OrderDatabase();
            orderDatabase.Show();
        }

        private void pblogo_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();

        }
    }
}
