namespace Week4_FitnessCentre
{
    partial class frmPromotions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskMemberID = new System.Windows.Forms.MaskedTextBox();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.radClothing = new System.Windows.Forms.RadioButton();
            this.radEquipment = new System.Windows.Forms.RadioButton();
            this.radJuiceBar = new System.Windows.Forms.RadioButton();
            this.radMembership = new System.Windows.Forms.RadioButton();
            this.radPersonalTraining = new System.Windows.Forms.RadioButton();
            this.rtfWelcome = new System.Windows.Forms.RichTextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.chkImageVisible = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Look Sharp Fitness Centre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(673, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cindy Orbegoso";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 610);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 799;
            this.lineShape1.Y1 = 67;
            this.lineShape1.Y2 = 67;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(454, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(430, 196);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(59, 13);
            this.lblMemberID.TabIndex = 2;
            this.lblMemberID.Text = "Member &ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(518, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 20);
            this.txtName.TabIndex = 1;
            // 
            // mskMemberID
            // 
            this.mskMemberID.Location = new System.Drawing.Point(518, 193);
            this.mskMemberID.Mask = "00000";
            this.mskMemberID.Name = "mskMemberID";
            this.mskMemberID.Size = new System.Drawing.Size(42, 20);
            this.mskMemberID.TabIndex = 3;
            this.mskMemberID.ValidatingType = typeof(int);
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.radPersonalTraining);
            this.grpDepartment.Controls.Add(this.radMembership);
            this.grpDepartment.Controls.Add(this.radJuiceBar);
            this.grpDepartment.Controls.Add(this.radEquipment);
            this.grpDepartment.Controls.Add(this.radClothing);
            this.grpDepartment.Location = new System.Drawing.Point(25, 109);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(330, 281);
            this.grpDepartment.TabIndex = 5;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Department";
            // 
            // radClothing
            // 
            this.radClothing.AutoSize = true;
            this.radClothing.Location = new System.Drawing.Point(34, 30);
            this.radClothing.Name = "radClothing";
            this.radClothing.Size = new System.Drawing.Size(63, 17);
            this.radClothing.TabIndex = 0;
            this.radClothing.TabStop = true;
            this.radClothing.Text = "&Clothing";
            this.radClothing.UseVisualStyleBackColor = true;
            // 
            // radEquipment
            // 
            this.radEquipment.AutoSize = true;
            this.radEquipment.Location = new System.Drawing.Point(34, 84);
            this.radEquipment.Name = "radEquipment";
            this.radEquipment.Size = new System.Drawing.Size(137, 17);
            this.radEquipment.TabIndex = 1;
            this.radEquipment.TabStop = true;
            this.radEquipment.Text = "&Equipment/Accessories";
            this.radEquipment.UseVisualStyleBackColor = true;
            // 
            // radJuiceBar
            // 
            this.radJuiceBar.AutoSize = true;
            this.radJuiceBar.Location = new System.Drawing.Point(34, 138);
            this.radJuiceBar.Name = "radJuiceBar";
            this.radJuiceBar.Size = new System.Drawing.Size(69, 17);
            this.radJuiceBar.TabIndex = 2;
            this.radJuiceBar.TabStop = true;
            this.radJuiceBar.Text = "&Juice Bar";
            this.radJuiceBar.UseVisualStyleBackColor = true;
            // 
            // radMembership
            // 
            this.radMembership.AutoSize = true;
            this.radMembership.Location = new System.Drawing.Point(34, 192);
            this.radMembership.Name = "radMembership";
            this.radMembership.Size = new System.Drawing.Size(82, 17);
            this.radMembership.TabIndex = 3;
            this.radMembership.TabStop = true;
            this.radMembership.Text = "&Membership";
            this.radMembership.UseVisualStyleBackColor = true;
            // 
            // radPersonalTraining
            // 
            this.radPersonalTraining.AutoSize = true;
            this.radPersonalTraining.Location = new System.Drawing.Point(34, 246);
            this.radPersonalTraining.Name = "radPersonalTraining";
            this.radPersonalTraining.Size = new System.Drawing.Size(107, 17);
            this.radPersonalTraining.TabIndex = 4;
            this.radPersonalTraining.TabStop = true;
            this.radPersonalTraining.Text = "Personal &Training";
            this.radPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // rtfWelcome
            // 
            this.rtfWelcome.Location = new System.Drawing.Point(518, 257);
            this.rtfWelcome.Name = "rtfWelcome";
            this.rtfWelcome.ReadOnly = true;
            this.rtfWelcome.Size = new System.Drawing.Size(251, 61);
            this.rtfWelcome.TabIndex = 13;
            this.rtfWelcome.TabStop = false;
            this.rtfWelcome.Text = "";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(518, 355);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ReadOnly = true;
            this.txtPromotion.Size = new System.Drawing.Size(251, 20);
            this.txtPromotion.TabIndex = 14;
            this.txtPromotion.TabStop = false;
            // 
            // picDepartment
            // 
            this.picDepartment.Location = new System.Drawing.Point(25, 422);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(330, 128);
            this.picDepartment.TabIndex = 10;
            this.picDepartment.TabStop = false;
            // 
            // chkImageVisible
            // 
            this.chkImageVisible.AutoSize = true;
            this.chkImageVisible.Location = new System.Drawing.Point(25, 571);
            this.chkImageVisible.Name = "chkImageVisible";
            this.chkImageVisible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageVisible.Size = new System.Drawing.Size(88, 17);
            this.chkImageVisible.TabIndex = 6;
            this.chkImageVisible.Text = "Image &Visible";
            this.chkImageVisible.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(656, 390);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(113, 37);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(656, 476);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 37);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(656, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(656, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPromotions
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.chkImageVisible);
            this.Controls.Add(this.picDepartment);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.rtfWelcome);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.mskMemberID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.Load += new System.EventHandler(this.frmPromotions_Load);
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mskMemberID;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RadioButton radPersonalTraining;
        private System.Windows.Forms.RadioButton radMembership;
        private System.Windows.Forms.RadioButton radJuiceBar;
        private System.Windows.Forms.RadioButton radEquipment;
        private System.Windows.Forms.RadioButton radClothing;
        private System.Windows.Forms.RichTextBox rtfWelcome;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.PictureBox picDepartment;
        private System.Windows.Forms.CheckBox chkImageVisible;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

