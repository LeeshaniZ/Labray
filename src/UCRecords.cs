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
    public partial class UCRecords : UserControl
    {
        public UCRecords()
        {
            InitializeComponent();
        }

        private void btndeliver_Click(object sender, EventArgs e)
        {
            if(txtboxfname.Text!="" && txtboxaddress.Text != "" && txtboxdeliverreceipt.Text != "" && (txtboxtpnum.Text) != "")
            {
                MessageBox.Show("You will recieve your report within 24 hours","Report Delivery",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill in all details","Missing information",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (txtboxemail.Text != "" && txtboxmailreciept.Text != "" )
            {
                MessageBox.Show("You will recieve your report within 24 hours", "Report Delivery", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill in all details", "Missing information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
