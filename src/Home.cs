using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRay
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
           
            
        }

        public void addusercontrol(UserControl usercontrol)
        {
            HomePage a = new HomePage();
            usercontrol.Dock = DockStyle.Fill;
            a.panelcontainer.Controls.Clear();
            a.panelcontainer.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvisitus_Click(object sender, EventArgs e)
        {
            UCNetwork uCNetwork = new UCNetwork();
            addusercontrol(uCNetwork);
        }
    }
}
