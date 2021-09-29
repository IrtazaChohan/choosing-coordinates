using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace choosing_coordinates
{
    public partial class FrmCoordinates : Form
    {
        public FrmCoordinates()
        {
            InitializeComponent();
        }

        //Write a C# Sharp program to accept a coordinate point in an XY coordinate
        //system and determine in which quadrant the coordinate point lies
        //Test Data :
        //Input the value for X coordinate :7
        //Input the value for Y coordinate :9
        //Expected Output :
        //The coordinate point(7,9) lies in the First quadrant.

        int xcoordinate = 0;
        int ycoordinate = 0;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            xcoordinate = int.Parse(txtTextBox1.Text);
            ycoordinate = int.Parse(txtTextBox2.Text);

            if ((xcoordinate >= 1 && xcoordinate <= 3) && (ycoordinate >= 1 && ycoordinate <= 3))
            {
                lblResult.Text = "You chose " + xcoordinate + "," + ycoordinate + " which is the first quadrant";
                lblResult.Visible = true;
            }
            else if ((xcoordinate >= 4 && xcoordinate <= 6) && (ycoordinate >= 4 && ycoordinate <= 6))
            {
                lblResult.Text = "You chose " + xcoordinate + "," + ycoordinate + " which is the second quadrant";
                lblResult.Visible = true;
            }
            else if ((xcoordinate >= 7 && xcoordinate <= 9) && (ycoordinate >= 7 && ycoordinate <= 9))
            {
                lblResult.Text = "You chose " + xcoordinate + "," + ycoordinate + " which is the third quadrant";
                lblResult.Visible = true;
            }
            else if ((xcoordinate >= 10 && xcoordinate <= 12) && (ycoordinate >= 10 && ycoordinate <= 12))
            {
                lblResult.Text = "You chose " + xcoordinate + "," + ycoordinate + " which is the forth quadrant";
                lblResult.Visible = true;
            }
            else
            {
                lblResult.Text = "You chose " + xcoordinate + "," + ycoordinate + " which is not in any quadrant";
                lblResult.Visible = true;
            }
        }
    }
}
