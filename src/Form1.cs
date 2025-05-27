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
using System.Collections;


namespace LabRay
{
    public partial class Form1 : Form
    {
        public string user;
        
        SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wishm\Downloads\LabRay\LabRay\LabRay\LabRayDatabase.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();



        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtboxuser_TextChanged(object sender, EventArgs e)
        {
            lblusererror.Visible = false;
        }

        private void txtboxpass_TextChanged(object sender, EventArgs e)
        {
            lblpasserror.Visible = false;

        }

        private void txtboxpass_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncreataccount_Click(object sender, EventArgs e)
        {
            Registration a = new Registration();
            a.Show();
            Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection1.Open();
            string login = "SELECT * FROM Admins WHERE username= '" + txtboxuser.Text + " ' and password= '" + txtboxpass.Text + "'";
            cmd = new SqlCommand(login,connection1);
            SqlDataReader rdr = cmd.ExecuteReader();

            
            if (rdr.Read() == false)
            {

                MessageBox.Show("Username/Password Incorrect", "Incorrect Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                connection1.Close();
            }
            else 
            {
                user = rdr[0].ToString();
                Loading b = new Loading();
                b.Show();
                this.Hide();
                connection1.Close();
            }

            if (txtboxuser.Text == "")
            {
                lblusererror.Text = "Enter your username";
                lblusererror.Visible = true;
            }
            else
            {
                lblusererror.Visible = false;
            }

            if (txtboxpass.Text == "")
            {
                lblpasserror.Text = "Enter your password";
                lblpasserror.Visible = true;
            }
            else
            {
                lblusererror.Visible = false;
            }


        }

        private void txtboxpass_HideSelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtboxpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
            }
        }

        private void lnklblforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtboxpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtboxpass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblusererror_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
