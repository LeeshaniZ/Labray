using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Integreating ADO.NET to the application
using System.Data.SqlClient;

namespace LabRay
{
    public partial class Registration : Form
    {

        //creating a connection to the DB
        SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wishm\Downloads\LabRay\LabRay\LabRay\LoginDatabase1.mdf;Integrated Security=True");

        public Registration()
        {
            InitializeComponent();
        }

        private void txtboxfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void txtboxlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxdob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxconfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxfname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            if (txtboxfname.Text == "")
            {
                lblfnameerror.Text = "Enter your name";
                lblfnameerror.Visible = true;
            }

            if (txtboxusername.Text == "")
            {
                lblusererror.Text = "Enter a username";
                lblusererror.Visible = true;
            }

            if (txtboxpassword.Text == "")
            {
                lblpasserror.Text = "Enter a password";
                lblpasserror.Visible = true;
            }

            if (txtboxconfirmpass.Text == "")
            {
                lblretypeerror.Text = "Re type your password";
                lblretypeerror.Visible = true;
            }

            if (txtboxemail.Text == "")
            {
                lblmailerror.Text = "Enter your email";
                lblmailerror.Visible = true;
            }

            if (txtboxpassword.Text != "" && txtboxconfirmpass.Text != "")
            {
                if (txtboxpassword.Text != txtboxconfirmpass.Text)
                {
                    txtboxconfirmpass.Text = "";
                    lblretypeerror.Text = "Password doesn't match,Re-Enter";
                }
                if(txtboxusername.Text != "")
                {
                    try
                    {
                        //SQL DATABASE IMPLEMENTATION
                        string Query = $"INSERT INTO Admins(username,password) VALUES ('{txtboxusername.Text}','{txtboxpassword.Text}')";

                        //Crating SQL Commands
                        SqlCommand cmd = new SqlCommand(Query, connection1);

                        //OPENING CONNECTION TO THE DATABASE
                        connection1.Open();

                        //Executing the SQL COMMAND
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    Form1 form = new Form1();

                    form.Show();
                    Close();
                }
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxpassword.UseSystemPasswordChar = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtboxconfirmpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxconfirmpass.UseSystemPasswordChar = true;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtboxfname.Text = "";
            lblfnameerror.Text = "";
            txtboxemail.Text = "";
            lblmailerror.Text = "";
            txtboxconfirmpass.Text = "";
            lblpasserror.Text = "";
            txtboxpassword.Text = "";
            lblusererror.Text = "";
            txtboxusername.Text = "";
            lblretypeerror.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
