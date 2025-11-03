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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

            
        }

        private void lblLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            // TextBoxes
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            string contact = txt_contact.Text;


            // NumericUpDown
            int age = (int)numericUpDown_age.Value;
            int noAdults = (int)numericUpDown_adults.Value;
            int noChildren = (int)numericUpDown_children.Value;

            // ComboBoxes
            string roomType = cmb_roomtype.SelectedItem.ToString();
            string roomNumber = cmb_roomnumber.SelectedItem.ToString();

            // DateTimePickers
            DateTime checkIn = dtp_checkin.Value;
            DateTime checkOut = dtp_checkout.Value;

            // CheckBoxes
            if (cb_student.Checked) { }
            else if (cb_senior.Checked) { }
            else if (cb_weekend.Checked) { }
            else if (cb_family.Checked) { }

            // Total Cost
            string totalcost = txt_totalcost.Text;

            // Receipt
            Receipt receipt = new Receipt();
            receipt.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
    }
}
