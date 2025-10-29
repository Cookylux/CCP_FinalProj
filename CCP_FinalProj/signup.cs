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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 home= new Form1();
            home.Show();
            this.Dispose();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            Color darkblue = ColorTranslator.FromHtml("#0e1a40");
            panel2.BackColor = Color.FromArgb(128, darkblue);
            Color blue = ColorTranslator.FromHtml("#222f5b");
            btnconfirm.BackColor = blue;
            panel1.BackColor = blue;
        }

        private void signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Visible = false;
        }

        private void terms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            terms_and_condition TandC= new terms_and_condition();
            TandC.Show();
        }
    }
}
