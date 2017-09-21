using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Add_And_Subtyract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            //-- Make two arrays. One holds the numbers to add andthe other holds the output text box
            Double[,] mainArray = new Double[9, 2];
            TextBox[] ouputVector = { C1, C2, C3, C4, C5, C6, C7, C8, C9 };
            try
            {
                //-- Fill the first array with the numbers to add
                mainArray = new Double[9, 2]{
                {Convert.ToDouble(A1.Text), Convert.ToDouble(B1.Text)},
                {Convert.ToDouble(A2.Text), Convert.ToDouble(B2.Text)},
                {Convert.ToDouble(A3.Text), Convert.ToDouble(B3.Text)},
                {Convert.ToDouble(A4.Text), Convert.ToDouble(B4.Text)},
                {Convert.ToDouble(A5.Text), Convert.ToDouble(B5.Text)},
                {Convert.ToDouble(A6.Text), Convert.ToDouble(B6.Text)},
                {Convert.ToDouble(A7.Text), Convert.ToDouble(B7.Text)},
                {Convert.ToDouble(A8.Text), Convert.ToDouble(B8.Text)},
                {Convert.ToDouble(A9.Text), Convert.ToDouble(B9.Text)}};

            } catch (Exception) { MessageBox.Show("Only numbers are accepted!", "Sorry ):", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            //-- loop through each entry and fill out the answer for each entry box
            for (int x = 0; x <= 8; x++)
            {
                //-- Check to see if addition or subtraction  was selected
                switch (cBoxSelect.SelectedIndex)
                {
                    case 0:
                        //-- Set the value of the output entry
                        ouputVector[x].Text = Convert.ToString(mainArray[x, 0] + mainArray[x, 1]);
                        break;
                    case 1:
                        //-- Set the value of the output entry
                        ouputVector[x].Text = Convert.ToString(mainArray[x, 0] - mainArray[x, 1]);
                        break;
                    default:
                        //-- Return error asking the user to seelct Addition or Subtraction
                        MessageBox.Show("Select Add or Subtract", "Sorry ):", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }
            }
        }
    }
}
