using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRay
{
    public partial class UCChanneling : UserControl
    {
        public UCChanneling()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wishm\Downloads\LabRay\LabRay\LabRay\Doctors.mdf;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = "select * from Doctors";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Doctors", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Load(rdr);
            DoctorsCb.ValueMember = "Name";
            DoctorsCb.DataSource = dt;
            Con.Close();
        }
        private void UCChanneling_Load(object sender, EventArgs e)
        {
            populate();
            FillName();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctors_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Channel_Click(object sender, EventArgs e)
        {
            if (DoctorsCb.Text == "" || TimeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into ApptTbl values('" + DoctorsCb.SelectedValue.ToString() + "','" + dateTimePicker2.Text + "','" + TimeTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Successfully Recorded");
                    Con.Close();
                    DoctorsCb.Text = "";
                    TimeTb.Text = "";


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
