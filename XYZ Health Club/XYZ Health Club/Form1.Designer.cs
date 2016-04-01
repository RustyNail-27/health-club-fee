namespace XYZ_Health_Club
{
    partial class Form1
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
            this.membershipGroupBox = new System.Windows.Forms.GroupBox();
            this.familyRadioButton = new System.Windows.Forms.RadioButton();
            this.coupleRadioButton = new System.Windows.Forms.RadioButton();
            this.singleRadioButton = new System.Windows.Forms.RadioButton();
            this.additionalServicesGroupBox = new System.Windows.Forms.GroupBox();
            this.towelCheckBox = new System.Windows.Forms.CheckBox();
            this.raquetCheckBox = new System.Windows.Forms.CheckBox();
            this.tennisCheckBox = new System.Windows.Forms.CheckBox();
            this.calcFeeLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.membershipGroupBox.SuspendLayout();
            this.additionalServicesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // membershipGroupBox
            // 
            this.membershipGroupBox.Controls.Add(this.familyRadioButton);
            this.membershipGroupBox.Controls.Add(this.coupleRadioButton);
            this.membershipGroupBox.Controls.Add(this.singleRadioButton);
            this.membershipGroupBox.Location = new System.Drawing.Point(12, 12);
            this.membershipGroupBox.Name = "membershipGroupBox";
            this.membershipGroupBox.Size = new System.Drawing.Size(144, 112);
            this.membershipGroupBox.TabIndex = 1;
            this.membershipGroupBox.TabStop = false;
            this.membershipGroupBox.Text = "Memebership";
            // 
            // familyRadioButton
            // 
            this.familyRadioButton.AutoSize = true;
            this.familyRadioButton.Location = new System.Drawing.Point(11, 82);
            this.familyRadioButton.Name = "familyRadioButton";
            this.familyRadioButton.Size = new System.Drawing.Size(115, 17);
            this.familyRadioButton.TabIndex = 2;
            this.familyRadioButton.Text = "&Family ($65/month)";
            this.familyRadioButton.UseVisualStyleBackColor = true;
            this.familyRadioButton.CheckedChanged += new System.EventHandler(this.familyRadioButton_CheckedChanged);
            // 
            // coupleRadioButton
            // 
            this.coupleRadioButton.AutoSize = true;
            this.coupleRadioButton.Location = new System.Drawing.Point(11, 50);
            this.coupleRadioButton.Name = "coupleRadioButton";
            this.coupleRadioButton.Size = new System.Drawing.Size(119, 17);
            this.coupleRadioButton.TabIndex = 1;
            this.coupleRadioButton.Text = "&Couple ($55/month)";
            this.coupleRadioButton.UseVisualStyleBackColor = true;
            this.coupleRadioButton.CheckedChanged += new System.EventHandler(this.coupleRadioButton_CheckedChanged);
            // 
            // singleRadioButton
            // 
            this.singleRadioButton.AutoSize = true;
            this.singleRadioButton.Checked = true;
            this.singleRadioButton.Location = new System.Drawing.Point(11, 19);
            this.singleRadioButton.Name = "singleRadioButton";
            this.singleRadioButton.Size = new System.Drawing.Size(115, 17);
            this.singleRadioButton.TabIndex = 0;
            this.singleRadioButton.TabStop = true;
            this.singleRadioButton.Text = "&Single ($30/month)";
            this.singleRadioButton.UseVisualStyleBackColor = true;
            this.singleRadioButton.CheckedChanged += new System.EventHandler(this.singleRadioButton_CheckedChanged);
            // 
            // additionalServicesGroupBox
            // 
            this.additionalServicesGroupBox.Controls.Add(this.towelCheckBox);
            this.additionalServicesGroupBox.Controls.Add(this.raquetCheckBox);
            this.additionalServicesGroupBox.Controls.Add(this.tennisCheckBox);
            this.additionalServicesGroupBox.Location = new System.Drawing.Point(162, 12);
            this.additionalServicesGroupBox.Name = "additionalServicesGroupBox";
            this.additionalServicesGroupBox.Size = new System.Drawing.Size(167, 112);
            this.additionalServicesGroupBox.TabIndex = 2;
            this.additionalServicesGroupBox.TabStop = false;
            this.additionalServicesGroupBox.Text = "Additional Services";
            // 
            // towelCheckBox
            // 
            this.towelCheckBox.AutoSize = true;
            this.towelCheckBox.Location = new System.Drawing.Point(6, 83);
            this.towelCheckBox.Name = "towelCheckBox";
            this.towelCheckBox.Size = new System.Drawing.Size(155, 17);
            this.towelCheckBox.TabIndex = 2;
            this.towelCheckBox.Text = "To&wel Service ($10/month)";
            this.towelCheckBox.UseVisualStyleBackColor = true;
            this.towelCheckBox.CheckedChanged += new System.EventHandler(this.towelCheckBox_CheckedChanged);
            // 
            // raquetCheckBox
            // 
            this.raquetCheckBox.AutoSize = true;
            this.raquetCheckBox.Location = new System.Drawing.Point(6, 51);
            this.raquetCheckBox.Name = "raquetCheckBox";
            this.raquetCheckBox.Size = new System.Drawing.Size(144, 17);
            this.raquetCheckBox.TabIndex = 1;
            this.raquetCheckBox.Text = "&Racquetball ($10/month)";
            this.raquetCheckBox.UseVisualStyleBackColor = true;
            this.raquetCheckBox.CheckedChanged += new System.EventHandler(this.raquetCheckBox_CheckedChanged);
            // 
            // tennisCheckBox
            // 
            this.tennisCheckBox.AutoSize = true;
            this.tennisCheckBox.Location = new System.Drawing.Point(6, 20);
            this.tennisCheckBox.Name = "tennisCheckBox";
            this.tennisCheckBox.Size = new System.Drawing.Size(119, 17);
            this.tennisCheckBox.TabIndex = 0;
            this.tennisCheckBox.Text = "&Tennis ($20/month)";
            this.tennisCheckBox.UseVisualStyleBackColor = true;
            this.tennisCheckBox.CheckedChanged += new System.EventHandler(this.tennisCheckBox_CheckedChanged);
            // 
            // calcFeeLabel
            // 
            this.calcFeeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.calcFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcFeeLabel.Location = new System.Drawing.Point(162, 137);
            this.calcFeeLabel.Name = "calcFeeLabel";
            this.calcFeeLabel.Size = new System.Drawing.Size(73, 23);
            this.calcFeeLabel.TabIndex = 2;
            this.calcFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Location = new System.Drawing.Point(22, 142);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(134, 13);
            this.feeLabel.TabIndex = 3;
            this.feeLabel.Text = "Monthly Membership Total:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 181);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 26);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 222);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.calcFeeLabel);
            this.Controls.Add(this.additionalServicesGroupBox);
            this.Controls.Add(this.membershipGroupBox);
            this.Name = "Form1";
            this.membershipGroupBox.ResumeLayout(false);
            this.membershipGroupBox.PerformLayout();
            this.additionalServicesGroupBox.ResumeLayout(false);
            this.additionalServicesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox membershipGroupBox;
        private System.Windows.Forms.RadioButton familyRadioButton;
        private System.Windows.Forms.RadioButton coupleRadioButton;
        private System.Windows.Forms.RadioButton singleRadioButton;
        private System.Windows.Forms.GroupBox additionalServicesGroupBox;
        private System.Windows.Forms.CheckBox towelCheckBox;
        private System.Windows.Forms.CheckBox raquetCheckBox;
        private System.Windows.Forms.CheckBox tennisCheckBox;
        private System.Windows.Forms.Label calcFeeLabel;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

