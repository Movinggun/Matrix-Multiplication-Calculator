/****************************************
 *         Ghetto Matrix Calc           *
 *      Created By Movinggun Software   *
 * **************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //-- Declare 2 multi dimensional arrays AL equals the first Matrix Grid and BL equals the second
            Double[,] AL = new Double[3, 3];
            Double[,] BL = new Double[3, 3];

            //-- Declare array to hold the numbers which are added up
            Double[] numbers = new Double[3];

            //-- ColStacks pushes the stack across each columm at the correct time. fillResult is used to workout which value gets placed in each textbox
            int ColStack = 0;
            int fillResult = 0;

            //-- Checks to see if the user entered a float value in the box.
            try {
                //-- Fill both arrays with the information from the textboxes 
                AL = new Double[3, 3] {{ Convert.ToDouble(A1.Text), Convert.ToDouble(A2.Text), Convert.ToDouble(A3.Text)},  
                {Convert.ToDouble(A4.Text), Convert.ToDouble(A5.Text), Convert.ToDouble(A6.Text)}, 
                {Convert.ToDouble(A7.Text), Convert.ToDouble(A8.Text), Convert.ToDouble(A9.Text)}};

                BL = new Double[3, 3] {{ Convert.ToDouble(B1.Text), Convert.ToDouble(B2.Text), Convert.ToDouble(B3.Text)},
                {Convert.ToDouble(B4.Text), Convert.ToDouble(B5.Text), Convert.ToDouble(B6.Text)}, 
                {Convert.ToDouble(B7.Text),Convert.ToDouble(B8.Text), Convert.ToDouble(B9.Text)}};
            } catch(Exception) {
                //-- Throw error as the user entered a non float value
                MessageBox.Show("Only numbers are accepted!", "Sorry ):", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //-- Loops through evey row from the first section
            for (int x = 0; x <= 2; x++)
            {
                //-- sets ColStack to 0. This means we have moved onto the next columm
                ColStack = 0;

                //-- This loops through every columm and outputs values to the textboxes
                for (int y = 0; y <= 2; y++)
                {
                    //-- This loop does all the math. It will loop through each row and columm one by one and multiply the values together
                    for (int z = 0; z <= 2; z++)
                    {
                        //-- P gets the number form the row which it will use
                        Double p = AL[x, z];
                        //-- L will get the number from the columm which it will use
                        Double l = BL[ColStack, z];
                        //--  This will write p * z to the numbers array. This array stores all the values needed to work out 1 number for the new metrix 
                        numbers[z] = p * l;
                    }
                    //-- When the loop has finished and the array is full from 0 - 2 it will add these numbers up. When these numbers are added up we get the result of a single value for the third metrix
                    Double kk = numbers[0] + numbers[1] + numbers[2];
                   
                    //-- Here we are adding 1 to the ColStgack and FillResults variable. This means it has finished finding the value for one of the numbers in the matrix
                    ColStack++;
                    fillResult++;

                    //-- Switch statment which uses the finResult variable. When the code works out one of the answers it will set the text on the third text box correctly
                    switch (fillResult)
                    {
                        case 1:
                            C1.Text = Convert.ToString(kk);
                            break;
                        case 2:
                            C2.Text = Convert.ToString(kk);
                            break;
                        case 3:
                            C3.Text = Convert.ToString(kk);
                            break;
                        case 4:
                            C4.Text = Convert.ToString(kk);
                            break;
                        case 5:
                            C5.Text = Convert.ToString(kk);
                            break;
                        case 6:
                            C6.Text = Convert.ToString(kk);
                            break;
                        case 7:
                            C7.Text = Convert.ToString(kk);
                            break;
                        case 8:
                            C8.Text = Convert.ToString(kk);
                            break;
                        case 9:
                            C9.Text = Convert.ToString(kk);
                            break;
                    }

                }
            }

        }

        private void A2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
