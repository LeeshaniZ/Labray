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
    public partial class UCAppoinment : UserControl
    {
        public UCAppoinment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wishm\Downloads\LabRay\LabRay\LabRay\Doctors.mdf;Integrated Security=True");
        private void populate_appointments()
        {
            Con.Open();
            string query = "select * from ApptTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            appointmentViewDG.DataSource = ds.Tables[0];
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
        private void UCAppoinment_Load(object sender, EventArgs e)
        {
            populate_appointments();
            FillName();
        }

        private void DoctorsCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TimeTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void appointmentViewDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.appointmentViewDG.Rows[e.RowIndex];
                
                DoctorsCb.SelectedValue = row.Cells["Doctor"].Value?.ToString();
                dateTimePicker2.Text = row.Cells["Date"].Value?.ToString();
                TimeTb.Text = row.Cells["Time"].Value?.ToString();
                if(txtboxappid.Text == "")
                {
                    key = Convert.ToInt32(row.Cells["Id"].Value?.ToString() ?? "0");
                }
                else
                {
                    key = Convert.ToInt32(txtboxappid.Text);
                }
                
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Doctor To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from ApptTbl where Id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Deleted Successfully!");
                    Con.Close();
                    populate_appointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnremoveappointment_Click(object sender, EventArgs e)
        {
            if (key == 0 || dateTimePicker2.Text == "" || TimeTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
                Con.Close();
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ApptTbl set Doctor='" + DoctorsCb.SelectedValue + "', Date='" + dateTimePicker2.Text + "', Time='" + TimeTb.Text + "' where Id=" + key + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Updated Successfully!");
                    Con.Close();
                    populate_appointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
