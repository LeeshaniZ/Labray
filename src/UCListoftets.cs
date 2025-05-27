using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRay
{
    public partial class UCListoftets : UserControl
    {
        public UCListoftets()
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

        private void btnvisitus_Click(object sender, EventArgs e)
        {
            UCNetwork uCNetwork = new UCNetwork();
            addusercontrol(uCNetwork);
        }
    }
}
