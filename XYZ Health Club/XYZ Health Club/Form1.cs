/****    
*
* Name: Russell Walton
* Student Number: T00249622
* Seminar Number: 3
* Due Date:  Feb. 1, 2015
*
* Program Purpose:  Calculate and dislay the monthly fees for a new memeber of
 * the XYZ health club.  Set access keys, tab-index and focus.
*
****/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZ_Health_Club
{
    public partial class Form1 : Form
    {
        const decimal SINGLE_FEE = 30.00m;
        const decimal COUPLE_FEE = 55.00m;
        const decimal FAMILY_FEE = 65.00m;
        const decimal TENNIS_FEE = 20.00m;
        const decimal RACQUET_FEE = 10.00m;
        const decimal TOWEL_FEE = 10.00m;

        private decimal total = 0.00m;

        public Form1()
        {
            InitializeComponent();

            total = 30.00m;

            calcFeeLabel.Text = total.ToString("c");
        }

        private void singleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (singleRadioButton.Checked)
            {
                total += SINGLE_FEE;
                calcFeeLabel.Text = total.ToString("c");
                tennisCheckBox.Focus();
            }
            else
            {
                total = total - SINGLE_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void coupleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (coupleRadioButton.Checked)
            {
                total += COUPLE_FEE;
                calcFeeLabel.Text = total.ToString("c");
                tennisCheckBox.Focus();
            }
            else
            {
                total = total - COUPLE_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void familyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (familyRadioButton.Checked)
            {
                total += FAMILY_FEE;
                calcFeeLabel.Text = total.ToString("c");
                tennisCheckBox.Focus();
            }
            else
            {
                total = total - FAMILY_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void tennisCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tennisCheckBox.Checked)
            {
                total += TENNIS_FEE;
                calcFeeLabel.Text = total.ToString("c");
                raquetCheckBox.Focus();
            }
            else
            {
                total = total - TENNIS_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void raquetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (raquetCheckBox.Checked)
            {
                total += RACQUET_FEE;
                calcFeeLabel.Text = total.ToString("c");
                towelCheckBox.Focus();
            }
            else
            {
                total = total - RACQUET_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void towelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (towelCheckBox.Checked)
            {
                total += TOWEL_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
            else
            {
                total = total - TOWEL_FEE;
                calcFeeLabel.Text = total.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
