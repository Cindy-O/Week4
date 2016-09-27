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
            txtPromotion.Visible = true;

            //disable Sign In
            btnSignIn.Enabled = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print the form
            printForm1.Print();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the form to its start default state.
            Application.Restart();
        }

        private void radClothing_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for clothing
            txtPromotion.Text = "30% off clearance items";
            picDepartment.Image = Properties.Resources.clothing;
        }

        private void radEquipment_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for Equipment and Accessories
            txtPromotion.Text = "30% off all Equipment";
            picDepartment.Image = Properties.Resources.Equipment;
        }

        private void radJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for Juice Bar
            txtPromotion.Text = "free serving of Wheatberry shake";
            picDepartment.Image = Properties.Resources.JuiceBar;
        }

        private void radMembership_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for Membership
            txtPromotion.Text = "Free personal trainer for the first month";
            picDepartment.Image = Properties.Resources.Membership;
        }

        private void radPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            //show the corresponding promotion and picture for Personal Training
            txtPromotion.Text = "3 free sessions with membership renewal";
            picDepartment.Image = Properties.Resources.PersonalTraining;
        }

        private void chkImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            //picture display if ImageVisible checked
            picDepartment.Visible = chkImageVisible.Checked;
        }
    }
}
