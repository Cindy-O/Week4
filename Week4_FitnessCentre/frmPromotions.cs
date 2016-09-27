using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_FitnessCentre
{
    public partial class frmPromotions : Form
    {
        public frmPromotions()
        {
            InitializeComponent();
        }

        private void frmPromotions_Load(object sender, EventArgs e)
        {
            //defaults settings when the form loads
            grpDepartment.Enabled = false;
            rtfWelcome.Visible = false;
            txtPromotion.Visible = false;
            picDepartment.Visible = false;
            chkImageVisible.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Allow the user to sign in and show welcome message
            rtfWelcome.Visible = true;
            rtfWelcome.Text = "Welcome: " + txtName.Text + ".\nMember ID: " + mskMemberID.Text;

            //hide the controls we don't need.
            lblName.Visible = false;
            lblMemberID.Visible = false;
            txtName.Visible = false;
            mskMemberID.Visible = false;

            //Show the controls that are required.
            grpDepartment.Enabled = true;
            chkImageVisible.Visible = true;
            picDepartment.Visible = true;
            txtPromotion.Visible = true;

            //disable Sign In
            btnSignIn.Enabled = false;
        }
    }
}
