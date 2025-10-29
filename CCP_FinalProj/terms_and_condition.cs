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
    public partial class terms_and_condition : Form
    {
        public terms_and_condition()
        {
            InitializeComponent();
        }

        private void terms_and_condition_Load(object sender, EventArgs e)
        {
            Color blue = ColorTranslator.FromHtml("#222f5b");
            this.BackColor = blue;
            Color gold = ColorTranslator.FromHtml("#d3a625");
            label3.ForeColor = gold;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Close();
        }
    }
}
