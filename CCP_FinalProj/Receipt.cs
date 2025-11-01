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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color darkgreen = ColorTranslator.FromHtml("#07281a");
            panel1.BackColor = darkgreen;
            pblogo.BackColor = darkgreen;

        }

        private void pblogo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
