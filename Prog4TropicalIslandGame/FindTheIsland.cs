/*Name: Fidelis Msacky
  Course: CMPS4143 - Contemporary Prog. Lang.
  Prof: C. Stringfellow 
  Programming Assignment 4
  Date: 9/29/2014
 
  Summary: This program utilises two classes to simulate 
           a find the island game.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4TropicalIslandGame
{
    public partial class FindTheIslandGame : Form
    {
        string lengthinput;
        string widthinput;
        string error;
        int rows = 0;
        int cols = 0;

        public FindTheIslandGame()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lengthinput = Length.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            widthinput = Width.Text;
        }

        // Play Game Button
        private void button1_Click(object sender, EventArgs e)
        {
            rows = Int32.Parse(lengthinput);
            cols = Int32.Parse(widthinput);

            if ((rows > 25) || (cols > 25))
            {
                error = (rows > 25) ? "Error: Row size cannot exceed 25" : "Error: Column size cannot exceed 25";
                MessageBox.Show(error);
            }

            else if (((rows <= 0) || (cols <= 0)))
            {
                error = (rows <= 0) ? "Error: Row size cannot be negative or zero" : "Error: Column size cannot be negative or zero";
                MessageBox.Show(error);
            }

            else
            {    
                Form myForm = new NavigationSystem(rows, cols);
                myForm.Show();
                this.Hide();
            }
        }
    }
}
