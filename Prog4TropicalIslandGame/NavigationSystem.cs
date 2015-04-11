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
    public partial class NavigationSystem : Form
    {
        string userrow;
        string usercol;

        bool[,] Map;
        int userturn = 0;

        int randrow = 0;
        int randcol = 0;

        int linerows = 0;
        int linecols = 0;
        public NavigationSystem()
        {
            InitializeComponent();
        }

        public NavigationSystem(int rows, int cols)
        {
            InitializeComponent();

            linecols = cols;
            linerows = rows;

            MapSize.Text = linerows.ToString() + " x " + linecols.ToString();
                       
            int adjrow = (((rows + 5) * 20) + 80); // Adjust row to fit groupbox
            int adjcol = ((cols + 3) * 20);

            // Ensure width is reasonable
            if (adjcol <= 300)
            {
                adjcol = 300;
            }
            
            // Set form size
            this.Size = new Size(adjcol, adjrow);

            Random Isle = new Random();
            randrow = Isle.Next(1, rows);
            randcol = Isle.Next(1, cols);

            // For Debugging - Enable this and ToString to print location
            // of island to screen 
            // string temp = ToString(randrow, randcol);
            // MessageBox.Show(temp);

            // Allocate array and set location of Island
            Map = new bool[rows, cols];
            Map[randrow - 1, randcol - 1] = true;

            userturn = 0;
                        
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();

            Pen myPen = new Pen(System.Drawing.Color.Black, 5);

            //Draw Border
            Rectangle myRectangle = new Rectangle(20, 20, (linecols * 20), (linerows * 20));
            graphicsObj.DrawRectangle(myPen, myRectangle);

            //Row Pen
            myPen.Color = System.Drawing.Color.Black;
            myPen.Width = 3;

            int i = 0;
            int xval = 20;
            int yval = 20;

            // Draw Rows
            for (i = 0; i < linerows; i++)
            {
                graphicsObj.DrawLine(myPen, 20, yval, ((linecols + 1) * 20), yval);
                yval += 20;
            }

            myPen.Color = System.Drawing.Color.Black;
            myPen.Width = 3;

            // Draw Cols
            for (i = 0; i < linecols; i++)
            {
                graphicsObj.DrawLine(myPen, xval, 20, xval, ((linerows + 1) * 20));
                xval += 20;
            }


            // Create string to draw.
            String drawString = "~";
            // Create font and brush.
            Font drawFont = new Font("Courier New", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            // Create point for upper-left corner of drawing.

            PointF drawPoint = new PointF(20.0F, 20.0F);
            
            // Draw ~ to screen.
            for (int j = 0; j < linerows; j++)
            {
                for (i = 0; i < linecols; i++)
                {
                    e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                    drawPoint.X += 20.0F;
                }
                drawPoint.Y += 20.0F; // increment row counter
                drawPoint.X = 20.0F; // Reset next column
            }

            drawBrush = new SolidBrush(Color.Gray);

            // Add Column Lable
            drawPoint.Y = 0.0F; // increment row counter
            drawPoint.X = 20.0F; // Reset next column
            drawFont = new Font("Courier New", 10);
            
            i = 0;
            do
            {
                drawString = (i+1).ToString();
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                drawPoint.X += 20.0F; 
                i++;
            } while (i < linecols);

            // Add Row Lable
            drawPoint.Y = 20.0F; // increment row counter
            drawPoint.X = 0.0F; // Reset next column

            i = 0;
            do
            {
                drawString = (i + 1).ToString();
                e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
                drawPoint.Y += 20.0F;
                i++;
            } while (i < linerows);
                        
            // Enable to show island location on map
            /*System.Drawing.Graphics filledRect;
            filledRect = this.CreateGraphics();
            SolidBrush islandBrush = new SolidBrush(Color.Green);
            Rectangle rect2 = new Rectangle((20 * (randcol)), (20 * (randrow)), 20, 20);
            filledRect.FillRectangle(islandBrush, rect2);*/
        }

        // EndGame Button
        private void button1_Click(object sender, EventArgs e)
        {
            // Ask user to play new game
            DialogResult dialogResult = MessageBox.Show("Play New Game?", "Quit Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form myForm = new FindTheIslandGame();
                myForm.Show();
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        // User column guess
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usercol = textBox1.Text;
        }

        // User row guess
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            userrow = textBox2.Text;
        }

        // Submit Button
        private void button2_Click(object sender, EventArgs e)
        {
            int rowguess = Int32.Parse(userrow);
            int colguess = Int32.Parse(usercol);

            if ((rowguess <= 0) || (rowguess > linerows))
            {
                MessageBox.Show("Invalid Row Input");
            }

            else if ((colguess <= 0) || (colguess > linecols))
            {
                MessageBox.Show("Invalid Column Input");
            }

            else
            {
                System.Drawing.Graphics filledRect;
                filledRect = this.CreateGraphics();

                // Show user guess on map.
                SolidBrush brush = new SolidBrush(Color.Brown);
                Rectangle rect = new Rectangle((20 * (colguess)), (20 * (rowguess)), 20, 20);
                filledRect.FillRectangle(brush, rect);          

                if (Map[(rowguess - 1), (colguess - 1)] == true)
                {
                    Direct.Text = "Won";
                    MessageBox.Show("Congratulations: You found the island!");

                    DialogResult dialogResult = MessageBox.Show("Play New Game?", "Game Menu", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form myForm = new FindTheIslandGame();
                        myForm.Show();
                        this.Dispose();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                else
                {
                    // Generate headinmg based on turn number
                    if ((userturn % 2) == 0)
                    {
                        if ((rowguess - randrow) < 0)
                        {
                            Direct.Text = "South";
                        }

                        else if ((rowguess - randrow) == 0)
                        {
                            Direct.Text = "Center";
                        }

                        if ((rowguess - randrow) > 0)
                        {
                            Direct.Text = "North";
                        }

                        userturn++;
                    }

                    else
                    {
                        // Generate headinmg based on turn number
                        if ((colguess - randcol) < 0)
                        {
                            Direct.Text = "East";
                        }

                        else if ((colguess - randcol) == 0)
                        {
                            Direct.Text = "Center";
                        }

                        if ((colguess - randcol) > 0)
                        {
                            Direct.Text = "West";
                        }

                        userturn++;
                    }
                }
            }
        }

        // Help Button
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions: " + Environment.NewLine + 
                            "There is an island hidden within this map."
                            + Environment.NewLine + "The location has been randomly generated."
                            + Environment.NewLine + "Try to find the island by guessing a row and column."
                            + Environment.NewLine + "The game will provide hints of [North/South]" 
                            + Environment.NewLine + "or [East/West], and would alternate between the pairs"
                            + Environment.NewLine + "beginning with [North/South] then [East/West]."
                            + Environment.NewLine + "If [Center] is displayed, then movement of that axis"
                            + Environment.NewLine + "is not required. The Heading lable will display hints."
                            + Environment.NewLine + "Hit the [Submit] button to evaluate your guess.");

        }
    
        /*private string ToString(int a, int b)
        {
            string Values = a.ToString() + ", " + b.ToString();
            return Values;            
        }*/
    }
}
