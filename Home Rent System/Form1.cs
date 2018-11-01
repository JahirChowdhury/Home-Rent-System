using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Home_Rent_System
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_username_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            UserList ul = new UserList();

            if (textBox1.Text == "admin" && textBox2.Text =="admin")
            {
                Admin_Form af = new Admin_Form();
                af.Show();
                this.Hide();
            }
            if(textBox1.Text== "hr")
            {
                Home_renter_view hrv = new Home_renter_view();
                hrv.Show();
                this.Hide();
            }
            if(textBox1.Text=="lo")
            {
                Landowner_View lo = new Landowner_View();
                lo.Show();
                this.Hide();
            }

        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Account ca = new Create_Account();
            ca.Show();
            this.Hide();
        }

    }
}
