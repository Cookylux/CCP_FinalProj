namespace CCP_FinalProj
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.dtp_checkin = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_age = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_adults = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_children = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_roomtype = new System.Windows.Forms.ComboBox();
            this.cmb_roomnumber = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_totalcost = new System.Windows.Forms.TextBox();
            this.btn_compute = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.lbl_back = new System.Windows.Forms.Label();
            this.cb_student = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_weekend = new System.Windows.Forms.CheckBox();
            this.cb_senior = new System.Windows.Forms.CheckBox();
            this.cb_family = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_adults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_children)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pblogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 102);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(136, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(829, 35);
            this.label15.TabIndex = 1;
            this.label15.Text = "Fill out your booking details to experience a magical comfort";
            // 
            // pblogo
            // 
            this.pblogo.BackgroundImage = global::CCP_FinalProj.Properties.Resources.IMG_1539_removebg_preview;
            this.pblogo.Image = global::CCP_FinalProj.Properties.Resources.IMG_1539_removebg_preview;
            this.pblogo.Location = new System.Drawing.Point(30, 11);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(100, 77);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // txt_firstname
            // 
            this.txt_firstname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_firstname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_firstname.Location = new System.Drawing.Point(160, 136);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(202, 30);
            this.txt_firstname.TabIndex = 4;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Location = new System.Drawing.Point(160, 177);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(202, 30);
            this.txt_lastname.TabIndex = 5;
            this.txt_lastname.TextChanged += new System.EventHandler(this.lblLastname_TextChanged);
            // 
            // dtp_checkin
            // 
            this.dtp_checkin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_checkin.Location = new System.Drawing.Point(198, 437);
            this.dtp_checkin.Name = "dtp_checkin";
            this.dtp_checkin.Size = new System.Drawing.Size(326, 30);
            this.dtp_checkin.TabIndex = 6;
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_checkout.Location = new System.Drawing.Point(708, 437);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(326, 30);
            this.dtp_checkout.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(94, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Check in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(589, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Check out:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(160, 268);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(202, 30);
            this.txt_email.TabIndex = 10;
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Location = new System.Drawing.Point(160, 312);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(202, 30);
            this.txt_contact.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(15, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(15, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contact No:";
            // 
            // numericUpDown_age
            // 
            this.numericUpDown_age.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_age.Location = new System.Drawing.Point(160, 226);
            this.numericUpDown_age.Name = "numericUpDown_age";
            this.numericUpDown_age.Size = new System.Drawing.Size(135, 30);
            this.numericUpDown_age.TabIndex = 16;
            // 
            // numericUpDown_adults
            // 
            this.numericUpDown_adults.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_adults.Location = new System.Drawing.Point(594, 136);
            this.numericUpDown_adults.Name = "numericUpDown_adults";
            this.numericUpDown_adults.Size = new System.Drawing.Size(122, 30);
            this.numericUpDown_adults.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(421, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "No. of Adults:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(421, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "No. of Children:";
            // 
            // numericUpDown_children
            // 
            this.numericUpDown_children.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_children.Location = new System.Drawing.Point(594, 177);
            this.numericUpDown_children.Name = "numericUpDown_children";
            this.numericUpDown_children.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_children.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(421, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 21;
            this.label10.Text = "Room Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(423, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Room Number:";
            // 
            // cmb_roomtype
            // 
            this.cmb_roomtype.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_roomtype.FormattingEnabled = true;
            this.cmb_roomtype.Location = new System.Drawing.Point(594, 271);
            this.cmb_roomtype.Name = "cmb_roomtype";
            this.cmb_roomtype.Size = new System.Drawing.Size(156, 32);
            this.cmb_roomtype.TabIndex = 23;
            // 
            // cmb_roomnumber
            // 
            this.cmb_roomnumber.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_roomnumber.FormattingEnabled = true;
            this.cmb_roomnumber.Location = new System.Drawing.Point(594, 315);
            this.cmb_roomnumber.Name = "cmb_roomnumber";
            this.cmb_roomnumber.Size = new System.Drawing.Size(156, 32);
            this.cmb_roomnumber.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(242, 527);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 28);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total Cost:";
            // 
            // txt_totalcost
            // 
            this.txt_totalcost.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalcost.Location = new System.Drawing.Point(350, 525);
            this.txt_totalcost.Name = "txt_totalcost";
            this.txt_totalcost.Size = new System.Drawing.Size(160, 30);
            this.txt_totalcost.TabIndex = 26;
            // 
            // btn_compute
            // 
            this.btn_compute.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compute.Location = new System.Drawing.Point(588, 522);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(126, 36);
            this.btn_compute.TabIndex = 27;
            this.btn_compute.Text = "Compute";
            this.btn_compute.UseVisualStyleBackColor = true;
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Location = new System.Drawing.Point(720, 522);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(126, 36);
            this.btn_pay.TabIndex = 28;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Location = new System.Drawing.Point(12, 534);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(38, 16);
            this.lbl_back.TabIndex = 29;
            this.lbl_back.Text = "Back";
            // 
            // cb_student
            // 
            this.cb_student.AutoSize = true;
            this.cb_student.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_student.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_student.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_student.Location = new System.Drawing.Point(817, 177);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(91, 27);
            this.cb_student.TabIndex = 30;
            this.cb_student.Text = "Student";
            this.cb_student.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(812, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "Discounts:";
            // 
            // cb_weekend
            // 
            this.cb_weekend.AutoSize = true;
            this.cb_weekend.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_weekend.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_weekend.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_weekend.Location = new System.Drawing.Point(817, 243);
            this.cb_weekend.Name = "cb_weekend";
            this.cb_weekend.Size = new System.Drawing.Size(159, 27);
            this.cb_weekend.TabIndex = 32;
            this.cb_weekend.Text = "Weekend Promo";
            this.cb_weekend.UseVisualStyleBackColor = false;
            // 
            // cb_senior
            // 
            this.cb_senior.AutoSize = true;
            this.cb_senior.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_senior.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_senior.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_senior.Location = new System.Drawing.Point(817, 210);
            this.cb_senior.Name = "cb_senior";
            this.cb_senior.Size = new System.Drawing.Size(137, 27);
            this.cb_senior.TabIndex = 33;
            this.cb_senior.Text = "Senior Citizen";
            this.cb_senior.UseVisualStyleBackColor = false;
            // 
            // cb_family
            // 
            this.cb_family.AutoSize = true;
            this.cb_family.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_family.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_family.ForeColor = System.Drawing.SystemColors.Control;
            this.cb_family.Location = new System.Drawing.Point(817, 276);
            this.cb_family.Name = "cb_family";
            this.cb_family.Size = new System.Drawing.Size(79, 27);
            this.cb_family.TabIndex = 34;
            this.cb_family.Text = "Family";
            this.cb_family.UseVisualStyleBackColor = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CCP_FinalProj.Properties.Resources.ravenclaw;
            this.ClientSize = new System.Drawing.Size(1094, 575);
            this.Controls.Add(this.cb_family);
            this.Controls.Add(this.cb_senior);
            this.Controls.Add(this.cb_weekend);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_compute);
            this.Controls.Add(this.txt_totalcost);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_roomnumber);
            this.Controls.Add(this.cmb_roomtype);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_children);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_adults);
            this.Controls.Add(this.numericUpDown_age);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_checkout);
            this.Controls.Add(this.dtp_checkin);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_adults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_children)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.DateTimePicker dtp_checkin;
        private System.Windows.Forms.DateTimePicker dtp_checkout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_age;
        private System.Windows.Forms.NumericUpDown numericUpDown_adults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_children;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_roomtype;
        private System.Windows.Forms.ComboBox cmb_roomnumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalcost;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.CheckBox cb_student;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_weekend;
        private System.Windows.Forms.CheckBox cb_senior;
        private System.Windows.Forms.CheckBox cb_family;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label label15;
    }
}