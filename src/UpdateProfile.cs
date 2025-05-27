using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRay
{
    public partial class UpdateProfile : Form
    {
        public string user;
        public string pass;
        public UpdateProfile()
        {
            InitializeComponent();
        }

        


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtboxuser.Text != "" || txtboxchangepass.Text != "")
            {
                 HomePage a = new HomePage();
                 a.btnprofile.Text = txtboxuser.Text;
                 pass = txtboxchangepass.Text;
                 this.Close();
            }
            else
            {
                MessageBox.Show("No changes made", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Picbox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
