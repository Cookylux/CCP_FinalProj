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
    public partial class OrderDatabase : Form
    {
        public OrderDatabase()
        {
            InitializeComponent();
        }

        private void lbl_backbutton_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color darkmahogany = ColorTranslator.FromHtml("#4a2d1a");
            panel1.BackColor = darkmahogany;
        }
    }
}
