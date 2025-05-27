using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace LabRay
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            UCHome uc = new UCHome();
            addusercontrol(uc);
            
             
        }

        public void addusercontrol(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            panelcontainer.Controls.Clear();
            panelcontainer.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UCHome uc = new UCHome();
            addusercontrol(uc);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Your progress will be lost?","Log Out",MessageBoxButtons.OK,MessageBoxIcon.Question);
            Form1 a = new Form1();
            a.Show();
            this.Close();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panelcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnchanneling_Click(object sender, EventArgs e)
        {
            UCChanneling channeling = new UCChanneling();
            addusercontrol(channeling);
        }

        private void btnlistoftests_Click(object sender, EventArgs e)
        {
            UCListoftets channeling = new UCListoftets();
            addusercontrol(channeling);
        }

        private void btnpersonalrecords_Click(object sender, EventArgs e)
        {
            UCAppoinment channeling = new UCAppoinment();
            addusercontrol(channeling);
        }

        

        private void btnlaboratorynetwork_Click(object sender, EventArgs e)
        {
            UCNetwork channeling = new UCNetwork();
            addusercontrol(channeling);
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            UCRecords channeling = new UCRecords();
            addusercontrol(channeling);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            UpdateProfile a = new UpdateProfile();
            a.Show();
            
        }
    }
}
